using System;
using System.Reflection;
using Newtonsoft.Json;

namespace GraphQL2Net.Support.Json {
	public class NotNullConverter : JsonConverter {
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {
			throw new NotImplementedException();
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) {
			var innerValue = serializer.Deserialize(reader, objectType.GetGenericArguments()[0]);
			objectType.GetProperty("Value", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance).SetValue(existingValue, innerValue);
			return existingValue;
		}

		public override bool CanConvert(Type objectType) {
			return objectType.IsGenericType && objectType.GetGenericTypeDefinition() == typeof(NotNull<>);
		}
	}
}