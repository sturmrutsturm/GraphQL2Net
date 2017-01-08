using System.Collections.Generic;

namespace GraphQL2Net.Generate {
	class CodeHelper {
		private static readonly HashSet<string> Keywords = new HashSet<string> {
			"abstract", "as", "base", "bool",
			"break", "byte", "case", "catch",
			"char", "checked", "class", "const",
			"continue", "decimal", "default", "delegate",
			"do", "double  else", "enum",
			"event", "explicit", "extern", "false",
			"finally", "fixed", "float", "for",
			"foreach", "goto", "if", "implicit",
			"in", "in", "int", "interface",
			"internal", "is", "lock", "long",
			"namespace", "new", "null", "object",
			"operator", "out", "out", "override",
			"params", "private", "protected", "public",
			"readonly", "ref", "return", "sbyte",
			"sealed", "short", "sizeof", "stackalloc",
			"static", "string struct  switch",
			"this", "throw", "true", "try",
			"typeof", "uint", "ulong", "unchecked",
			"unsafe", "ushort", "using", "virtual",
			"void", "volatile", "while"
		};

		public static string Escape(string keyword) {
			if (Keywords.Contains(keyword)) {
				return "@" + keyword;
			}

			return keyword;
		}
	}
}
