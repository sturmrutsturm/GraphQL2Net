using System.Collections.Generic;
using GraphQL2Net.Support;
using GraphQL2Net.Support.Json;
using Sample.StarWars.Q;
using Sample.StarWars.R;

namespace Sample.StarWars {
	public class StarWarsTest {
		class Variables : IVariableContainer {
			private readonly Dictionary<string, Variable> _variables = new Dictionary<string, Variable>();
			Dictionary<string, Variable> IVariableContainer.Variables => _variables;

			public readonly Variable<string> PersonId;
			public readonly Variable<bool?> IncludeJedi;

			public Variables() {
				PersonId = new StringVariable("personId", _variables);
				IncludeJedi = new BoolVariable("includeJedi", _variables);
			}
		}

		class Q0Variables : IVariableContainer {
			private readonly Dictionary<string, Variable> _variables = new Dictionary<string, Variable>();
			Dictionary<string, Variable> IVariableContainer.Variables => _variables;

			public readonly Variable<bool?> DroidExtra;

			public Q0Variables() {
				DroidExtra = new BoolVariable("droidExtra", _variables);
			}
		}
		public static void Run() {
			Q0Variables v = new Q0Variables();
			v.DroidExtra.Value = true;

			var heroInfo = new CharacterFragment(_Meta: new Meta { Name = "hero"}) {
				new name(),
				new OnDroid(_Meta: new Meta {Include = new If(v.DroidExtra)}) {
					new primaryFunction()
				},
				new CharacterFragment(new Meta {Name = "Test", Skip = new If(v.DroidExtra)}) {
					new id()
				}
			};
			var q0 = QL.Compile(new Q.Query {
				new hero(episode: Episode.EMPIRE) {
					heroInfo
				},
				new hero(episode: Episode.JEDI, _Meta: new Meta { Name = "jedi"}) {
					heroInfo
				}
			}, "query");
			var output = q0.Run("http://graphql-ruby-demo.herokuapp.com/queries", v);
			var person = output.GetAlias<R.Character>("jedi");
		}
	}
}