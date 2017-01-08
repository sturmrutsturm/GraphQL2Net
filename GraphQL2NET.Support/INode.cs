using System.Collections.Generic;

namespace GraphQL2Net.Support {
	public interface INode {
		void Write(GraphQLWriter writer);
		void GetVariables(Dictionary<string, IVariableReference> variables);
		IEnumerable<INode> Children { get; }
		Meta Meta { get; }
		System.Type ResultType { get; }
	}
}
