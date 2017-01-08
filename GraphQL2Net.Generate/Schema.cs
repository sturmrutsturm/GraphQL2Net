using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GraphQL2Net.Generate.Schema {
	public class FieldComparer : IEqualityComparer<Field> {
		public bool Equals(Field x, Field y) {
			if (x == y) {
				return true;
			}

			if (x == null || y == null) {
				return false;
			}

			if (x.Name != y.Name) {
				return false;
			}

			return EqualsType(x.Type, y.Type) && EqualsArgs(x.Args, y.Args);
		}

		private bool EqualsArgs(Arg[] xArgs, Arg[] yArgs) {
			if (xArgs == yArgs) {
				return true;
			}

			if (xArgs == null || yArgs == null) {
				return false;
			}

			if (xArgs.Length != yArgs.Length) {
				return false;
			}

			for (int i = 0; i < xArgs.Length; ++i) {
				if (xArgs[i].DefaultValue != yArgs[i].DefaultValue ||
					xArgs[i].Name != yArgs[i].Name ||
					!EqualsType(xArgs[i].Type, yArgs[i].Type)) {
					return false;
				}
			}

			return true;
		}

		private bool EqualsType(FieldType xType, FieldType yType) {
			if (xType == yType) {
				return true;
			}

			if (xType == null || yType == null) {
				return false;
			}
			return xType.Kind == yType.Kind &&
				xType.Name == yType.Name &&
				EqualsType(xType.OfType, yType.OfType);
		}

		public int GetHashCode(Field obj) {
			return obj.Type.GetHashCode() ^ obj.Name.GetHashCode();
		}
	}

	[JsonConverter(typeof(SchemaAndErrorsConverter))]
	public class SchemaAndErrors {
		public SchemaRoot Root { get; set; }

		[JsonIgnore]
		public Dictionary<string, List<string>> Interfaces;
	}

	[JsonConverter(typeof(EnumTypeConverter))]
	public enum EnumType {
		NonNull,
		Object,
		List,
		Scalar,
		Enum,
		Interface,
		Union,
		InputObject
	}

	public class EnumTypeConverter : JsonConverter {
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {
			throw new NotImplementedException();
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) {
			switch ((string)reader.Value) {
				case "NON_NULL":
					return EnumType.NonNull;
				case "OBJECT":
					return EnumType.Object;
				case "LIST":
					return EnumType.List;
				case "SCALAR":
					return EnumType.Scalar;
				case "ENUM":
					return EnumType.Enum;
				case "INTERFACE":
					return EnumType.Interface;
				case "UNION":
					return EnumType.Union;
				case "INPUT_OBJECT":
					return EnumType.InputObject;
				default:
					throw new NotSupportedException();
			}
		}

		public override bool CanConvert(Type objectType) {
			throw new NotImplementedException();
		}
	}

	public class SchemaAndErrorsConverter : JsonConverter {
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {
			throw new NotImplementedException();
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) {
			SchemaAndErrors output = new SchemaAndErrors();
			switch (reader.TokenType) {
				case JsonToken.StartArray:
					reader.Read();
					output.Root = JObject.Load(reader).ToObject<SchemaRoot>(serializer);
					if (reader.TokenType != JsonToken.EndObject) {
						throw new Exception("Error parsing JSON");
					}
					reader.Read();
					switch (reader.TokenType) {
						case JsonToken.StartArray:
							// TODO: Parse JSON
							reader.Read();
							reader.Read();
							break;
						case JsonToken.EndArray:
							break;
						default:
							throw new NotSupportedException();
					}
					break;
				case JsonToken.StartObject:
					output.Root = JObject.Load(reader).ToObject<SchemaRoot>(serializer);
					break;
				default:
					throw new NotSupportedException();
			}
			return output;
		}

		public override bool CanConvert(Type objectType) {
			throw new NotImplementedException();
		}
	}

	public class DataRoot {
		[JsonProperty("__schema")]
		public Schema Schema { get; set; }
	}

	public class SchemaRoot {
		[JsonProperty("__schema")]
		public Schema Schema { get; set; }

		[JsonProperty("data")]
		public DataRoot Data {
			set { Schema = value.Schema; }
		}
	}

	public class QueryType : NamedObject { }

	public class Schema {
		[JsonProperty("queryType")]
		public QueryType QueryType { get; set; }

		[JsonProperty("mutationType")]
		public QueryType MutationType { get; set; }

		[JsonProperty("types")]
		public TypeDefinition[] Types { get; set; }
	}

	public abstract class NamedObject {
		[JsonProperty("name")]
		public string Name { get; set; }
	}

	public abstract class DescribedObject : NamedObject {
		[JsonProperty("description")]
		public string Description { get; set; }
	}

	public abstract class DeprecatableObject : DescribedObject {
		[JsonProperty("deprecationReason")]
		public string DeprecationReason { get; set; }

		[JsonProperty("isDeprecated")]
		public bool IsDeprecated { get; set; }
	}

	public class TypeDefinition : DescribedObject {
		[JsonProperty("enumValues")]
		public Field[] EnumValues { get; set; }

		[JsonProperty("fields")]
		public Field[] Fields { get; set; }

		[JsonProperty("inputFields")]
		public InputField[] InputFields { get; set; }

		[JsonProperty("interfaces")]
		public FieldType[] Interfaces { get; set; }

		[JsonProperty("kind")]
		public EnumType Kind { get; set; }

		[JsonProperty("possibleTypes")]
		public FieldType[] PossibleTypes { get; set; }
	}

	public class Field : DeprecatableObject {
		[JsonProperty("args")]
		public Arg[] Args { get; set; }

		[JsonProperty("type")]
		public FieldType Type { get; set; }

		public override string ToString() {
			if (Args != null) {
				return $"{Type}({string.Join(", ", Args.Select(a => a.ToString()).ToArray())} {Name}";
			}

			return Type + " " + Name;
		}
	}

	public class InputField : DeprecatableObject {
		[JsonProperty("type")]
		public FieldType Type { get; set; }

		[JsonProperty("defaultValue")]
		public string DefaultValue { get; set; }

		public override string ToString() {
			return Type + " " + Name + " = " + DefaultValue;
		}
	}

	public class Arg : DescribedObject {
		[JsonProperty("defaultValue")]
		public string DefaultValue { get; set; }

		[JsonProperty("type")]
		public FieldType Type { get; set; }

		public override string ToString() {
			if (DefaultValue != null) {
				return $"{Type} {Name} = {DefaultValue}";
			} else {
				return $"{Type} {Name}";
			}
		}
	}

	public class FieldType : NamedObject {
		[JsonProperty("kind")]
		public EnumType Kind { get; set; }

		[JsonProperty("ofType")]
		public FieldType OfType { get; set; }

		public override string ToString() {
			switch (Kind) {
				case EnumType.List:
					return $"List<{OfType}>";
				case EnumType.NonNull:
					return OfType + "!";
				case EnumType.Enum:
				case EnumType.Interface:
				case EnumType.Object:
				case EnumType.Scalar:
				case EnumType.InputObject:
					return Name;
				default:
					throw new NotSupportedException();
			}
		}
	}

	public class EnumValue : DeprecatableObject {
		
	}
}
