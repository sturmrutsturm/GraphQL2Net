using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace GraphQL2Net.Support {
	public abstract class GraphQLWriter {
		private int _indent = 0;
		private bool _newLine = true;
		private readonly Queue<Action> _todo = new Queue<Action>();
		private readonly HashSet<string> _queued = new HashSet<string>();

		protected abstract void WriteInternal(string text);

		public void Complete() {
			while (_todo.Count > 0) {
				_todo.Dequeue()();
			}
		}

		public void Write(string s) {
			if (_newLine) {
				for (int i = 0; i < _indent; ++i) {
					WriteInternal("\t");
				}
				_newLine = false;
			}
			WriteInternal(s);
		}

		public void WriteLine() {
			Write(Environment.NewLine);
			_newLine = true;
		}

		public void WriteLine(string value) {
			Write(value);
			WriteLine();
		}

		public void PushIndent() {
			++_indent;
		}

		public void PopIndent() {
			--_indent;
		}

		public void Write(Meta _meta) {
			var include = _meta?.Include;
			var skip = _meta?.Skip;
			if (include != null) {
				Write($" @include({include})");
			}
			if (skip != null) {
				Write($" @skip({skip})");
			}
		}

		public void Write(string v, Meta meta) {
			var name = meta?.Name;
			if (name != null) {
				Write(name + ": ");
			}
			Write(v);
		}

		public void WriteEnumValue<T>(VariableReference<T> episode) {
			if (episode.Key != null) {
				Write("$" + episode.Key);
			} else {
				Write(Enum.GetName(typeof(T), episode.Value));
			}
		}

		public void WriteValue(VariableReference<string> str) {
			if (str.Key != null) {
				Write("$" + str.Key);
			} else {
				Write(HttpUtility.JavaScriptStringEncode(str.Value, true));
			}
		}

		public void WriteValue(VariableReference<int> i) {
			if (i.Key != null) {
				Write("$" + i.Key);
			} else {
				Write(i.Value.ToString());
			}
		}

		public void WriteValue(VariableReference<bool> b) {
			if (b.Key != null) {
				Write("$" + b.Key);
			} else {
				Write(b.Value ? "true" : "false");
			}
		}

		public void WriteValue<T>(VariableReference<T> s, bool json = false) where T : IInputStruct {
			if (s.Key != null) {
				Write("$" + s.Key);
			} else {
				s.Value.Write(this, json);
			}
		}

		public void WriteValue(VariableReference<IScalar> s) {
			if (s.Key != null) {
				Write("$" +s.Key);
			} else {
				Write(HttpUtility.JavaScriptStringEncode(s.Value.Value));
			}
		}

		public void WriteFragment(INode node, string parentType) {
			if (node.Meta?.Name != null) {
				Write("...");
				Write(node.Meta.Name);
				Write(node.Meta);
				WriteLine();
				if (_queued.Add(node.Meta.Name)) {
					_todo.Enqueue(() => {
						WriteLine($"fragment {node.Meta.Name} on {parentType} {{");
						PushIndent();
						foreach (var v in node.Children) {
							v.Write(this);
						}
						PopIndent();
						WriteLine("}");
					});
				}
			} else {
				Write("...");
				Write(node.Meta);
				WriteLine(" {");
				PushIndent();
				foreach (var v in node.Children) {
					v.Write(this);
				}
				PopIndent();
				WriteLine("}");
			}
		}
	}

	public class StringGraphQLWriter : GraphQLWriter {
		private readonly StringBuilder _builder = new StringBuilder();

		public string CreateString() {
			Complete();
			return _builder.ToString();
		}

		protected override void WriteInternal(string text) {
			_builder.Append(text);
		}
	}
}
