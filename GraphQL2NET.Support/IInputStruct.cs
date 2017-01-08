using System.Collections.Generic;

namespace GraphQL2Net.Support {
	public interface IInputStruct {
		void GetVariables(Dictionary<string, IVariableReference> variables);
		void Write(GraphQLWriter writer, bool json);
	}
}
