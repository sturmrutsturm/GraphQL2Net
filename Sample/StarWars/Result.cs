// Generated Result Text
using GraphQL2Net.Support;
using ObsoleteAttribute = System.ObsoleteAttribute;
using NotImplementedException = System.NotImplementedException;
using IEnumerator = System.Collections.IEnumerator;
using IEnumerable = System.Collections.IEnumerable;
using System.Collections.Generic;

namespace Sample.StarWars.R {
	public class Helper : IHelper {
		public System.Type GetTypeObject(string typename) {
			switch (typename) {
				case "Query": return typeof(Query);
				case "CharacterConnection": return typeof(CharacterConnection);
				case "CharacterEdge": return typeof(CharacterEdge);
				case "PageInfo": return typeof(PageInfo);
				case "Human": return typeof(Human);
				case "Droid": return typeof(Droid);
				default: return null;
			}
		}
	}
	public class Query : AliasContainer {
		/// <summary>
		/// Find a Droid by ID
		/// </summary>
		public Droid droid { get; set; }
		/// <summary>
		/// The hero of the saga
		/// </summary>
		public Character hero { get; set; }
		/// <summary>
		/// Find a Human by ID
		/// </summary>
		public Human human { get; set; }
		public Node node { get; set; }
	}
	public interface Character {
		/// <summary>
		/// Episodes this person appears in
		/// </summary>
		List<Episode?> appearsIn{ get; }
		/// <summary>
		/// Friends of this person
		/// </summary>
		CharacterConnection friends{ get; }
		/// <summary>
		/// The unique ID of this person
		/// </summary>
		NotNull<string> id{ get; }
		/// <summary>
		/// The name of this person
		/// </summary>
		NotNull<string> name{ get; }
	}
	public class CharacterConnection : AliasContainer {
		public List<CharacterEdge> edges { get; set; }
		public PageInfo pageInfo { get; set; }
	}
	public class CharacterEdge : AliasContainer {
		public NotNull<string> cursor { get; set; }
		public Character node { get; set; }
	}
	public class PageInfo : AliasContainer {
		public bool hasNextPage { get; set; }
		public bool hasPreviousPage { get; set; }
	}
	public enum Episode {
		/// <summary>
		/// Part 4
		/// </summary>
		NEWHOPE,
		/// <summary>
		/// Part 5
		/// </summary>
		EMPIRE,
		/// <summary>
		/// Part 6
		/// </summary>
		JEDI
	}
	public class Human : AliasContainer, Character, Node {
		/// <summary>
		/// Episodes this person appears in
		/// </summary>
		public List<Episode?> appearsIn { get; set; }
		/// <summary>
		/// Friends of this person
		/// </summary>
		public CharacterConnection friends { get; set; }
		/// <summary>
		/// Where this person is from
		/// </summary>
		public string homePlanet { get; set; }
		public NotNull<string> id { get; set; }
		/// <summary>
		/// The name of this person
		/// </summary>
		public NotNull<string> name { get; set; }
	}
	public interface Node {
		NotNull<string> id{ get; }
	}
	public class Droid : AliasContainer, Character, Node {
		/// <summary>
		/// Episodes this droid appears in
		/// </summary>
		public List<Episode?> appearsIn { get; set; }
		/// <summary>
		/// Friends of this droid
		/// </summary>
		public CharacterConnection friends { get; set; }
		public NotNull<string> id { get; set; }
		/// <summary>
		/// The name of this droid
		/// </summary>
		public NotNull<string> name { get; set; }
		/// <summary>
		/// What this droid is for
		/// </summary>
		public string primaryFunction { get; set; }
	}
}
