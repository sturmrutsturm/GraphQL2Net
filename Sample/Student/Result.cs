// Generated Result Text
using GraphQL2Net.Support;
using ObsoleteAttribute = System.ObsoleteAttribute;
using NotImplementedException = System.NotImplementedException;
using IEnumerator = System.Collections.IEnumerator;
using IEnumerable = System.Collections.IEnumerable;
using System.Collections.Generic;

namespace Sample.Student.R {
	public class Helper : IHelper {
		public System.Type GetTypeObject(string typename) {
			switch (typename) {
				case "Query": return typeof(Query);
				case "Class": return typeof(Class);
				case "Student": return typeof(Student);
				case "Mutation": return typeof(Mutation);
				default: return null;
			}
		}
	}
	public class Query : AliasContainer {
		/// <summary>
		/// Get a class
		/// </summary>
		public Class @class { get; set; }
		/// <summary>
		/// Get a student
		/// </summary>
		public Student student { get; set; }
		/// <summary>
		/// Get all students
		/// </summary>
		public List<Student> students { get; set; }
	}
	public class Class : AliasContainer {
		/// <summary>
		/// The id of the class
		/// </summary>
		public NotNull<string> id { get; set; }
		/// <summary>
		/// The students registered in the class, or an empty list if none
		/// </summary>
		public List<Student> students { get; set; }
	}
	public class Student : AliasContainer {
		/// <summary>
		/// The id of the student
		/// </summary>
		public string id { get; set; }
		/// <summary>
		/// The name of the student
		/// </summary>
		public string name { get; set; }
		/// <summary>
		/// The class of the student
		/// </summary>
		public Class @class { get; set; }
		/// <summary>
		/// The class_id of the student
		/// </summary>
		public string class_id { get; set; }
	}
	public class Mutation : AliasContainer {
		/// <summary>
		/// Create a student
		/// </summary>
		public Student createStudent { get; set; }
		/// <summary>
		/// Remove a student
		/// </summary>
		public Student removeStudent { get; set; }
	}
}
