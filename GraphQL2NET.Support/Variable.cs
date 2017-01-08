using System;
using System.Collections.Generic;

namespace GraphQL2Net.Support {
	public interface IVariableReference {
		string Key { get; }
		string Type { get; }
		bool HasValue { get; }
	}

	public abstract class Variable {
		private readonly string _key;

		public string Key => _key;

		public abstract bool HasValue { get; }
		public abstract void Write(GraphQLWriter writer);

		protected Variable(string key) {
			_key = key;
		}
	}

	public abstract class Variable<T> : Variable {
		public abstract T Value { get; set; }

		protected Variable(string key) : base(key) {}
	}

	public interface IVariableContainer {
		Dictionary<string, Variable> Variables { get; }
	}

	public static class VariableExtensions {
		public static string GetJSON(this IVariableContainer container) {
			var writer = new StringGraphQLWriter();
			writer.WriteLine("{");
			bool first = true;
			foreach (var v in container.Variables) {
				if (v.Value.HasValue) {
					if (first) {
						first = false;
					} else {
						writer.Write(", ");
					}
					writer.Write("\"" + v.Key + "\": ");
					v.Value.Write(writer);
				}
			}
			writer.WriteLine();
			writer.WriteLine("}");

			return writer.CreateString();
		}
	}

	public class StringVariable : Variable<string> {
		public override string Value { get; set; }

		public override bool HasValue => Value != null;

		public override void Write(GraphQLWriter writer) {
			writer.WriteValue(Value ?? string.Empty);
		}

		public StringVariable(string key, Dictionary<string, Variable> owner) : base(key) {
			Value = null;
			owner[key] = this;
		}
	}

	public class BoolVariable : Variable<bool?> {
		public override bool? Value { get; set; }

		public override bool HasValue => Value.HasValue;

		public override void Write(GraphQLWriter writer) {
			writer.Write(Value.HasValue && Value.Value ? "true" : "false");
		}

		public BoolVariable(string key, Dictionary<string, Variable> owner) : base(key) {
			Value = null;
			owner[key] = this;
		}
	}

	public class InputVariable<T> : Variable<T> where T : IInputStruct {
		public override T Value { get; set; }

		public override bool HasValue => true;

		public override void Write(GraphQLWriter writer) {
			Value.Write(writer, true);
		}

		public InputVariable(string key, Dictionary<string, Variable> owner) : base(key) {
			Value = default(T);
			owner[key] = this;
		}
	}

	public struct VariableReference<T> : IVariableReference {
		public string Key { get; private set; }
		public T Value { get; set; }
		public bool HasValue { get; set; }
		public string Type { get; set; }

		public static implicit operator VariableReference<T>(T value) {
			return new VariableReference<T> {Value = value, HasValue = true};
		}

		public static implicit operator VariableReference<T>(Variable<T> key) {
			return new VariableReference<T> {Key = key.Key, HasValue = true};
		}
	}
}