using System.Collections.Generic;
using GraphQL2Net.Support;
using Sample.Student.Q;
using GraphQL2Net.Support.Json;

namespace Sample.Student {
	public static class StudentTest {
		class Variables : IVariableContainer {
			private readonly Dictionary<string, Variable> _variables = new Dictionary<string, Variable>();
			Dictionary<string, Variable> IVariableContainer.Variables => _variables;

			public readonly Variable<StudentInputType> Type;

			public Variables() {
				Type = new InputVariable<StudentInputType>("type", _variables);
			}
		}

		public static void Run() {
			var q0 = QL.Compile(new Query {
				new students() {
					new name()
				}
			});

			Variables fv = new Variables();
			fv.Type.Value = new StudentInputType { class_id = "cid", id = "id", name = "name" };

			var q1 = QL.Compile(new Mutation {
				new createStudent(student: fv.Type) {
					new Student_id()
				}
			});
			var output = q0.Run("http://localhost:4000/graphql");
			var output1 = q1.Run("http://localhost:4000/graphql", fv);
			var output2 = q0.Run("http://localhost:4000/graphql");
		}
	}
}
