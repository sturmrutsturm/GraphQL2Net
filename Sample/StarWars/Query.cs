// Generated Query Text
using GraphQL2Net.Support;
using ObsoleteAttribute = System.ObsoleteAttribute;
using NotImplementedException = System.NotImplementedException;
using IEnumerator = System.Collections.IEnumerator;
using IEnumerable = System.Collections.IEnumerable;
using System.Collections.Generic;

namespace Sample.StarWars.Q {
	public static class QL {
		public static GraphQL2Net.Support.Command<Sample.StarWars.R.Query> Compile(Sample.StarWars.Q.Query query, string queryName = null) {
			return new GraphQL2Net.Support.Command<Sample.StarWars.R.Query>(query, "query", new Sample.StarWars.R.Helper(), queryName);
		}
	}
	public interface Query_IChild : INode {
	}
	public class QueryFragment : Query_IChild, IEnumerable<Query_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.StarWars.R.Query); } }
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
	public interface Character_IChild : INode {
	}
	public class CharacterFragment : Character_IChild, IEnumerable<Character_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.StarWars.R.Character); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<Character_IChild> _children = new List<Character_IChild>();
		public void Add(Character_IChild child) { _children.Add(child); }
		public IEnumerator<Character_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public CharacterFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "Character");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface CharacterConnection_IChild : INode {
	}
	public class CharacterConnectionFragment : CharacterConnection_IChild, IEnumerable<CharacterConnection_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.StarWars.R.CharacterConnection); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<CharacterConnection_IChild> _children = new List<CharacterConnection_IChild>();
		public void Add(CharacterConnection_IChild child) { _children.Add(child); }
		public IEnumerator<CharacterConnection_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public CharacterConnectionFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "CharacterConnection");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface CharacterEdge_IChild : INode {
	}
	public class CharacterEdgeFragment : CharacterEdge_IChild, IEnumerable<CharacterEdge_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.StarWars.R.CharacterEdge); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<CharacterEdge_IChild> _children = new List<CharacterEdge_IChild>();
		public void Add(CharacterEdge_IChild child) { _children.Add(child); }
		public IEnumerator<CharacterEdge_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public CharacterEdgeFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "CharacterEdge");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface PageInfo_IChild : INode {
	}
	public class PageInfoFragment : PageInfo_IChild, IEnumerable<PageInfo_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.StarWars.R.PageInfo); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<PageInfo_IChild> _children = new List<PageInfo_IChild>();
		public void Add(PageInfo_IChild child) { _children.Add(child); }
		public IEnumerator<PageInfo_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public PageInfoFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "PageInfo");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface Human_IChild : INode {
	}
	public class HumanFragment : Human_IChild, IEnumerable<Human_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.StarWars.R.Human); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<Human_IChild> _children = new List<Human_IChild>();
		public void Add(Human_IChild child) { _children.Add(child); }
		public IEnumerator<Human_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public HumanFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "Human");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface Node_IChild : INode {
	}
	public class NodeFragment : Node_IChild, IEnumerable<Node_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.StarWars.R.Node); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<Node_IChild> _children = new List<Node_IChild>();
		public void Add(Node_IChild child) { _children.Add(child); }
		public IEnumerator<Node_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public NodeFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "Node");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface Droid_IChild : INode {
	}
	public class DroidFragment : Droid_IChild, IEnumerable<Droid_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.StarWars.R.Droid); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<Droid_IChild> _children = new List<Droid_IChild>();
		public void Add(Droid_IChild child) { _children.Add(child); }
		public IEnumerator<Droid_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public DroidFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "Droid");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public class OnHuman : IEnumerable<Human_IChild>, Node_IChild, Character_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.StarWars.R.Human); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<Human_IChild> _children = new List<Human_IChild>();
		public void Add(Human_IChild child) { _children.Add(child); }
		public IEnumerator<Human_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public OnHuman(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("... on Human");
			writer.Write(_meta);
			writer.WriteLine(" {");
			writer.PushIndent();
			foreach (var v in _children) v.Write(writer);
			writer.PopIndent();
			writer.WriteLine("}");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public class OnDroid : IEnumerable<Droid_IChild>, Node_IChild, Character_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.StarWars.R.Droid); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<Droid_IChild> _children = new List<Droid_IChild>();
		public void Add(Droid_IChild child) { _children.Add(child); }
		public IEnumerator<Droid_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public OnDroid(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("... on Droid");
			writer.Write(_meta);
			writer.WriteLine(" {");
			writer.PushIndent();
			foreach (var v in _children) v.Write(writer);
			writer.PopIndent();
			writer.WriteLine("}");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public class Query : IEnumerable<Query_IChild>, INode {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.StarWars.R.Query); } }
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
	public class droid : IEnumerable<Droid_IChild>, Query_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.StarWars.R.Droid); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly VariableReference<int> _id;
		private readonly List<Droid_IChild> _children = new List<Droid_IChild>();
		public void Add(Droid_IChild child) { _children.Add(child); }
		public IEnumerator<Droid_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <summary>
		/// Find a Droid by ID
		/// </summary>
		/// <param name="id">Id for record</param>
		public droid(VariableReference<int> id = default(VariableReference<int>), Meta _Meta = null) {
			_id = id;
			_id.Type = "Int!";
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("droid", _meta);
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
	public class hero : IEnumerable<Character_IChild>, Query_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.StarWars.R.Character); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly VariableReference<Sample.StarWars.R.Episode> _episode;
		private readonly List<Character_IChild> _children = new List<Character_IChild>();
		public void Add(Character_IChild child) { _children.Add(child); }
		public IEnumerator<Character_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <summary>
		/// The hero of the saga
		/// </summary>
		/// <param name="episode">If provided, return the hero of that episode</param>
		public hero(VariableReference<Sample.StarWars.R.Episode> episode = default(VariableReference<Sample.StarWars.R.Episode>), Meta _Meta = null) {
			_episode = episode;
			_episode.Type = "Episode";
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("hero", _meta);
			bool hasParameters = false;
			if (_episode.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("episode: ");
				writer.WriteEnumValue(_episode);
			}
			if (hasParameters) writer.Write(")");
			writer.Write(_meta);
			writer.WriteLine(" {");
			writer.PushIndent();
			writer.WriteLine("__typename");
			foreach (var v in _children) v.Write(writer);
			writer.PopIndent();
			writer.WriteLine("}");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			if (_episode.Key != null) variables[_episode.Key] = _episode;
			foreach (var child in _children) {
				child.GetVariables(variables);
			}
		}
	}
	public class human : IEnumerable<Human_IChild>, Query_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.StarWars.R.Human); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly VariableReference<int> _id;
		private readonly List<Human_IChild> _children = new List<Human_IChild>();
		public void Add(Human_IChild child) { _children.Add(child); }
		public IEnumerator<Human_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <summary>
		/// Find a Human by ID
		/// </summary>
		/// <param name="id">Id for record</param>
		public human(VariableReference<int> id = default(VariableReference<int>), Meta _Meta = null) {
			_id = id;
			_id.Type = "Int!";
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("human", _meta);
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
	public class node : IEnumerable<Node_IChild>, Query_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.StarWars.R.Node); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly VariableReference<string> _id;
		private readonly List<Node_IChild> _children = new List<Node_IChild>();
		public void Add(Node_IChild child) { _children.Add(child); }
		public IEnumerator<Node_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public node(VariableReference<string> id = default(VariableReference<string>), Meta _Meta = null) {
			_id = id;
			_id.Type = "ID!";
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("node", _meta);
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
			writer.WriteLine("__typename");
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
	public class appearsIn : Character_IChild, Human_IChild, Droid_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.StarWars.R.Episode).MakeArrayType(); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		/// <summary>
		/// Episodes this droid appears in
		/// </summary>
		public appearsIn(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("appearsIn", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class friends : IEnumerable<CharacterConnection_IChild>, Character_IChild, Human_IChild, Droid_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.StarWars.R.CharacterConnection); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly VariableReference<int> _first;
		private readonly VariableReference<string> _after;
		private readonly VariableReference<int> _last;
		private readonly VariableReference<string> _before;
		private readonly List<CharacterConnection_IChild> _children = new List<CharacterConnection_IChild>();
		public void Add(CharacterConnection_IChild child) { _children.Add(child); }
		public IEnumerator<CharacterConnection_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <summary>
		/// Friends of this droid
		/// </summary>
		public friends(VariableReference<int> first = default(VariableReference<int>), VariableReference<string> after = default(VariableReference<string>), VariableReference<int> last = default(VariableReference<int>), VariableReference<string> before = default(VariableReference<string>), Meta _Meta = null) {
			_first = first;
			_first.Type = "Int";
			_after = after;
			_after.Type = "String";
			_last = last;
			_last.Type = "Int";
			_before = before;
			_before.Type = "String";
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("friends", _meta);
			bool hasParameters = false;
			if (_first.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("first: ");
				writer.WriteValue(_first);
			}
			if (_after.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("after: ");
				writer.WriteValue(_after);
			}
			if (_last.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("last: ");
				writer.WriteValue(_last);
			}
			if (_before.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("before: ");
				writer.WriteValue(_before);
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
			if (_first.Key != null) variables[_first.Key] = _first;
			if (_after.Key != null) variables[_after.Key] = _after;
			if (_last.Key != null) variables[_last.Key] = _last;
			if (_before.Key != null) variables[_before.Key] = _before;
			foreach (var child in _children) {
				child.GetVariables(variables);
			}
		}
	}
	public class id : Character_IChild, Human_IChild, Node_IChild, Droid_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
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
	public class name : Character_IChild, Human_IChild, Droid_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		/// <summary>
		/// The name of this droid
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
	public class edges : IEnumerable<CharacterEdge_IChild>, CharacterConnection_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.StarWars.R.CharacterEdge).MakeArrayType(); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<CharacterEdge_IChild> _children = new List<CharacterEdge_IChild>();
		public void Add(CharacterEdge_IChild child) { _children.Add(child); }
		public IEnumerator<CharacterEdge_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public edges(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("edges", _meta);
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
	public class pageInfo : IEnumerable<PageInfo_IChild>, CharacterConnection_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.StarWars.R.PageInfo); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<PageInfo_IChild> _children = new List<PageInfo_IChild>();
		public void Add(PageInfo_IChild child) { _children.Add(child); }
		public IEnumerator<PageInfo_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public pageInfo(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("pageInfo", _meta);
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
	public class cursor : CharacterEdge_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public cursor(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("cursor", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class CharacterEdge_node : IEnumerable<Character_IChild>, CharacterEdge_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.StarWars.R.Character); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<Character_IChild> _children = new List<Character_IChild>();
		public void Add(Character_IChild child) { _children.Add(child); }
		public IEnumerator<Character_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public CharacterEdge_node(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("node", _meta);
			writer.Write(_meta);
			writer.WriteLine(" {");
			writer.PushIndent();
			writer.WriteLine("__typename");
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
	public class hasNextPage : PageInfo_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(bool); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public hasNextPage(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("hasNextPage", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class hasPreviousPage : PageInfo_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(bool); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public hasPreviousPage(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("hasPreviousPage", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class homePlanet : Human_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		/// <summary>
		/// Where this person is from
		/// </summary>
		public homePlanet(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("homePlanet", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class primaryFunction : Droid_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		/// <summary>
		/// What this droid is for
		/// </summary>
		public primaryFunction(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("primaryFunction", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
}
