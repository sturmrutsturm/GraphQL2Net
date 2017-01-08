// Generated Query Text
using GraphQL2Net.Support;
using ObsoleteAttribute = System.ObsoleteAttribute;
using NotImplementedException = System.NotImplementedException;
using IEnumerator = System.Collections.IEnumerator;
using IEnumerable = System.Collections.IEnumerable;
using System.Collections.Generic;

namespace Sample.Student.Q {
	public static class QL {
		public static GraphQL2Net.Support.Command<Sample.Student.R.Query> Compile(Sample.Student.Q.Query query, string queryName = null) {
			return new GraphQL2Net.Support.Command<Sample.Student.R.Query>(query, "query", new Sample.Student.R.Helper(), queryName);
		}
		public static GraphQL2Net.Support.Command<Sample.Student.R.Mutation> Compile(Sample.Student.Q.Mutation query, string queryName = null) {
			return new GraphQL2Net.Support.Command<Sample.Student.R.Mutation>(query, "mutation", new Sample.Student.R.Helper(), queryName ?? "mutate");
		}
	}
	public struct StudentInputType : IInputStruct {
		public VariableReference<string> id { get; set; }
		public VariableReference<string> name { get; set; }
		public VariableReference<string> class_id { get; set; }
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (id.Key != null) variables[id.Key] = id;
			if (name.Key != null) variables[name.Key] = name;
			if (class_id.Key != null) variables[class_id.Key] = class_id;
		}
		public void Write(GraphQLWriter writer, bool json) {
			writer.Write("{ ");
			if (json) writer.Write("\"id\": ");
			else writer.Write("id: ");
			writer.WriteValue(id);
			if (json) writer.Write(", ");
			if (json) writer.Write("\"name\": ");
			else writer.Write("name: ");
			writer.WriteValue(name);
			if (json) writer.Write(", ");
			if (json) writer.Write("\"class_id\": ");
			else writer.Write("class_id: ");
			writer.WriteValue(class_id);
			writer.Write(" }");
		}
	}
	public interface Query_IChild : INode {
	}
	public class QueryFragment : Query_IChild, IEnumerable<Query_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.Student.R.Query); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<Query_IChild> _children = new List<Query_IChild>();
		public void Add(Query_IChild child) { _children.Add(child); }
		public IEnumerator<Query_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public QueryFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "Query");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface Class_IChild : INode {
	}
	public class ClassFragment : Class_IChild, IEnumerable<Class_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.Student.R.Class); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<Class_IChild> _children = new List<Class_IChild>();
		public void Add(Class_IChild child) { _children.Add(child); }
		public IEnumerator<Class_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public ClassFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "Class");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface Student_IChild : INode {
	}
	public class StudentFragment : Student_IChild, IEnumerable<Student_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.Student.R.Student); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<Student_IChild> _children = new List<Student_IChild>();
		public void Add(Student_IChild child) { _children.Add(child); }
		public IEnumerator<Student_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public StudentFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "Student");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface Mutation_IChild : INode {
	}
	public class MutationFragment : Mutation_IChild, IEnumerable<Mutation_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.Student.R.Mutation); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<Mutation_IChild> _children = new List<Mutation_IChild>();
		public void Add(Mutation_IChild child) { _children.Add(child); }
		public IEnumerator<Mutation_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public MutationFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "Mutation");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public class Query : IEnumerable<Query_IChild>, INode {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.Student.R.Query); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<Query_IChild> _children = new List<Query_IChild>();
		public void Add(Query_IChild child) { _children.Add(child); }
		public IEnumerator<Query_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public Query(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write(_meta);
			writer.WriteLine(" {");
			writer.PushIndent();
			foreach (var v in _children) v.Write(writer);
			writer.PopIndent();
			writer.WriteLine("}");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) {
				child.GetVariables(variables);
			}
		}
	}
	public class Mutation : IEnumerable<Mutation_IChild>, INode {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.Student.R.Mutation); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<Mutation_IChild> _children = new List<Mutation_IChild>();
		public void Add(Mutation_IChild child) { _children.Add(child); }
		public IEnumerator<Mutation_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public Mutation(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write(_meta);
			writer.WriteLine(" {");
			writer.PushIndent();
			foreach (var v in _children) v.Write(writer);
			writer.PopIndent();
			writer.WriteLine("}");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) {
				child.GetVariables(variables);
			}
		}
	}
	public class @class : IEnumerable<Class_IChild>, Query_IChild, Student_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.Student.R.Class); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<Class_IChild> _children = new List<Class_IChild>();
		public void Add(Class_IChild child) { _children.Add(child); }
		public IEnumerator<Class_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <summary>
		/// The class of the student
		/// </summary>
		public @class(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("class", _meta);
			writer.Write(_meta);
			writer.WriteLine(" {");
			writer.PushIndent();
			foreach (var v in _children) v.Write(writer);
			writer.PopIndent();
			writer.WriteLine("}");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) {
				child.GetVariables(variables);
			}
		}
	}
	public class student : IEnumerable<Student_IChild>, Query_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.Student.R.Student); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly VariableReference<string> _id;
		private readonly List<Student_IChild> _children = new List<Student_IChild>();
		public void Add(Student_IChild child) { _children.Add(child); }
		public IEnumerator<Student_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <summary>
		/// Get a student
		/// </summary>
		/// <param name="id">id of the student</param>
		public student(VariableReference<string> id = default(VariableReference<string>), Meta _Meta = null) {
			_id = id;
			_id.Type = "String";
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("student", _meta);
			bool hasParameters = false;
			if (_id.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("id: ");
				writer.WriteValue(_id);
			}
			if (hasParameters) writer.Write(")");
			writer.Write(_meta);
			writer.WriteLine(" {");
			writer.PushIndent();
			foreach (var v in _children) v.Write(writer);
			writer.PopIndent();
			writer.WriteLine("}");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			if (_id.Key != null) variables[_id.Key] = _id;
			foreach (var child in _children) {
				child.GetVariables(variables);
			}
		}
	}
	public class students : IEnumerable<Student_IChild>, Query_IChild, Class_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.Student.R.Student).MakeArrayType(); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<Student_IChild> _children = new List<Student_IChild>();
		public void Add(Student_IChild child) { _children.Add(child); }
		public IEnumerator<Student_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <summary>
		/// The students registered in the class, or an empty list if none
		/// </summary>
		public students(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("students", _meta);
			writer.Write(_meta);
			writer.WriteLine(" {");
			writer.PushIndent();
			foreach (var v in _children) v.Write(writer);
			writer.PopIndent();
			writer.WriteLine("}");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) {
				child.GetVariables(variables);
			}
		}
	}
	public class id : Class_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		/// <summary>
		/// The id of the class
		/// </summary>
		public id(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("id", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class Student_id : Student_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		/// <summary>
		/// The id of the student
		/// </summary>
		public Student_id(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("id", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class name : Student_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		/// <summary>
		/// The name of the student
		/// </summary>
		public name(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("name", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class class_id : Student_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		/// <summary>
		/// The class_id of the student
		/// </summary>
		public class_id(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("class_id", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class createStudent : IEnumerable<Student_IChild>, Mutation_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.Student.R.Student); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly VariableReference<StudentInputType> _student;
		private readonly List<Student_IChild> _children = new List<Student_IChild>();
		public void Add(Student_IChild child) { _children.Add(child); }
		public IEnumerator<Student_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <summary>
		/// Create a student
		/// </summary>
		/// <param name="student">Student to create</param>
		public createStudent(VariableReference<StudentInputType> student = default(VariableReference<StudentInputType>), Meta _Meta = null) {
			_student = student;
			_student.Type = "StudentInputType!";
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("createStudent", _meta);
			bool hasParameters = false;
			if (_student.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("student: ");
				writer.WriteValue(_student);
			}
			if (hasParameters) writer.Write(")");
			writer.Write(_meta);
			writer.WriteLine(" {");
			writer.PushIndent();
			foreach (var v in _children) v.Write(writer);
			writer.PopIndent();
			writer.WriteLine("}");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			if (_student.Key != null) variables[_student.Key] = _student;
			foreach (var child in _children) {
				child.GetVariables(variables);
			}
		}
	}
	public class removeStudent : IEnumerable<Student_IChild>, Mutation_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.Student.R.Student); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly VariableReference<string> _id;
		private readonly List<Student_IChild> _children = new List<Student_IChild>();
		public void Add(Student_IChild child) { _children.Add(child); }
		public IEnumerator<Student_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <summary>
		/// Remove a student
		/// </summary>
		/// <param name="id">ID of the student to remove</param>
		public removeStudent(VariableReference<string> id = default(VariableReference<string>), Meta _Meta = null) {
			_id = id;
			_id.Type = "String!";
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("removeStudent", _meta);
			bool hasParameters = false;
			if (_id.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("id: ");
				writer.WriteValue(_id);
			}
			if (hasParameters) writer.Write(")");
			writer.Write(_meta);
			writer.WriteLine(" {");
			writer.PushIndent();
			foreach (var v in _children) v.Write(writer);
			writer.PopIndent();
			writer.WriteLine("}");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			if (_id.Key != null) variables[_id.Key] = _id;
			foreach (var child in _children) {
				child.GetVariables(variables);
			}
		}
	}
}
