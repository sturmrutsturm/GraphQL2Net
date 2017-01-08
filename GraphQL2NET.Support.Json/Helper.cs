
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace GraphQL2Net.Support.Json {
	public static class Helper {
		class ContractResolver : DefaultContractResolver {
			private readonly Dictionary<Type, JsonObjectContract> _contracts = new Dictionary<Type, JsonObjectContract>();
			class DictionaryValueProvider : IValueProvider {
				private readonly string _key;
				public DictionaryValueProvider(string key) {
					_key = key;
				}

				public void SetValue(object target, object value) {
					((AliasContainer)target).SetAlias(_key, value);
				}

				public object GetValue(object target) {
					return ((AliasContainer)target).GetAlias<object>(_key);
				}
			}

			protected override JsonObjectContract CreateObjectContract(Type objectType) {
				JsonObjectContract contract;
				if (_contracts.TryGetValue(objectType, out contract)) {
					return contract;
				}

				return base.CreateObjectContract(objectType);
			}

			public void UpdateContracts(INode parent, INode node) {
				if (node.Meta?.Name != null) {
					JsonObjectContract contract;
					if (_contracts.TryGetValue(parent.ResultType, out contract) == false) {
						contract = base.CreateObjectContract(parent.ResultType);
						_contracts[parent.ResultType] = contract;
					}
					if (contract.Properties.GetProperty(node.Meta.Name, StringComparison.Ordinal) == null) {
						contract.Properties.AddProperty(new JsonProperty {
							DefaultValue = null,
							PropertyType = node.ResultType,
							ValueProvider = new DictionaryValueProvider(node.Meta.Name),
							PropertyName = node.Meta.Name,
							Readable = true,
							Writable = true
						});
					}
				}

				foreach (var child in node.Children) {
					UpdateContracts(node, child);
				}
			}
		}

		public class InterfaceConverter : JsonConverter {
			private readonly IHelper _helper;
			public InterfaceConverter(IHelper helper) {
				_helper = helper;
			}
			public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {
				throw new NotImplementedException();
			}

			public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) {
				var jsonObject = JObject.Load(reader);
				var typename = jsonObject["__typename"].Value<string>();
				jsonObject.Remove("__typename");
				return jsonObject.ToObject(_helper.GetTypeObject(typename), serializer);
			}

			public override bool CanConvert(Type objectType) {
				return objectType.IsInterface;
			}
		}

		private class Data<TRoot> {
			public TRoot data { get; set; }
		}

		public static TResult Run<TResult>(this Command<TResult> query, string url, IVariableContainer values = null) {
			var json = RunCommand(query, url, values);
			var settings = new JsonSerializerSettings {MissingMemberHandling = MissingMemberHandling.Error};

			settings.Converters.Add(new NotNullConverter());
			settings.Converters.Add(new InterfaceConverter(query.Helper));
			var resolver = new ContractResolver();
			settings.ContractResolver = resolver;

			resolver.UpdateContracts(null, query.Node);

			var output = JsonConvert.DeserializeObject<Data<TResult>>(json, settings);

			return output.data;
		}

		public static string RunCommand(this Command query, string url, IVariableContainer values = null) {
			var client = new WebClient();
			client.Headers["Accept"] = "application/json";
			client.Headers["Content-Type"] = "application/json";
			StringWriter sw = new StringWriter();
			JsonWriter writer = new JsonTextWriter(sw);
			writer.WriteStartObject();
			writer.WritePropertyName("query");
			writer.WriteValue(query.QueryText);

			if (values != null) {
				writer.WritePropertyName("variables");
				writer.WriteValue(values.GetJSON());
			}

			if (query.QueryName != null) {
				writer.WritePropertyName("operationName");
				writer.WriteValue(query.QueryName);
			}

			writer.WriteEndObject();
			var text = sw.ToString();
			return client.UploadString(url, "POST", text);
		}
	}
}
