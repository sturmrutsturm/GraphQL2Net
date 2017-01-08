using System.Collections.Generic;

namespace GraphQL2Net.Support {
	public interface IFilter {
		void GetVariables(Dictionary<string, IVariableReference> variables);
	}

	public class If : IFilter {
		private VariableReference<bool?> _variable;

		public If(Variable<bool?> variable) {
			_variable = variable;
			_variable.Type = "Boolean!";
		}

		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			variables[_variable.Key] = _variable;
		}

		public override string ToString() {
			return $"if: ${_variable.Key}";
		}
	}
}
