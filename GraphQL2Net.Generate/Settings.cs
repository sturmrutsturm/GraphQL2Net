using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using GraphQL2Net.Generate.Schema;
using Newtonsoft.Json;

namespace GraphQL2Net.Generate {
	public class Settings {
		private static Stream StdOut;

		public Stream CreateStream(string value) {
			if (value == "stdout") {
				if (StdOut == null) {
					StdOut = Console.OpenStandardOutput();
				}
				return StdOut;
			} else if (value == "") {
				return null;
			} else {
				if (!Path.IsPathRooted(value) && SourceFile != null) {
					value = Path.Combine(Path.GetDirectoryName(SourceFile), value);
				}
				return File.Open(value, FileMode.Create);
			}
		}

		[JsonProperty("schema")]
		public string Schema { get; set; }

		public string SourceFile { get; set; }

		public class OutputParameter {
			[JsonProperty("ns")]
			public string Namespace { get; set; }

			[JsonProperty("file")]
			public string File { get; set; }
		}

		[JsonProperty("ignore-internal")]
		public bool IgnoreInternal { get; set; } = true;

		[JsonProperty("result")]
		public OutputParameter Result { get; set; }

		[JsonProperty("query")]
		public OutputParameter Query { get; set; }

		public IEnumerable<TypeDefinition> GetTypes(IEnumerable<TypeDefinition> schemaTypes) {
			if (IgnoreInternal) {
				return schemaTypes.Where(type => !type.Name.StartsWith("__"));
			} else {
				return schemaTypes;
			}
		}
	}
}