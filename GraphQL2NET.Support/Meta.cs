using System.Collections.Generic;

namespace GraphQL2Net.Support {
	public class Meta {
		public string Name { get; set; }
		public IFilter Include { get; set; }
		public IFilter Skip { get; set; }

		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			Include?.GetVariables(variables);
			Skip?.GetVariables(variables);
		}
	}
}
