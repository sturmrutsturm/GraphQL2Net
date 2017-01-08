using System.Collections.Generic;

namespace GraphQL2Net.Generate {
	public struct ScalarDefinition {
		public string Value { get; private set; }
		public bool IsNullByDefault { get; private set; }

		public ScalarDefinition(string value, bool nullByDefault = false) {
			Value = value;
			IsNullByDefault = nullByDefault;
		}
		public static readonly Dictionary<string, ScalarDefinition> ScalarLookup = new Dictionary<string, ScalarDefinition> {
			{"Int", new ScalarDefinition("int")},
			{"__Unit", new ScalarDefinition("object", true)},
			{"String", new ScalarDefinition("string", true)},
			{"Boolean", new ScalarDefinition("bool")},
			{"Float", new ScalarDefinition("float")},
			{"ID", new ScalarDefinition("string", true)}
		};
	}
}