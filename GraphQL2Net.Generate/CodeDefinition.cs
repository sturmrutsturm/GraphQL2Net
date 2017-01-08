using System.Collections.Generic;
using System.IO;

namespace GraphQL2Net.Generate {
	public class CodeDefinition {
		public string PreText { get; set; }
		public string PostText { get; set; }
		public string Indent { get; set; }
		public readonly List<CodeDefinition> Children = new List<CodeDefinition>();
		public bool NewLineAtEnd { get; set; }
		public bool NewLineAfterPre { get; set; }

		public static CodeDefinition Block(string pre, params CodeDefinition[] children) {
			var def = new CodeDefinition {PreText = pre + " {", PostText = "}", NewLineAtEnd = true, NewLineAfterPre = true, Indent = "\t"};
			foreach (var child in children) {
				def.Children.Add(child);
			}

			return def;
		}

		public static implicit operator CodeDefinition(string text) {
			return new CodeDefinition() {PreText = text, NewLineAtEnd = true};
		}

		public void Write(StreamWriter writer, string indent) {
			if (PreText != null) {
				writer.Write(indent);
				writer.Write(PreText);
			}
			if (NewLineAfterPre) {
				writer.WriteLine();
			}
			string childIndent = indent + Indent;

			foreach (var child in Children) {
				child.Write(writer, childIndent);
			}

			if (PostText != null) {
				writer.Write(indent);
				writer.Write(PostText);
			}
			if (NewLineAtEnd) {
				writer.WriteLine();
			}
		}
	}
}
