using System.Collections.Generic;

namespace GraphQL2Net.Support {
	public class AliasContainer {
		private Dictionary<string, object> _alias;

		public T GetAlias<T>(string key) {
			object value;
			if (_alias != null && _alias.TryGetValue(key, out value)) {
				return (T)value;
			}

			return default(T);
		}

		public void SetAlias(string key, object value) {
			if (_alias == null) {
				_alias = new Dictionary<string, object>();
			}
			_alias.Add(key, value);
		}
	}
}
