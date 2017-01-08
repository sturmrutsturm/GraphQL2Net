using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using GraphQL2Net.Generate.Schema;
using NDesk.Options;
using Newtonsoft.Json;

namespace GraphQL2Net.Generate {
	partial class Program {
		private static string SchemaQuery = @"{""query"":""
  query IntrospectionQuery {
    __schema {
      queryType { name }
      mutationType { name }
      types {
        ...FullType
      }
    }
  }

  fragment FullType on __Type {
    kind
    name
    description
    fields(includeDeprecated: true) {
      name
      description
      args {
        ...InputValue
      }
      type {
        ...TypeRef
      }
      isDeprecated
      deprecationReason
    }
    inputFields {
      ...InputValue
    }
    interfaces {
      ...TypeRef
    }
    enumValues(includeDeprecated: true) {
      name
      description
      isDeprecated
      deprecationReason
    }
    possibleTypes {
      ...TypeRef
    }
  }

  fragment InputValue on __InputValue {
    name
    description
    type { ...TypeRef }
    defaultValue
  }

  fragment TypeRef on __Type {
    kind
    name
    ofType {
      kind
      name
      ofType {
        kind
        name
        ofType {
          kind
          name
          ofType {
            kind
            name
            ofType {
              kind
              name
              ofType {
                kind
                name
                ofType {
                  kind
                  name
                }
              }
            }
          }
        }
      }
    }
  }
"",""variables"":{}}
";

		private static string ReadFromWeb(string url) {
			WebClient wc = new WebClient();
			wc.Headers["Accept"] = "application/json";
			wc.Headers["Content-Type"] = "application/json";
			return wc.UploadString(url, SchemaQuery.Replace(Environment.NewLine, " ").Replace("\n", " "));
		}

		static void Main(string[] args) {
			foreach (var arg in args) {
				var file = File.ReadAllText(arg);
				var settings = JsonConvert.DeserializeObject<Settings>(file);
				settings.SourceFile = arg;
				string data;
				if (settings.Schema.StartsWith("http", true, CultureInfo.CurrentCulture)) {
					data = ReadFromWeb(settings.Schema);
				} else {
					data = File.ReadAllText(settings.Schema);
				}

				var json = ReadJson(data, settings);

				if (settings.Query.File != null) {
					var cd = WriteToQueryStream(settings,json);
					using (var writer = new StreamWriter(settings.CreateStream(settings.Query.File), Encoding.UTF8)) {
						cd.Write(writer, string.Empty);
					}
				}

				if (settings.Result.File != null) {
					var cd = WriteToResultStream(settings, json);
					using (var writer = new StreamWriter(settings.CreateStream(settings.Result.File), Encoding.UTF8)) {
						cd.Write(writer, string.Empty);
					}
				}
			}
		}

		private static SchemaAndErrors ReadJson(string data, Settings settings) {
			var jsonSettings = new JsonSerializerSettings {
				MissingMemberHandling = MissingMemberHandling.Error,
			};

			var json = JsonConvert.DeserializeObject<SchemaAndErrors>(data, jsonSettings);

			json.Interfaces = new Dictionary<string, List<string>>();

			foreach (var type in json.Root.Schema.Types) {
				if (type.Kind != EnumType.Interface) {
					continue;
				}

				if (settings.IgnoreInternal && type.Name.StartsWith("__")) {
					continue;
				}

				foreach (var possibility in type.PossibleTypes) {
					List<string> list;
					if (possibility.Kind != EnumType.Object) {
						throw new NotSupportedException();
					}
					if (possibility.OfType != null) {
						throw new NotSupportedException();
					}
					if (json.Interfaces.TryGetValue(possibility.Name, out list) == false) {
						list = new List<string>();
						json.Interfaces[possibility.Name] = list;
					}
					list.Add(type.Name);
				}
			}

			return json;
		}

		static CodeDefinition WriteToQueryStream(Settings settings, SchemaAndErrors json) {
			CodeDefinition root = new CodeDefinition {
				Indent = "",
				NewLineAfterPre = true,
				NewLineAtEnd = false,
				PreText = "// Generated Query Text"
			};
			CodeDefinition usings = new CodeDefinition {
				Indent = "",
				NewLineAfterPre = false,
				NewLineAtEnd = true,
			};
			CodeDefinition ns = CodeDefinition.Block("namespace " + settings.Query.Namespace);

			var ql = CodeDefinition.Block("public static class QL");
			ns.Children.Add(ql);
			if (json.Root.Schema.QueryType != null) {
				string name = json.Root.Schema.QueryType.Name;
				ql.Children.Add(CodeDefinition.Block($"public static GraphQL2Net.Support.Command<{settings.Result.Namespace}.{name}> Compile({settings.Query.Namespace}.{name} query, string queryName = null)",
					$"return new GraphQL2Net.Support.Command<{settings.Result.Namespace}.{name}>(query, \"query\", new {settings.Result.Namespace}.Helper(), queryName);"));
			}
			if (json.Root.Schema.MutationType != null) {
				string name = json.Root.Schema.MutationType.Name;
				ql.Children.Add(CodeDefinition.Block($"public static GraphQL2Net.Support.Command<{settings.Result.Namespace}.{name}> Compile({settings.Query.Namespace}.{name} query, string queryName = null)",
					$"return new GraphQL2Net.Support.Command<{settings.Result.Namespace}.{name}>(query, \"mutation\", new {settings.Result.Namespace}.Helper(), queryName ?? \"mutate\");"));
			}

			root.Children.Add(usings);
			root.Children.Add(ns);

			usings.Children.Add("using GraphQL2Net.Support;");
			usings.Children.Add("using ObsoleteAttribute = System.ObsoleteAttribute;");
			usings.Children.Add("using NotImplementedException = System.NotImplementedException;");
			usings.Children.Add("using IEnumerator = System.Collections.IEnumerator;");
			usings.Children.Add("using IEnumerable = System.Collections.IEnumerable;");
			usings.Children.Add("using System.Collections.Generic;");

			var filtered = settings.GetTypes(json.Root.Schema.Types).ToArray();

			foreach (var type in filtered.Where(t => t.Kind == EnumType.InputObject)) {
				var s = CodeDefinition.Block($"public struct {CodeHelper.Escape(type.Name)} : IInputStruct");
				var variables = CodeDefinition.Block("public void GetVariables(Dictionary<string, IVariableReference> variables)");
				var write = CodeDefinition.Block("public void Write(GraphQLWriter writer, bool json)");
				ns.Children.Add(s);
				write.Children.Add("writer.Write(\"{ \");");
				bool first = true;
				bool couldBeFirst = true;
				foreach (var field in type.InputFields) {
					var c = new CodeDefinition { Indent = "" };
					AddComment(field, c);
					bool canBeNull = field.Type.Kind != EnumType.NonNull;
					c.Children.Add($"public VariableReference<{GetTypeTextIgnoreNull(field.Type)}>{(canBeNull ? "?" : "")} {CodeHelper.Escape(field.Name)} {{ get; set; }}");
					s.Children.Add(c);
					if (canBeNull) {
						variables.Children.Add($"if ({CodeHelper.Escape(field.Name)}.HasValue && {CodeHelper.Escape(field.Name)}.Value.Key != null) variables[{CodeHelper.Escape(field.Name)}.Value.Key] = {CodeHelper.Escape(field.Name)}.Value;");
					} else {
						variables.Children.Add($"if ({CodeHelper.Escape(field.Name)}.Key != null) variables[{CodeHelper.Escape(field.Name)}.Key] = {CodeHelper.Escape(field.Name)};");
					}
					CodeDefinition block;
					if (canBeNull) {
						block = CodeDefinition.Block($"if ({CodeHelper.Escape(field.Name)}.HasValue)");
						if (first) {
							write.Children.Add("bool first = true;");
						}
						write.Children.Add(block);
					} else {
						block = write;
					}

					if (first) {
						first = false;
						if (canBeNull) {
							block.Children.Add("first = false;");
						}
					} else {
						if (couldBeFirst) {
							block.Children.Add("if (first) first = false;");
							block.Children.Add("else if (json) writer.Write(\", \");");
							block.Children.Add("else writer.Write(\" \");");
						} else {
							block.Children.Add("if (json) writer.Write(\", \");");
						}
					}

					block.Children.Add($"if (json) writer.Write(\"\\\"{field.Name}\\\": \");");
					block.Children.Add($"else writer.Write(\"{field.Name}: \");");
					block.Children.Add($"writer.WriteValue({CodeHelper.Escape(field.Name)}{(canBeNull ? ".Value" : "")});");

					if (!canBeNull) {
						couldBeFirst = false;
					}
				}
				write.Children.Add("writer.Write(\" }\");");

				s.Children.Add(variables);
				s.Children.Add(write);
			}

			var comparer = new FieldComparer();

			var types = filtered.ToDictionary(p => p.Name);
			var todo = new Queue<TypeDefinition>();
			var rootTypes = new List<string>();
			if (json.Root.Schema.QueryType != null) {
				rootTypes.Add(json.Root.Schema.QueryType.Name);
			}
			if (json.Root.Schema.MutationType != null) {
				rootTypes.Add(json.Root.Schema.MutationType.Name);
			}
			var fieldLookup = new Dictionary<string, Field>();
			var interfaceLookup = new Dictionary<string, HashSet<string>>();
			var originalLookup = new Dictionary<string, string>();
			var interfaceOwner = new HashSet<string>();

			foreach (var rootName in rootTypes) {
				todo.Enqueue(types[rootName]);
				fieldLookup[rootName] = new Field {
					Name = rootName,
					Type = new FieldType { Kind = EnumType.Object, Name = rootName }
				};
				originalLookup[rootName] = rootName;
			}


			foreach (var current in settings.GetTypes(json.Root.Schema.Types)) {
				if (current.Kind != EnumType.Object && current.Kind != EnumType.Interface) {
					continue;
				}
				foreach (var field in current.Fields) {
					Field currentField;
					string key;
					if (fieldLookup.TryGetValue(field.Name, out currentField)) {
						if (comparer.Equals(field, currentField)) {
							key = field.Name;
						} else {
							key = current.Name + "_" + field.Name;
						}
					} else {
						key = field.Name;
					}

					key = CodeHelper.Escape(key);

					fieldLookup[key] = field;
					HashSet<string> interfaceList;
					if (!interfaceLookup.TryGetValue(key, out interfaceList)) {
						interfaceList = new HashSet<string>();
						interfaceLookup[key] = interfaceList;
					}
					interfaceList.Add(current.Name);
					interfaceOwner.Add(current.Name);
					originalLookup[key] = ObjectName(field.Type);
				}
			}

			foreach (var i in interfaceOwner) {
				var block = CodeDefinition.Block($"public interface {i}_IChild : INode");
				ns.Children.Add(block);
				var fragment = CodeDefinition.Block($"public class {i}Fragment : {i}_IChild, IEnumerable<{i}_IChild>");
				fragment.Children.Add("GraphQL2Net.Support.Meta _meta;");
				fragment.Children.Add($"public System.Type ResultType {{ get {{ return typeof({settings.Result.Namespace}.{i}); }} }}");
				fragment.Children.Add("public IEnumerable<INode> Children { get { return _children; } }");
				fragment.Children.Add("public Meta Meta { get { return _meta; } }");
				fragment.Children.Add($"private readonly List<{i}_IChild> _children = new List<{i}_IChild>();");
				fragment.Children.Add($"public void Add({i}_IChild child) {{ _children.Add(child); }}");
				fragment.Children.Add($"public IEnumerator<{i}_IChild> GetEnumerator() {{ return _children.GetEnumerator(); }}");
				fragment.Children.Add("IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }");
				var c = CodeDefinition.Block($"public {i}Fragment(Meta _Meta = null)");
				c.Children.Add("_meta = _Meta;");
				var write = CodeDefinition.Block("public void Write(GraphQLWriter writer)");
				write.Children.Add($"writer.WriteFragment(this, \"{i}\");");
				var getVariables = CodeDefinition.Block("public void GetVariables(Dictionary<string, IVariableReference> variables)");
				getVariables.Children.Add("if (_meta != null) { _meta.GetVariables(variables); }");
				getVariables.Children.Add("foreach (var child in _children) child.GetVariables(variables);");
				fragment.Children.Add(c);
				fragment.Children.Add(write);
				fragment.Children.Add(getVariables);
				ns.Children.Add(fragment);
			}

			foreach (var type in settings.GetTypes(json.Root.Schema.Types)) {
				if (type.Kind == EnumType.Object && type.Interfaces != null && type.Interfaces.Length > 0) {
					var sb = new StringBuilder();
					sb.AppendFormat("public class On{0} : IEnumerable<{0}_IChild>", type.Name);
					foreach (var i in type.Interfaces) {
						sb.AppendFormat(", {0}_IChild", i.Name);
					}
					var def = CodeDefinition.Block(sb.ToString());
					def.Children.Add("GraphQL2Net.Support.Meta _meta;");
					def.Children.Add($"public System.Type ResultType {{ get {{ return typeof({settings.Result.Namespace}.{type.Name}); }} }}");
					def.Children.Add("public IEnumerable<INode> Children { get { return _children; } }");
					def.Children.Add("public Meta Meta { get { return _meta; } }");
					def.Children.Add($"private readonly List<{type.Name}_IChild> _children = new List<{type.Name}_IChild>();");
					def.Children.Add($"public void Add({type.Name}_IChild child) {{ _children.Add(child); }}");
					def.Children.Add($"public IEnumerator<{type.Name}_IChild> GetEnumerator() {{ return _children.GetEnumerator(); }}");
					def.Children.Add("IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }");
					var c = CodeDefinition.Block($"public On{type.Name}(Meta _Meta = null)");
					c.Children.Add("_meta = _Meta;");
					var write = CodeDefinition.Block("public void Write(GraphQLWriter writer)");
					write.Children.Add($"writer.Write(\"... on {type.Name}\");");
					write.Children.Add("writer.Write(_meta);");
					write.Children.Add("writer.WriteLine(\" {\");");
					write.Children.Add("writer.PushIndent();");
					write.Children.Add("foreach (var v in _children) v.Write(writer);");
					write.Children.Add("writer.PopIndent();");
					write.Children.Add("writer.WriteLine(\"}\");");
					var getVariables = CodeDefinition.Block("public void GetVariables(Dictionary<string, IVariableReference> variables)");
					getVariables.Children.Add("if (_meta != null) { _meta.GetVariables(variables); }");
					getVariables.Children.Add("foreach (var child in _children) child.GetVariables(variables);");
					def.Children.Add(c);
					def.Children.Add(write);
					def.Children.Add(getVariables);
					ns.Children.Add(def);
				}
			}

			foreach (var pair in fieldLookup) {
				var originalType = originalLookup[pair.Key];
				var sb = new StringBuilder();
				sb.AppendFormat("public class {0}", pair.Key);
				bool firstInterface = true;
				bool isContainer = false;
				if (originalType != null && interfaceOwner.Contains(originalType)) {
					sb.Append(firstInterface ? " : " : ", ");
					firstInterface = false;
					sb.AppendFormat("IEnumerable<{0}_IChild>", originalType);
					isContainer = true;
				}

				HashSet<string> interfaceList;
				if (interfaceLookup.TryGetValue(pair.Key, out interfaceList)) {
					foreach (var i in interfaceList) {
						sb.Append(firstInterface ? " : " : ", ");
						firstInterface = false;
						sb.AppendFormat("{0}_IChild", i);
					}
				} else {
					sb.Append(firstInterface ? " : " : ", ");
					firstInterface = false;
					sb.Append("INode");
				}
				CodeDefinition typeDefinition = new CodeDefinition();
				CodeDefinition cd = CodeDefinition.Block(sb.ToString());
				DeprecatableObject obj = pair.Value;
				typeDefinition.Children.Add(cd);
				CodeDefinition enumerable = new CodeDefinition();
				CodeDefinition constructor = new CodeDefinition();
				CodeDefinition fields = new CodeDefinition();
				fields.Children.Add("GraphQL2Net.Support.Meta _meta;");
				fields.Children.Add($"public System.Type ResultType {{ get {{ return {GetResultType(settings, pair.Value.Type)}; }} }}");
				if (isContainer) {
					fields.Children.Add("public IEnumerable<INode> Children { get { return _children; } }");
				} else {
					fields.Children.Add("public IEnumerable<INode> Children { get { return new INode[0]; } }");
				}
				fields.Children.Add("public Meta Meta { get { return _meta; } }");
				cd.Children.Add(fields);
				cd.Children.Add(enumerable);
				cd.Children.Add(constructor);

				CodeDefinition toString = CodeDefinition.Block("public void Write(GraphQLWriter writer)");
				cd.Children.Add(toString);
				if (!rootTypes.Contains(pair.Value.Name)) {
					toString.Children.Add($"writer.Write(\"{pair.Value.Name}\", _meta);");
				}

				CodeDefinition getVariables = CodeDefinition.Block("public void GetVariables(Dictionary<string, IVariableReference> variables)");
				getVariables.Children.Add("if (_meta != null) { _meta.GetVariables(variables); }");
				if (pair.Value.Args != null) {
					foreach (var arg in pair.Value.Args) {
						getVariables.Children.Add($"if (_{arg.Name}.Key != null) variables[_{arg.Name}.Key] = _{arg.Name};");
					}
				}

				if (isContainer) {
					CodeDefinition childVariables = CodeDefinition.Block("foreach (var child in _children)");
					childVariables.Children.Add("child.GetVariables(variables);");
					getVariables.Children.Add(childVariables);
				}

				cd.Children.Add(getVariables);

				if (isContainer) {
					enumerable.Children.Add($"private readonly List<{originalType}_IChild> _children = new List<{originalType}_IChild>();");
					enumerable.Children.Add($"public void Add({originalType}_IChild child) {{ _children.Add(child); }}");
					enumerable.Children.Add($"public IEnumerator<{originalType}_IChild> GetEnumerator() {{ return _children.GetEnumerator(); }}");
					enumerable.Children.Add($"IEnumerator IEnumerable.GetEnumerator() {{ return GetEnumerator(); }}");
				}
				bool hasArgs = pair.Value.Args != null && pair.Value.Args.Length > 0;
				if (hasArgs) {
					toString.Children.Add("bool hasParameters = false;");
				}

				var c = new CodeDefinition();
				var comment = AddComment(pair.Value, c);
				var func = CodeDefinition.Block("");
				c.Children.Add(func);
				StringBuilder txt = new StringBuilder();
				txt.AppendFormat("public {0}(", pair.Key);
				bool first = true;
				if (hasArgs) {
					foreach (var arg in pair.Value.Args) {
						ScalarDefinition def;
						var type = arg.Type;
						while (type.Kind == EnumType.NonNull) {
							type = type.OfType;
						}

						string typeName;
						if (type.Kind == EnumType.Enum) {
							typeName = settings.Result.Namespace + "." + type.Name;
						} else if (ScalarDefinition.ScalarLookup.TryGetValue(type.Name, out def)) {
							typeName = def.Value;
						} else if (type.Kind == EnumType.InputObject) {
							typeName = CodeHelper.Escape(type.Name);
						} else {
							typeName = "string";
						}
						if (first) {
							first = false;
						} else {
							txt.Append(", ");
						}

						string fieldType = $"VariableReference<{typeName}>";
						txt.AppendFormat("{0} {1} = default({0})", fieldType, arg.Name);
						fields.Children.Add($"private readonly {fieldType} _{arg.Name};");
						func.Children.Add($"_{arg.Name} = {arg.Name};");
						func.Children.Add($"_{arg.Name}.Type = \"{arg.Type}\";");
						if (arg.Description != null) {
							var sw = new StringWriter();
							var writer = new System.Xml.XmlTextWriter(sw);
							writer.WriteString(arg.Description);
							writer.Close();
							var split = sw.ToString().Split('\n');
							if (split.Length == 1) {
								comment.Children.Add($"<param name=\"{arg.Name}\">{split[0]}</param>");
							} else {
								comment.Children.Add($"<param name=\"{arg.Name}\">");
								foreach (var s in split) {
									comment.Children.Add(s);
								}
								comment.Children.Add($"</param>");
							}

						}
						var block = CodeDefinition.Block($"if (_{arg.Name}.HasValue)");
						toString.Children.Add(block);
						block.Children.Add("if (hasParameters) writer.Write(\", \");");
						block.Children.Add("else { hasParameters = true; writer.Write(\"(\"); }");
						block.Children.Add($"writer.Write(\"{arg.Name}: \");");
						var argType = arg.Type.Kind == EnumType.NonNull ? arg.Type.OfType : arg.Type;
						block.Children.Add($"writer.Write{(argType.Kind == EnumType.Enum ? "Enum": "")}Value(_{arg.Name});");
					}
				}
				if (hasArgs) {
					txt.Append(", ");
				}
				txt.Append("Meta _Meta = null");
				txt.Append(") {");
				func.PreText = txt.ToString();
				func.Children.Add("_meta = _Meta;");
				constructor.Children.Add(c);
				if (hasArgs) {
					toString.Children.Add("if (hasParameters) writer.Write(\")\");");
				}

				toString.Children.Add("writer.Write(_meta);");

				if (isContainer) {
					toString.Children.Add("writer.WriteLine(\" {\");");
					toString.Children.Add("writer.PushIndent();");
					var realType = pair.Value.Type.Kind == EnumType.NonNull ? pair.Value.Type.OfType : pair.Value.Type;
					if (realType.Kind == EnumType.Interface) {
						toString.Children.Add("writer.WriteLine(\"__typename\");");
					}
					toString.Children.Add("foreach (var v in _children) v.Write(writer);");
					toString.Children.Add("writer.PopIndent();");
					toString.Children.Add("writer.WriteLine(\"}\");");
				} else {
					toString.Children.Add("writer.WriteLine(\"\");");
				}

				ns.Children.Add(typeDefinition);
			}
			return root;
		}

		private static CodeDefinition AddComment(DeprecatableObject obj, CodeDefinition cd) {
			var comment = new CodeDefinition { Indent = "/// " };
			cd.Children.Add(comment);
			if (obj.Description != null) {
				comment.Children.Add("<summary>");
				var sw = new StringWriter();
				var writer = new System.Xml.XmlTextWriter(sw);
				writer.WriteString(obj.Description);
				writer.Close();
				foreach (var str in sw.ToString().Split('\n')) {
					comment.Children.Add(str.Replace("\r", ""));
				}
				comment.Children.Add("</summary>");
			}
			if (obj.IsDeprecated) {
				if (!string.IsNullOrEmpty(obj.DeprecationReason)) {
					cd.Children.Add(string.Format("[System.Obsolete(\"{0}\")]",
						obj.DeprecationReason
							.Replace("\\", "\\\\")
							.Replace("\n", "\\n")
							.Replace("\"", "\\\"")));
				} else {
					cd.Children.Add("[System.Obsolete]");
				}
			}

			return comment;
		}

		private static string GetResultType(Settings settings, FieldType valueType) {
			switch (valueType.Kind) {
				case EnumType.NonNull:
					return GetResultType(settings, valueType.OfType);
				case EnumType.Enum:
				case EnumType.Interface:
				case EnumType.Object:
				case EnumType.Union:
					return $"typeof({settings.Result.Namespace}.{valueType.Name})";
				case EnumType.List:
					return GetResultType(settings, valueType.OfType) + ".MakeArrayType()";
				case EnumType.Scalar:
					ScalarDefinition def;
					if (ScalarDefinition.ScalarLookup.TryGetValue(valueType.Name, out def)) {
						return $"typeof({def.Value})";
					}
					throw new NotSupportedException();
				default:
					throw new NotSupportedException();
			}
		}

		private static string ObjectName(FieldType fieldType) {
			while (fieldType != null && fieldType.Kind != EnumType.Object && fieldType.Kind != EnumType.Interface) {
				fieldType = fieldType.OfType;
			}

			return fieldType?.Name;
		}

		static CodeDefinition WriteToResultStream(Settings settings, SchemaAndErrors json) {
			CodeDefinition root = new CodeDefinition {
				Indent = "",
				NewLineAfterPre = true,
				NewLineAtEnd = false,
				PreText = "// Generated Result Text"
			};
			CodeDefinition usings = new CodeDefinition {
				Indent = "",
				NewLineAfterPre = false,
				NewLineAtEnd = true,
			};
			CodeDefinition ns = CodeDefinition.Block($"namespace {settings.Result.Namespace}");

			root.Children.Add(usings);
			root.Children.Add(ns);

			usings.Children.Add("using GraphQL2Net.Support;");
			usings.Children.Add("using ObsoleteAttribute = System.ObsoleteAttribute;");
			usings.Children.Add("using NotImplementedException = System.NotImplementedException;");
			usings.Children.Add("using IEnumerator = System.Collections.IEnumerator;");
			usings.Children.Add("using IEnumerable = System.Collections.IEnumerable;");
			usings.Children.Add("using System.Collections.Generic;");

			CodeDefinition helper = CodeDefinition.Block("public class Helper : IHelper");
			CodeDefinition resolver = CodeDefinition.Block("public System.Type GetTypeObject(string typename)");
			CodeDefinition resolverSwitch = CodeDefinition.Block("switch (typename)");
			ns.Children.Add(helper);
			helper.Children.Add(resolver);
			resolver.Children.Add(resolverSwitch);

			foreach (var type in settings.GetTypes(json.Root.Schema.Types)) {
				if (type.Kind == EnumType.Object) {
					resolverSwitch.Children.Add($"case \"{type.Name}\": return typeof({type.Name});");
				}
			}

			resolverSwitch.Children.Add("default: return null;");

			foreach (var type in settings.GetTypes(json.Root.Schema.Types)) {
				switch (type.Kind) {
					case EnumType.Enum: {
						var e = CodeDefinition.Block($"public enum {type.Name}");
						ns.Children.Add(e);
						CodeDefinition prev = null;
						foreach (var value in type.EnumValues) {
							if (prev != null) {
								prev.PostText += ",";
							}
							prev = CreateField(value, ContainerType.Enum);
							prev.NewLineAtEnd = true;
							e.Children.Add(prev);
						}
						break;
					}
					case EnumType.InputObject:
						break;
					case EnumType.Object: {
						StringBuilder sb = new StringBuilder();
						string name = CodeHelper.Escape(type.Name);
						sb.Append($"public class {name} : AliasContainer");
						List<string> list;
						if (json.Interfaces.TryGetValue(type.Name, out list)) {
							foreach (var item in list) {
								sb.Append(", ");
								sb.Append(item);
							}
						}
						var o = CodeDefinition.Block(sb.ToString());
						ns.Children.Add(o);
						foreach (var field in type.Fields) {
							var created = CreateField(field, ContainerType.Class);
							created.NewLineAtEnd = true;
							o.Children.Add(created);
						}
						break;
					}
					case EnumType.Scalar:
						if (!ScalarDefinition.ScalarLookup.ContainsKey(type.Name)) {
							var o = CodeDefinition.Block($"public struct {type.Name} : IScalar");
							o.Children.Add("public string Value { get; set; }");
							ns.Children.Add(o);
						}
						break;
					case EnumType.Union: {
						var o = CodeDefinition.Block($"public interface {type.Name}");
						ns.Children.Add(o);
						break;
					}
					case EnumType.Interface: {
							var o = CodeDefinition.Block($"public interface {type.Name}");
							ns.Children.Add(o);
							foreach (var field in type.Fields) {
								var c = CreateField(field, ContainerType.Interface);
								c.NewLineAtEnd = true;
								o.Children.Add(c);
							}
							break;
						}
					case EnumType.List:
					case EnumType.NonNull:
					default:
						throw new NotSupportedException();
				}
			}

			return root;
		}

		public enum ContainerType {
			Enum,
			Interface,
			Class
		}

		static CodeDefinition CreateField(Field field, ContainerType container) {
			CodeDefinition cd = new CodeDefinition {Indent = ""};
			AddComment(field, cd);
			StringBuilder sb = new StringBuilder();
			if (container == ContainerType.Class) {
				sb.Append("public ");
			}
			if (field.Type != null) {
				sb.Append(GetTypeText(field.Type) + " ");
			}
			sb.Append(CodeHelper.Escape(field.Name));
			switch (container) {
				case ContainerType.Class:
					sb.Append(" { get; set; }");
					break;
				case ContainerType.Interface:
					sb.Append("{ get; }");
					break;
			}
			cd.PostText = sb.ToString();
			return cd;
		}

		static string GetTypeTextIgnoreNull(FieldType type) {
			switch (type.Kind) {
				case EnumType.Interface:
				case EnumType.Union:
//					throw new NotSupportedException();
				case EnumType.Object:
					if (type.OfType != null) {
						throw new NotSupportedException();
					}
					return type.Name;
				case EnumType.NonNull:
					return GetTypeTextIgnoreNull(type.OfType);
				case EnumType.List:
					return $"List<{GetTypeTextIgnoreNull(type.OfType)}>";
				case EnumType.Scalar:
					if (type.OfType != null) {
						throw new NotSupportedException();
					}
					ScalarDefinition realType;
					if (ScalarDefinition.ScalarLookup.TryGetValue(type.Name, out realType)) {
						return realType.Value;
					} else {
						throw new NotSupportedException();
					}
				case EnumType.Enum:
					if (type.OfType != null) {
						throw new NotSupportedException();
					}
					return type.Name;
				default:
					throw new NotSupportedException();
			}
		}

		static string GetTypeText(FieldType type, bool canBeNull = true) {
			switch (type.Kind) {
				case EnumType.Interface:
				case EnumType.Union:
//					throw new NotSupportedException();
				case EnumType.Object:
					if (type.OfType != null) {
						throw new NotSupportedException();
					}
					return type.Name;
				case EnumType.NonNull:
					if (!canBeNull) {
						throw new NotSupportedException();
					}
					return GetTypeText(type.OfType, false);
				case EnumType.List:
					if (canBeNull) {
						return $"List<{GetTypeText(type.OfType)}>";
					} else {
						return $"NotNull<List<{GetTypeText(type.OfType)}>>";
					}
				case EnumType.Scalar:
					if (type.OfType != null) {
						throw new NotSupportedException();
					}
					ScalarDefinition realType;
					if (ScalarDefinition.ScalarLookup.TryGetValue(type.Name, out realType)) {
						if (canBeNull) {
							if (realType.IsNullByDefault) {
								return realType.Value;
							} else {
								return realType.Value + "?";
							}
						} else {
							if (realType.IsNullByDefault) {
								return $"NotNull<{realType.Value}>";
							} else {
								return realType.Value;
							}
						}
					} else {
						throw new NotSupportedException();
					}
				case EnumType.Enum:
					if (type.OfType != null) {
						throw new NotSupportedException();
					}
					if (canBeNull) {
						return type.Name + "?";
					} else {
						return type.Name;
					}
				default:
					throw new NotSupportedException();
			}
		}
	}
}
