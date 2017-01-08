using System;

namespace GraphQL2Net.Support {
	public struct NotNull<T> where T : class {
		public T Value { get; private set; }

		public NotNull(T input) {
			if (input == null) {
				throw new NotSupportedException();
			}
			Value = input;
		}

		public static implicit operator T(NotNull<T> value) {
			return value.Value;
		}
	}
}
