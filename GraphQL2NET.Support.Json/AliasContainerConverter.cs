using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GraphQL2Net.Support.Json {
	class AliasContainerConverter : JsonConverter{
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {
			throw new NotImplementedException();
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) {
			throw new NotImplementedException();
		}

		public override bool CanConvert(Type objectType) {
			for (Type t = objectType; t != null; t = t.BaseType) {
				if (t == typeof(AliasContainer)) {
					return true;
				}
			}

			return false;
		}
	}
}
