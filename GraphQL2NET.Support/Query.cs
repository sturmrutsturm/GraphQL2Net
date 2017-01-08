using System.Collections.Generic;

namespace GraphQL2Net.Support {
	public class Command {
		public readonly string QueryText;
		public readonly string QueryName;
		public readonly INode Node;
		public readonly IHelper Helper;
		public Command(INode o, string prefix, IHelper helper, string queryName) {
			Node = o;
			Helper = helper;
			var writer = new StringGraphQLWriter();
			if (queryName != null) {
				var list = new Dictionary<string, IVariableReference>();
				o.GetVariables(list);
				writer.Write($"{prefix} {queryName}");
				if (list.Count > 0) {
					writer.Write("(");
					bool first = true;
					foreach (var v in list) {
						if (first) {
							first = false;
						} else {
							writer.Write(", ");
						}
						writer.Write($"${v.Key}: {v.Value.Type}");
					}
					writer.Write(")");
				}
			}
			o.Write(writer);
			QueryText = writer.CreateString();
			QueryName = queryName;
		}

		public override string ToString() {
			return QueryText;
		}
	}

	public class Command<TResult> : Command {
		public Command(INode o, string prefix, IHelper helper, string queryName) : base(o, prefix, helper, queryName) {
			
		}
	}
}
