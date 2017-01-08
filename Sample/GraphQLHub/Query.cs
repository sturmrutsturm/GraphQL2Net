// Generated Query Text
using GraphQL2Net.Support;
using ObsoleteAttribute = System.ObsoleteAttribute;
using NotImplementedException = System.NotImplementedException;
using IEnumerator = System.Collections.IEnumerator;
using IEnumerable = System.Collections.IEnumerable;
using System.Collections.Generic;

namespace Sample.GraphQLHub.Q {
	public static class QL {
		public static GraphQL2Net.Support.Command<Sample.GraphQLHub.R.GraphQLHubAPI> Compile(Sample.GraphQLHub.Q.GraphQLHubAPI query, string queryName = null) {
			return new GraphQL2Net.Support.Command<Sample.GraphQLHub.R.GraphQLHubAPI>(query, "query", new Sample.GraphQLHub.R.Helper(), queryName);
		}
		public static GraphQL2Net.Support.Command<Sample.GraphQLHub.R.GraphQLHubMutationAPI> Compile(Sample.GraphQLHub.Q.GraphQLHubMutationAPI query, string queryName = null) {
			return new GraphQL2Net.Support.Command<Sample.GraphQLHub.R.GraphQLHubMutationAPI>(query, "mutation", new Sample.GraphQLHub.R.Helper(), queryName ?? "mutate");
		}
	}
	public struct SetValueForKeyInput : IInputStruct {
		public VariableReference<string> id { get; set; }
		public VariableReference<string> value { get; set; }
		public VariableReference<string> clientMutationId { get; set; }
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (id.Key != null) variables[id.Key] = id;
			if (value.Key != null) variables[value.Key] = value;
			if (clientMutationId.Key != null) variables[clientMutationId.Key] = clientMutationId;
		}
		public void Write(GraphQLWriter writer, bool json) {
			writer.Write("{ ");
			if (json) writer.Write("\"id\": ");
			else writer.Write("id: ");
			writer.WriteValue(id);
			if (json) writer.Write(", ");
			if (json) writer.Write("\"value\": ");
			else writer.Write("value: ");
			writer.WriteValue(value);
			if (json) writer.Write(", ");
			if (json) writer.Write("\"clientMutationId\": ");
			else writer.Write("clientMutationId: ");
			writer.WriteValue(clientMutationId);
			writer.Write(" }");
		}
	}
	public interface GraphQLHubAPI_IChild : INode {
	}
	public class GraphQLHubAPIFragment : GraphQLHubAPI_IChild, IEnumerable<GraphQLHubAPI_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GraphQLHubAPI); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GraphQLHubAPI_IChild> _children = new List<GraphQLHubAPI_IChild>();
		public void Add(GraphQLHubAPI_IChild child) { _children.Add(child); }
		public IEnumerator<GraphQLHubAPI_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public GraphQLHubAPIFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "GraphQLHubAPI");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface HackerNewsAPI_IChild : INode {
	}
	public class HackerNewsAPIFragment : HackerNewsAPI_IChild, IEnumerable<HackerNewsAPI_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.HackerNewsAPI); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<HackerNewsAPI_IChild> _children = new List<HackerNewsAPI_IChild>();
		public void Add(HackerNewsAPI_IChild child) { _children.Add(child); }
		public IEnumerator<HackerNewsAPI_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public HackerNewsAPIFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "HackerNewsAPI");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface HackerNewsItem_IChild : INode {
	}
	public class HackerNewsItemFragment : HackerNewsItem_IChild, IEnumerable<HackerNewsItem_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.HackerNewsItem); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<HackerNewsItem_IChild> _children = new List<HackerNewsItem_IChild>();
		public void Add(HackerNewsItem_IChild child) { _children.Add(child); }
		public IEnumerator<HackerNewsItem_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public HackerNewsItemFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "HackerNewsItem");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface HackerNewsUser_IChild : INode {
	}
	public class HackerNewsUserFragment : HackerNewsUser_IChild, IEnumerable<HackerNewsUser_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.HackerNewsUser); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<HackerNewsUser_IChild> _children = new List<HackerNewsUser_IChild>();
		public void Add(HackerNewsUser_IChild child) { _children.Add(child); }
		public IEnumerator<HackerNewsUser_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public HackerNewsUserFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "HackerNewsUser");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface HackerNewsAPIV2_IChild : INode {
	}
	public class HackerNewsAPIV2Fragment : HackerNewsAPIV2_IChild, IEnumerable<HackerNewsAPIV2_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.HackerNewsAPIV2); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<HackerNewsAPIV2_IChild> _children = new List<HackerNewsAPIV2_IChild>();
		public void Add(HackerNewsAPIV2_IChild child) { _children.Add(child); }
		public IEnumerator<HackerNewsAPIV2_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public HackerNewsAPIV2Fragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "HackerNewsAPIV2");
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
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.Node); } }
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
	public interface HackerNewsV2Story_IChild : INode {
	}
	public class HackerNewsV2StoryFragment : HackerNewsV2Story_IChild, IEnumerable<HackerNewsV2Story_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.HackerNewsV2Story); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<HackerNewsV2Story_IChild> _children = new List<HackerNewsV2Story_IChild>();
		public void Add(HackerNewsV2Story_IChild child) { _children.Add(child); }
		public IEnumerator<HackerNewsV2Story_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public HackerNewsV2StoryFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "HackerNewsV2Story");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface HackerNewsV2User_IChild : INode {
	}
	public class HackerNewsV2UserFragment : HackerNewsV2User_IChild, IEnumerable<HackerNewsV2User_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.HackerNewsV2User); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<HackerNewsV2User_IChild> _children = new List<HackerNewsV2User_IChild>();
		public void Add(HackerNewsV2User_IChild child) { _children.Add(child); }
		public IEnumerator<HackerNewsV2User_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public HackerNewsV2UserFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "HackerNewsV2User");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface NodeConnection_IChild : INode {
	}
	public class NodeConnectionFragment : NodeConnection_IChild, IEnumerable<NodeConnection_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.NodeConnection); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<NodeConnection_IChild> _children = new List<NodeConnection_IChild>();
		public void Add(NodeConnection_IChild child) { _children.Add(child); }
		public IEnumerator<NodeConnection_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public NodeConnectionFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "NodeConnection");
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
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.PageInfo); } }
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
	public interface NodeEdge_IChild : INode {
	}
	public class NodeEdgeFragment : NodeEdge_IChild, IEnumerable<NodeEdge_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.NodeEdge); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<NodeEdge_IChild> _children = new List<NodeEdge_IChild>();
		public void Add(NodeEdge_IChild child) { _children.Add(child); }
		public IEnumerator<NodeEdge_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public NodeEdgeFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "NodeEdge");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface HackerNewsV2CommentConnection_IChild : INode {
	}
	public class HackerNewsV2CommentConnectionFragment : HackerNewsV2CommentConnection_IChild, IEnumerable<HackerNewsV2CommentConnection_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.HackerNewsV2CommentConnection); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<HackerNewsV2CommentConnection_IChild> _children = new List<HackerNewsV2CommentConnection_IChild>();
		public void Add(HackerNewsV2CommentConnection_IChild child) { _children.Add(child); }
		public IEnumerator<HackerNewsV2CommentConnection_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public HackerNewsV2CommentConnectionFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "HackerNewsV2CommentConnection");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface HackerNewsV2CommentEdge_IChild : INode {
	}
	public class HackerNewsV2CommentEdgeFragment : HackerNewsV2CommentEdge_IChild, IEnumerable<HackerNewsV2CommentEdge_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.HackerNewsV2CommentEdge); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<HackerNewsV2CommentEdge_IChild> _children = new List<HackerNewsV2CommentEdge_IChild>();
		public void Add(HackerNewsV2CommentEdge_IChild child) { _children.Add(child); }
		public IEnumerator<HackerNewsV2CommentEdge_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public HackerNewsV2CommentEdgeFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "HackerNewsV2CommentEdge");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface HackerNewsV2Comment_IChild : INode {
	}
	public class HackerNewsV2CommentFragment : HackerNewsV2Comment_IChild, IEnumerable<HackerNewsV2Comment_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.HackerNewsV2Comment); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<HackerNewsV2Comment_IChild> _children = new List<HackerNewsV2Comment_IChild>();
		public void Add(HackerNewsV2Comment_IChild child) { _children.Add(child); }
		public IEnumerator<HackerNewsV2Comment_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public HackerNewsV2CommentFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "HackerNewsV2Comment");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface HackerNewsV2Job_IChild : INode {
	}
	public class HackerNewsV2JobFragment : HackerNewsV2Job_IChild, IEnumerable<HackerNewsV2Job_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.HackerNewsV2Job); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<HackerNewsV2Job_IChild> _children = new List<HackerNewsV2Job_IChild>();
		public void Add(HackerNewsV2Job_IChild child) { _children.Add(child); }
		public IEnumerator<HackerNewsV2Job_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public HackerNewsV2JobFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "HackerNewsV2Job");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface HackerNewsV2Poll_IChild : INode {
	}
	public class HackerNewsV2PollFragment : HackerNewsV2Poll_IChild, IEnumerable<HackerNewsV2Poll_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.HackerNewsV2Poll); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<HackerNewsV2Poll_IChild> _children = new List<HackerNewsV2Poll_IChild>();
		public void Add(HackerNewsV2Poll_IChild child) { _children.Add(child); }
		public IEnumerator<HackerNewsV2Poll_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public HackerNewsV2PollFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "HackerNewsV2Poll");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface HackerNewsV2PollPart_IChild : INode {
	}
	public class HackerNewsV2PollPartFragment : HackerNewsV2PollPart_IChild, IEnumerable<HackerNewsV2PollPart_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.HackerNewsV2PollPart); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<HackerNewsV2PollPart_IChild> _children = new List<HackerNewsV2PollPart_IChild>();
		public void Add(HackerNewsV2PollPart_IChild child) { _children.Add(child); }
		public IEnumerator<HackerNewsV2PollPart_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public HackerNewsV2PollPartFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "HackerNewsV2PollPart");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface RedditAPI_IChild : INode {
	}
	public class RedditAPIFragment : RedditAPI_IChild, IEnumerable<RedditAPI_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.RedditAPI); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<RedditAPI_IChild> _children = new List<RedditAPI_IChild>();
		public void Add(RedditAPI_IChild child) { _children.Add(child); }
		public IEnumerator<RedditAPI_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public RedditAPIFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "RedditAPI");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface RedditSubreddit_IChild : INode {
	}
	public class RedditSubredditFragment : RedditSubreddit_IChild, IEnumerable<RedditSubreddit_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.RedditSubreddit); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<RedditSubreddit_IChild> _children = new List<RedditSubreddit_IChild>();
		public void Add(RedditSubreddit_IChild child) { _children.Add(child); }
		public IEnumerator<RedditSubreddit_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public RedditSubredditFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "RedditSubreddit");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface RedditLink_IChild : INode {
	}
	public class RedditLinkFragment : RedditLink_IChild, IEnumerable<RedditLink_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.RedditLink); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<RedditLink_IChild> _children = new List<RedditLink_IChild>();
		public void Add(RedditLink_IChild child) { _children.Add(child); }
		public IEnumerator<RedditLink_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public RedditLinkFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "RedditLink");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface RedditUser_IChild : INode {
	}
	public class RedditUserFragment : RedditUser_IChild, IEnumerable<RedditUser_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.RedditUser); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<RedditUser_IChild> _children = new List<RedditUser_IChild>();
		public void Add(RedditUser_IChild child) { _children.Add(child); }
		public IEnumerator<RedditUser_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public RedditUserFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "RedditUser");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface RedditComment_IChild : INode {
	}
	public class RedditCommentFragment : RedditComment_IChild, IEnumerable<RedditComment_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.RedditComment); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<RedditComment_IChild> _children = new List<RedditComment_IChild>();
		public void Add(RedditComment_IChild child) { _children.Add(child); }
		public IEnumerator<RedditComment_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public RedditCommentFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "RedditComment");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface KeyValueAPI_IChild : INode {
	}
	public class KeyValueAPIFragment : KeyValueAPI_IChild, IEnumerable<KeyValueAPI_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.KeyValueAPI); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<KeyValueAPI_IChild> _children = new List<KeyValueAPI_IChild>();
		public void Add(KeyValueAPI_IChild child) { _children.Add(child); }
		public IEnumerator<KeyValueAPI_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public KeyValueAPIFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "KeyValueAPI");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface KeyValueItem_IChild : INode {
	}
	public class KeyValueItemFragment : KeyValueItem_IChild, IEnumerable<KeyValueItem_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.KeyValueItem); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<KeyValueItem_IChild> _children = new List<KeyValueItem_IChild>();
		public void Add(KeyValueItem_IChild child) { _children.Add(child); }
		public IEnumerator<KeyValueItem_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public KeyValueItemFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "KeyValueItem");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface GithubAPI_IChild : INode {
	}
	public class GithubAPIFragment : GithubAPI_IChild, IEnumerable<GithubAPI_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GithubAPI); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GithubAPI_IChild> _children = new List<GithubAPI_IChild>();
		public void Add(GithubAPI_IChild child) { _children.Add(child); }
		public IEnumerator<GithubAPI_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public GithubAPIFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "GithubAPI");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface GithubUser_IChild : INode {
	}
	public class GithubUserFragment : GithubUser_IChild, IEnumerable<GithubUser_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GithubUser); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GithubUser_IChild> _children = new List<GithubUser_IChild>();
		public void Add(GithubUser_IChild child) { _children.Add(child); }
		public IEnumerator<GithubUser_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public GithubUserFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "GithubUser");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface GithubRepo_IChild : INode {
	}
	public class GithubRepoFragment : GithubRepo_IChild, IEnumerable<GithubRepo_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GithubRepo); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GithubRepo_IChild> _children = new List<GithubRepo_IChild>();
		public void Add(GithubRepo_IChild child) { _children.Add(child); }
		public IEnumerator<GithubRepo_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public GithubRepoFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "GithubRepo");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface GithubCommit_IChild : INode {
	}
	public class GithubCommitFragment : GithubCommit_IChild, IEnumerable<GithubCommit_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GithubCommit); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GithubCommit_IChild> _children = new List<GithubCommit_IChild>();
		public void Add(GithubCommit_IChild child) { _children.Add(child); }
		public IEnumerator<GithubCommit_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public GithubCommitFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "GithubCommit");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface GithubCommitAuthor_IChild : INode {
	}
	public class GithubCommitAuthorFragment : GithubCommitAuthor_IChild, IEnumerable<GithubCommitAuthor_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GithubCommitAuthor); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GithubCommitAuthor_IChild> _children = new List<GithubCommitAuthor_IChild>();
		public void Add(GithubCommitAuthor_IChild child) { _children.Add(child); }
		public IEnumerator<GithubCommitAuthor_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public GithubCommitAuthorFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "GithubCommitAuthor");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface GithubStatus_IChild : INode {
	}
	public class GithubStatusFragment : GithubStatus_IChild, IEnumerable<GithubStatus_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GithubStatus); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GithubStatus_IChild> _children = new List<GithubStatus_IChild>();
		public void Add(GithubStatus_IChild child) { _children.Add(child); }
		public IEnumerator<GithubStatus_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public GithubStatusFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "GithubStatus");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface GithubTree_IChild : INode {
	}
	public class GithubTreeFragment : GithubTree_IChild, IEnumerable<GithubTree_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GithubTree); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GithubTree_IChild> _children = new List<GithubTree_IChild>();
		public void Add(GithubTree_IChild child) { _children.Add(child); }
		public IEnumerator<GithubTree_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public GithubTreeFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "GithubTree");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface GithubTreeEntry_IChild : INode {
	}
	public class GithubTreeEntryFragment : GithubTreeEntry_IChild, IEnumerable<GithubTreeEntry_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GithubTreeEntry); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GithubTreeEntry_IChild> _children = new List<GithubTreeEntry_IChild>();
		public void Add(GithubTreeEntry_IChild child) { _children.Add(child); }
		public IEnumerator<GithubTreeEntry_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public GithubTreeEntryFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "GithubTreeEntry");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface GithubIssue_IChild : INode {
	}
	public class GithubIssueFragment : GithubIssue_IChild, IEnumerable<GithubIssue_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GithubIssue); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GithubIssue_IChild> _children = new List<GithubIssue_IChild>();
		public void Add(GithubIssue_IChild child) { _children.Add(child); }
		public IEnumerator<GithubIssue_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public GithubIssueFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "GithubIssue");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface GithubIssueLabelType_IChild : INode {
	}
	public class GithubIssueLabelTypeFragment : GithubIssueLabelType_IChild, IEnumerable<GithubIssueLabelType_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GithubIssueLabelType); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GithubIssueLabelType_IChild> _children = new List<GithubIssueLabelType_IChild>();
		public void Add(GithubIssueLabelType_IChild child) { _children.Add(child); }
		public IEnumerator<GithubIssueLabelType_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public GithubIssueLabelTypeFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "GithubIssueLabelType");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface GithubIssueCommentType_IChild : INode {
	}
	public class GithubIssueCommentTypeFragment : GithubIssueCommentType_IChild, IEnumerable<GithubIssueCommentType_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GithubIssueCommentType); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GithubIssueCommentType_IChild> _children = new List<GithubIssueCommentType_IChild>();
		public void Add(GithubIssueCommentType_IChild child) { _children.Add(child); }
		public IEnumerator<GithubIssueCommentType_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public GithubIssueCommentTypeFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "GithubIssueCommentType");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface GithubBranch_IChild : INode {
	}
	public class GithubBranchFragment : GithubBranch_IChild, IEnumerable<GithubBranch_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GithubBranch); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GithubBranch_IChild> _children = new List<GithubBranch_IChild>();
		public void Add(GithubBranch_IChild child) { _children.Add(child); }
		public IEnumerator<GithubBranch_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public GithubBranchFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "GithubBranch");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface TwitterAPI_IChild : INode {
	}
	public class TwitterAPIFragment : TwitterAPI_IChild, IEnumerable<TwitterAPI_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.TwitterAPI); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<TwitterAPI_IChild> _children = new List<TwitterAPI_IChild>();
		public void Add(TwitterAPI_IChild child) { _children.Add(child); }
		public IEnumerator<TwitterAPI_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public TwitterAPIFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "TwitterAPI");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface TwitterUser_IChild : INode {
	}
	public class TwitterUserFragment : TwitterUser_IChild, IEnumerable<TwitterUser_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.TwitterUser); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<TwitterUser_IChild> _children = new List<TwitterUser_IChild>();
		public void Add(TwitterUser_IChild child) { _children.Add(child); }
		public IEnumerator<TwitterUser_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public TwitterUserFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "TwitterUser");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface Tweet_IChild : INode {
	}
	public class TweetFragment : Tweet_IChild, IEnumerable<Tweet_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.Tweet); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<Tweet_IChild> _children = new List<Tweet_IChild>();
		public void Add(Tweet_IChild child) { _children.Add(child); }
		public IEnumerator<Tweet_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public TweetFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "Tweet");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface Retweet_IChild : INode {
	}
	public class RetweetFragment : Retweet_IChild, IEnumerable<Retweet_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.Retweet); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<Retweet_IChild> _children = new List<Retweet_IChild>();
		public void Add(Retweet_IChild child) { _children.Add(child); }
		public IEnumerator<Retweet_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public RetweetFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "Retweet");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface GiphyAPI_IChild : INode {
	}
	public class GiphyAPIFragment : GiphyAPI_IChild, IEnumerable<GiphyAPI_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GiphyAPI); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GiphyAPI_IChild> _children = new List<GiphyAPI_IChild>();
		public void Add(GiphyAPI_IChild child) { _children.Add(child); }
		public IEnumerator<GiphyAPI_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public GiphyAPIFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "GiphyAPI");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface GiphyGIFData_IChild : INode {
	}
	public class GiphyGIFDataFragment : GiphyGIFData_IChild, IEnumerable<GiphyGIFData_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GiphyGIFData); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GiphyGIFData_IChild> _children = new List<GiphyGIFData_IChild>();
		public void Add(GiphyGIFData_IChild child) { _children.Add(child); }
		public IEnumerator<GiphyGIFData_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public GiphyGIFDataFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "GiphyGIFData");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface GiphyGIFImages_IChild : INode {
	}
	public class GiphyGIFImagesFragment : GiphyGIFImages_IChild, IEnumerable<GiphyGIFImages_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GiphyGIFImages); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GiphyGIFImages_IChild> _children = new List<GiphyGIFImages_IChild>();
		public void Add(GiphyGIFImages_IChild child) { _children.Add(child); }
		public IEnumerator<GiphyGIFImages_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public GiphyGIFImagesFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "GiphyGIFImages");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface GiphyGIFImageDataFixedHeight_IChild : INode {
	}
	public class GiphyGIFImageDataFixedHeightFragment : GiphyGIFImageDataFixedHeight_IChild, IEnumerable<GiphyGIFImageDataFixedHeight_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GiphyGIFImageDataFixedHeight); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GiphyGIFImageDataFixedHeight_IChild> _children = new List<GiphyGIFImageDataFixedHeight_IChild>();
		public void Add(GiphyGIFImageDataFixedHeight_IChild child) { _children.Add(child); }
		public IEnumerator<GiphyGIFImageDataFixedHeight_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public GiphyGIFImageDataFixedHeightFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "GiphyGIFImageDataFixedHeight");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface GiphyGIFImageDataFixedHeightStill_IChild : INode {
	}
	public class GiphyGIFImageDataFixedHeightStillFragment : GiphyGIFImageDataFixedHeightStill_IChild, IEnumerable<GiphyGIFImageDataFixedHeightStill_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GiphyGIFImageDataFixedHeightStill); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GiphyGIFImageDataFixedHeightStill_IChild> _children = new List<GiphyGIFImageDataFixedHeightStill_IChild>();
		public void Add(GiphyGIFImageDataFixedHeightStill_IChild child) { _children.Add(child); }
		public IEnumerator<GiphyGIFImageDataFixedHeightStill_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public GiphyGIFImageDataFixedHeightStillFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "GiphyGIFImageDataFixedHeightStill");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface GiphyGIFImageDataFixedHeightDownsample_IChild : INode {
	}
	public class GiphyGIFImageDataFixedHeightDownsampleFragment : GiphyGIFImageDataFixedHeightDownsample_IChild, IEnumerable<GiphyGIFImageDataFixedHeightDownsample_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GiphyGIFImageDataFixedHeightDownsample); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GiphyGIFImageDataFixedHeightDownsample_IChild> _children = new List<GiphyGIFImageDataFixedHeightDownsample_IChild>();
		public void Add(GiphyGIFImageDataFixedHeightDownsample_IChild child) { _children.Add(child); }
		public IEnumerator<GiphyGIFImageDataFixedHeightDownsample_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public GiphyGIFImageDataFixedHeightDownsampleFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "GiphyGIFImageDataFixedHeightDownsample");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface GiphyGIFImageDataFixedWidth_IChild : INode {
	}
	public class GiphyGIFImageDataFixedWidthFragment : GiphyGIFImageDataFixedWidth_IChild, IEnumerable<GiphyGIFImageDataFixedWidth_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GiphyGIFImageDataFixedWidth); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GiphyGIFImageDataFixedWidth_IChild> _children = new List<GiphyGIFImageDataFixedWidth_IChild>();
		public void Add(GiphyGIFImageDataFixedWidth_IChild child) { _children.Add(child); }
		public IEnumerator<GiphyGIFImageDataFixedWidth_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public GiphyGIFImageDataFixedWidthFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "GiphyGIFImageDataFixedWidth");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface GiphyGIFImageDataFixedWidthStill_IChild : INode {
	}
	public class GiphyGIFImageDataFixedWidthStillFragment : GiphyGIFImageDataFixedWidthStill_IChild, IEnumerable<GiphyGIFImageDataFixedWidthStill_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GiphyGIFImageDataFixedWidthStill); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GiphyGIFImageDataFixedWidthStill_IChild> _children = new List<GiphyGIFImageDataFixedWidthStill_IChild>();
		public void Add(GiphyGIFImageDataFixedWidthStill_IChild child) { _children.Add(child); }
		public IEnumerator<GiphyGIFImageDataFixedWidthStill_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public GiphyGIFImageDataFixedWidthStillFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "GiphyGIFImageDataFixedWidthStill");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface GiphyGIFImageDataFixedWidthDownsample_IChild : INode {
	}
	public class GiphyGIFImageDataFixedWidthDownsampleFragment : GiphyGIFImageDataFixedWidthDownsample_IChild, IEnumerable<GiphyGIFImageDataFixedWidthDownsample_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GiphyGIFImageDataFixedWidthDownsample); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GiphyGIFImageDataFixedWidthDownsample_IChild> _children = new List<GiphyGIFImageDataFixedWidthDownsample_IChild>();
		public void Add(GiphyGIFImageDataFixedWidthDownsample_IChild child) { _children.Add(child); }
		public IEnumerator<GiphyGIFImageDataFixedWidthDownsample_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public GiphyGIFImageDataFixedWidthDownsampleFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "GiphyGIFImageDataFixedWidthDownsample");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface GiphyGIFImageDataFixedHeightSmall_IChild : INode {
	}
	public class GiphyGIFImageDataFixedHeightSmallFragment : GiphyGIFImageDataFixedHeightSmall_IChild, IEnumerable<GiphyGIFImageDataFixedHeightSmall_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GiphyGIFImageDataFixedHeightSmall); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GiphyGIFImageDataFixedHeightSmall_IChild> _children = new List<GiphyGIFImageDataFixedHeightSmall_IChild>();
		public void Add(GiphyGIFImageDataFixedHeightSmall_IChild child) { _children.Add(child); }
		public IEnumerator<GiphyGIFImageDataFixedHeightSmall_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public GiphyGIFImageDataFixedHeightSmallFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "GiphyGIFImageDataFixedHeightSmall");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface GiphyGIFImageDataFixedHeightSmallStill_IChild : INode {
	}
	public class GiphyGIFImageDataFixedHeightSmallStillFragment : GiphyGIFImageDataFixedHeightSmallStill_IChild, IEnumerable<GiphyGIFImageDataFixedHeightSmallStill_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GiphyGIFImageDataFixedHeightSmallStill); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GiphyGIFImageDataFixedHeightSmallStill_IChild> _children = new List<GiphyGIFImageDataFixedHeightSmallStill_IChild>();
		public void Add(GiphyGIFImageDataFixedHeightSmallStill_IChild child) { _children.Add(child); }
		public IEnumerator<GiphyGIFImageDataFixedHeightSmallStill_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public GiphyGIFImageDataFixedHeightSmallStillFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "GiphyGIFImageDataFixedHeightSmallStill");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface GiphyGIFImageDataFixedWidthSmall_IChild : INode {
	}
	public class GiphyGIFImageDataFixedWidthSmallFragment : GiphyGIFImageDataFixedWidthSmall_IChild, IEnumerable<GiphyGIFImageDataFixedWidthSmall_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GiphyGIFImageDataFixedWidthSmall); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GiphyGIFImageDataFixedWidthSmall_IChild> _children = new List<GiphyGIFImageDataFixedWidthSmall_IChild>();
		public void Add(GiphyGIFImageDataFixedWidthSmall_IChild child) { _children.Add(child); }
		public IEnumerator<GiphyGIFImageDataFixedWidthSmall_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public GiphyGIFImageDataFixedWidthSmallFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "GiphyGIFImageDataFixedWidthSmall");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface GiphyGIFImageDataFixedWidthSmallStill_IChild : INode {
	}
	public class GiphyGIFImageDataFixedWidthSmallStillFragment : GiphyGIFImageDataFixedWidthSmallStill_IChild, IEnumerable<GiphyGIFImageDataFixedWidthSmallStill_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GiphyGIFImageDataFixedWidthSmallStill); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GiphyGIFImageDataFixedWidthSmallStill_IChild> _children = new List<GiphyGIFImageDataFixedWidthSmallStill_IChild>();
		public void Add(GiphyGIFImageDataFixedWidthSmallStill_IChild child) { _children.Add(child); }
		public IEnumerator<GiphyGIFImageDataFixedWidthSmallStill_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public GiphyGIFImageDataFixedWidthSmallStillFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "GiphyGIFImageDataFixedWidthSmallStill");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface GiphyGIFImageDataDownsized_IChild : INode {
	}
	public class GiphyGIFImageDataDownsizedFragment : GiphyGIFImageDataDownsized_IChild, IEnumerable<GiphyGIFImageDataDownsized_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GiphyGIFImageDataDownsized); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GiphyGIFImageDataDownsized_IChild> _children = new List<GiphyGIFImageDataDownsized_IChild>();
		public void Add(GiphyGIFImageDataDownsized_IChild child) { _children.Add(child); }
		public IEnumerator<GiphyGIFImageDataDownsized_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public GiphyGIFImageDataDownsizedFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "GiphyGIFImageDataDownsized");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface GiphyGIFImageDataDownsizedStill_IChild : INode {
	}
	public class GiphyGIFImageDataDownsizedStillFragment : GiphyGIFImageDataDownsizedStill_IChild, IEnumerable<GiphyGIFImageDataDownsizedStill_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GiphyGIFImageDataDownsizedStill); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GiphyGIFImageDataDownsizedStill_IChild> _children = new List<GiphyGIFImageDataDownsizedStill_IChild>();
		public void Add(GiphyGIFImageDataDownsizedStill_IChild child) { _children.Add(child); }
		public IEnumerator<GiphyGIFImageDataDownsizedStill_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public GiphyGIFImageDataDownsizedStillFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "GiphyGIFImageDataDownsizedStill");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface GiphyGIFImageDataDownsizedLarge_IChild : INode {
	}
	public class GiphyGIFImageDataDownsizedLargeFragment : GiphyGIFImageDataDownsizedLarge_IChild, IEnumerable<GiphyGIFImageDataDownsizedLarge_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GiphyGIFImageDataDownsizedLarge); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GiphyGIFImageDataDownsizedLarge_IChild> _children = new List<GiphyGIFImageDataDownsizedLarge_IChild>();
		public void Add(GiphyGIFImageDataDownsizedLarge_IChild child) { _children.Add(child); }
		public IEnumerator<GiphyGIFImageDataDownsizedLarge_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public GiphyGIFImageDataDownsizedLargeFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "GiphyGIFImageDataDownsizedLarge");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface GiphyGIFImageDataOriginal_IChild : INode {
	}
	public class GiphyGIFImageDataOriginalFragment : GiphyGIFImageDataOriginal_IChild, IEnumerable<GiphyGIFImageDataOriginal_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GiphyGIFImageDataOriginal); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GiphyGIFImageDataOriginal_IChild> _children = new List<GiphyGIFImageDataOriginal_IChild>();
		public void Add(GiphyGIFImageDataOriginal_IChild child) { _children.Add(child); }
		public IEnumerator<GiphyGIFImageDataOriginal_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public GiphyGIFImageDataOriginalFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "GiphyGIFImageDataOriginal");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface GiphyGIFImageDataOriginalStill_IChild : INode {
	}
	public class GiphyGIFImageDataOriginalStillFragment : GiphyGIFImageDataOriginalStill_IChild, IEnumerable<GiphyGIFImageDataOriginalStill_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GiphyGIFImageDataOriginalStill); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GiphyGIFImageDataOriginalStill_IChild> _children = new List<GiphyGIFImageDataOriginalStill_IChild>();
		public void Add(GiphyGIFImageDataOriginalStill_IChild child) { _children.Add(child); }
		public IEnumerator<GiphyGIFImageDataOriginalStill_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public GiphyGIFImageDataOriginalStillFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "GiphyGIFImageDataOriginalStill");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface GiphyGIFImageDataLooping_IChild : INode {
	}
	public class GiphyGIFImageDataLoopingFragment : GiphyGIFImageDataLooping_IChild, IEnumerable<GiphyGIFImageDataLooping_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GiphyGIFImageDataLooping); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GiphyGIFImageDataLooping_IChild> _children = new List<GiphyGIFImageDataLooping_IChild>();
		public void Add(GiphyGIFImageDataLooping_IChild child) { _children.Add(child); }
		public IEnumerator<GiphyGIFImageDataLooping_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public GiphyGIFImageDataLoopingFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "GiphyGIFImageDataLooping");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface GraphQLHubMutationAPI_IChild : INode {
	}
	public class GraphQLHubMutationAPIFragment : GraphQLHubMutationAPI_IChild, IEnumerable<GraphQLHubMutationAPI_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GraphQLHubMutationAPI); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GraphQLHubMutationAPI_IChild> _children = new List<GraphQLHubMutationAPI_IChild>();
		public void Add(GraphQLHubMutationAPI_IChild child) { _children.Add(child); }
		public IEnumerator<GraphQLHubMutationAPI_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public GraphQLHubMutationAPIFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "GraphQLHubMutationAPI");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public interface SetValueForKeyPayload_IChild : INode {
	}
	public class SetValueForKeyPayloadFragment : SetValueForKeyPayload_IChild, IEnumerable<SetValueForKeyPayload_IChild> {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.SetValueForKeyPayload); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<SetValueForKeyPayload_IChild> _children = new List<SetValueForKeyPayload_IChild>();
		public void Add(SetValueForKeyPayload_IChild child) { _children.Add(child); }
		public IEnumerator<SetValueForKeyPayload_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public SetValueForKeyPayloadFragment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.WriteFragment(this, "SetValueForKeyPayload");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
			foreach (var child in _children) child.GetVariables(variables);
		}
	}
	public class OnHackerNewsV2Story : IEnumerable<HackerNewsV2Story_IChild>, Node_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.HackerNewsV2Story); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<HackerNewsV2Story_IChild> _children = new List<HackerNewsV2Story_IChild>();
		public void Add(HackerNewsV2Story_IChild child) { _children.Add(child); }
		public IEnumerator<HackerNewsV2Story_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public OnHackerNewsV2Story(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("... on HackerNewsV2Story");
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
	public class OnHackerNewsV2User : IEnumerable<HackerNewsV2User_IChild>, Node_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.HackerNewsV2User); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<HackerNewsV2User_IChild> _children = new List<HackerNewsV2User_IChild>();
		public void Add(HackerNewsV2User_IChild child) { _children.Add(child); }
		public IEnumerator<HackerNewsV2User_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public OnHackerNewsV2User(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("... on HackerNewsV2User");
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
	public class OnHackerNewsV2Comment : IEnumerable<HackerNewsV2Comment_IChild>, Node_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.HackerNewsV2Comment); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<HackerNewsV2Comment_IChild> _children = new List<HackerNewsV2Comment_IChild>();
		public void Add(HackerNewsV2Comment_IChild child) { _children.Add(child); }
		public IEnumerator<HackerNewsV2Comment_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public OnHackerNewsV2Comment(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("... on HackerNewsV2Comment");
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
	public class OnHackerNewsV2Job : IEnumerable<HackerNewsV2Job_IChild>, Node_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.HackerNewsV2Job); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<HackerNewsV2Job_IChild> _children = new List<HackerNewsV2Job_IChild>();
		public void Add(HackerNewsV2Job_IChild child) { _children.Add(child); }
		public IEnumerator<HackerNewsV2Job_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public OnHackerNewsV2Job(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("... on HackerNewsV2Job");
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
	public class OnHackerNewsV2Poll : IEnumerable<HackerNewsV2Poll_IChild>, Node_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.HackerNewsV2Poll); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<HackerNewsV2Poll_IChild> _children = new List<HackerNewsV2Poll_IChild>();
		public void Add(HackerNewsV2Poll_IChild child) { _children.Add(child); }
		public IEnumerator<HackerNewsV2Poll_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public OnHackerNewsV2Poll(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("... on HackerNewsV2Poll");
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
	public class OnHackerNewsV2PollPart : IEnumerable<HackerNewsV2PollPart_IChild>, Node_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.HackerNewsV2PollPart); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<HackerNewsV2PollPart_IChild> _children = new List<HackerNewsV2PollPart_IChild>();
		public void Add(HackerNewsV2PollPart_IChild child) { _children.Add(child); }
		public IEnumerator<HackerNewsV2PollPart_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public OnHackerNewsV2PollPart(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("... on HackerNewsV2PollPart");
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
	public class GraphQLHubAPI : IEnumerable<GraphQLHubAPI_IChild>, INode {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GraphQLHubAPI); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GraphQLHubAPI_IChild> _children = new List<GraphQLHubAPI_IChild>();
		public void Add(GraphQLHubAPI_IChild child) { _children.Add(child); }
		public IEnumerator<GraphQLHubAPI_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public GraphQLHubAPI(Meta _Meta = null) {
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
	public class GraphQLHubMutationAPI : IEnumerable<GraphQLHubMutationAPI_IChild>, INode {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GraphQLHubMutationAPI); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GraphQLHubMutationAPI_IChild> _children = new List<GraphQLHubMutationAPI_IChild>();
		public void Add(GraphQLHubMutationAPI_IChild child) { _children.Add(child); }
		public IEnumerator<GraphQLHubMutationAPI_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public GraphQLHubMutationAPI(Meta _Meta = null) {
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
	public class graphQLHub : GraphQLHubAPI_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		/// <summary>
		/// About GraphQLHub
		/// </summary>
		public graphQLHub(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("graphQLHub", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class hn : IEnumerable<HackerNewsAPI_IChild>, GraphQLHubAPI_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.HackerNewsAPI); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<HackerNewsAPI_IChild> _children = new List<HackerNewsAPI_IChild>();
		public void Add(HackerNewsAPI_IChild child) { _children.Add(child); }
		public IEnumerator<HackerNewsAPI_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public hn(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("hn", _meta);
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
	public class hn2 : IEnumerable<HackerNewsAPIV2_IChild>, GraphQLHubAPI_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.HackerNewsAPIV2); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<HackerNewsAPIV2_IChild> _children = new List<HackerNewsAPIV2_IChild>();
		public void Add(HackerNewsAPIV2_IChild child) { _children.Add(child); }
		public IEnumerator<HackerNewsAPIV2_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public hn2(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("hn2", _meta);
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
	public class reddit : IEnumerable<RedditAPI_IChild>, GraphQLHubAPI_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.RedditAPI); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<RedditAPI_IChild> _children = new List<RedditAPI_IChild>();
		public void Add(RedditAPI_IChild child) { _children.Add(child); }
		public IEnumerator<RedditAPI_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public reddit(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("reddit", _meta);
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
	public class keyValue : IEnumerable<KeyValueAPI_IChild>, GraphQLHubAPI_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.KeyValueAPI); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<KeyValueAPI_IChild> _children = new List<KeyValueAPI_IChild>();
		public void Add(KeyValueAPI_IChild child) { _children.Add(child); }
		public IEnumerator<KeyValueAPI_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public keyValue(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("keyValue", _meta);
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
	public class github : IEnumerable<GithubAPI_IChild>, GraphQLHubAPI_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GithubAPI); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GithubAPI_IChild> _children = new List<GithubAPI_IChild>();
		public void Add(GithubAPI_IChild child) { _children.Add(child); }
		public IEnumerator<GithubAPI_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public github(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("github", _meta);
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
	public class twitter : IEnumerable<TwitterAPI_IChild>, GraphQLHubAPI_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.TwitterAPI); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<TwitterAPI_IChild> _children = new List<TwitterAPI_IChild>();
		public void Add(TwitterAPI_IChild child) { _children.Add(child); }
		public IEnumerator<TwitterAPI_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public twitter(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("twitter", _meta);
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
	public class giphy : IEnumerable<GiphyAPI_IChild>, GraphQLHubAPI_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GiphyAPI); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GiphyAPI_IChild> _children = new List<GiphyAPI_IChild>();
		public void Add(GiphyAPI_IChild child) { _children.Add(child); }
		public IEnumerator<GiphyAPI_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public giphy(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("giphy", _meta);
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
	public class item : IEnumerable<HackerNewsItem_IChild>, HackerNewsAPI_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.HackerNewsItem); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly VariableReference<int> _id;
		private readonly List<HackerNewsItem_IChild> _children = new List<HackerNewsItem_IChild>();
		public void Add(HackerNewsItem_IChild child) { _children.Add(child); }
		public IEnumerator<HackerNewsItem_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <param name="id">id of the item</param>
		public item(VariableReference<int> id = default(VariableReference<int>), Meta _Meta = null) {
			_id = id;
			_id.Type = "Int!";
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("item", _meta);
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
	public class user : IEnumerable<HackerNewsUser_IChild>, HackerNewsAPI_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.HackerNewsUser); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly VariableReference<string> _id;
		private readonly List<HackerNewsUser_IChild> _children = new List<HackerNewsUser_IChild>();
		public void Add(HackerNewsUser_IChild child) { _children.Add(child); }
		public IEnumerator<HackerNewsUser_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <param name="id">id of the user</param>
		public user(VariableReference<string> id = default(VariableReference<string>), Meta _Meta = null) {
			_id = id;
			_id.Type = "String!";
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("user", _meta);
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
	public class topStories : IEnumerable<HackerNewsItem_IChild>, HackerNewsAPI_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.HackerNewsItem).MakeArrayType(); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly VariableReference<int> _limit;
		private readonly VariableReference<int> _offset;
		private readonly List<HackerNewsItem_IChild> _children = new List<HackerNewsItem_IChild>();
		public void Add(HackerNewsItem_IChild child) { _children.Add(child); }
		public IEnumerator<HackerNewsItem_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <summary>
		/// Up to 500 of the top stories
		/// </summary>
		/// <param name="limit">Number of items to return</param>
		/// <param name="offset">Initial offset of number of items to return</param>
		public topStories(VariableReference<int> limit = default(VariableReference<int>), VariableReference<int> offset = default(VariableReference<int>), Meta _Meta = null) {
			_limit = limit;
			_limit.Type = "Int";
			_offset = offset;
			_offset.Type = "Int";
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("topStories", _meta);
			bool hasParameters = false;
			if (_limit.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("limit: ");
				writer.WriteValue(_limit);
			}
			if (_offset.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("offset: ");
				writer.WriteValue(_offset);
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
			if (_limit.Key != null) variables[_limit.Key] = _limit;
			if (_offset.Key != null) variables[_offset.Key] = _offset;
			foreach (var child in _children) {
				child.GetVariables(variables);
			}
		}
	}
	public class newStories : IEnumerable<HackerNewsItem_IChild>, HackerNewsAPI_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.HackerNewsItem).MakeArrayType(); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly VariableReference<int> _limit;
		private readonly VariableReference<int> _offset;
		private readonly List<HackerNewsItem_IChild> _children = new List<HackerNewsItem_IChild>();
		public void Add(HackerNewsItem_IChild child) { _children.Add(child); }
		public IEnumerator<HackerNewsItem_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <summary>
		/// Up to 500 of the newest stories
		/// </summary>
		/// <param name="limit">Number of items to return</param>
		/// <param name="offset">Initial offset of number of items to return</param>
		public newStories(VariableReference<int> limit = default(VariableReference<int>), VariableReference<int> offset = default(VariableReference<int>), Meta _Meta = null) {
			_limit = limit;
			_limit.Type = "Int";
			_offset = offset;
			_offset.Type = "Int";
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("newStories", _meta);
			bool hasParameters = false;
			if (_limit.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("limit: ");
				writer.WriteValue(_limit);
			}
			if (_offset.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("offset: ");
				writer.WriteValue(_offset);
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
			if (_limit.Key != null) variables[_limit.Key] = _limit;
			if (_offset.Key != null) variables[_offset.Key] = _offset;
			foreach (var child in _children) {
				child.GetVariables(variables);
			}
		}
	}
	public class showStories : IEnumerable<HackerNewsItem_IChild>, HackerNewsAPI_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.HackerNewsItem).MakeArrayType(); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly VariableReference<int> _limit;
		private readonly VariableReference<int> _offset;
		private readonly List<HackerNewsItem_IChild> _children = new List<HackerNewsItem_IChild>();
		public void Add(HackerNewsItem_IChild child) { _children.Add(child); }
		public IEnumerator<HackerNewsItem_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <summary>
		/// Up to 200 of the Show HN stories
		/// </summary>
		/// <param name="limit">Number of items to return</param>
		/// <param name="offset">Initial offset of number of items to return</param>
		public showStories(VariableReference<int> limit = default(VariableReference<int>), VariableReference<int> offset = default(VariableReference<int>), Meta _Meta = null) {
			_limit = limit;
			_limit.Type = "Int";
			_offset = offset;
			_offset.Type = "Int";
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("showStories", _meta);
			bool hasParameters = false;
			if (_limit.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("limit: ");
				writer.WriteValue(_limit);
			}
			if (_offset.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("offset: ");
				writer.WriteValue(_offset);
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
			if (_limit.Key != null) variables[_limit.Key] = _limit;
			if (_offset.Key != null) variables[_offset.Key] = _offset;
			foreach (var child in _children) {
				child.GetVariables(variables);
			}
		}
	}
	public class askStories : IEnumerable<HackerNewsItem_IChild>, HackerNewsAPI_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.HackerNewsItem).MakeArrayType(); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly VariableReference<int> _limit;
		private readonly VariableReference<int> _offset;
		private readonly List<HackerNewsItem_IChild> _children = new List<HackerNewsItem_IChild>();
		public void Add(HackerNewsItem_IChild child) { _children.Add(child); }
		public IEnumerator<HackerNewsItem_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <summary>
		/// Up to 200 of the Ask HN stories
		/// </summary>
		/// <param name="limit">Number of items to return</param>
		/// <param name="offset">Initial offset of number of items to return</param>
		public askStories(VariableReference<int> limit = default(VariableReference<int>), VariableReference<int> offset = default(VariableReference<int>), Meta _Meta = null) {
			_limit = limit;
			_limit.Type = "Int";
			_offset = offset;
			_offset.Type = "Int";
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("askStories", _meta);
			bool hasParameters = false;
			if (_limit.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("limit: ");
				writer.WriteValue(_limit);
			}
			if (_offset.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("offset: ");
				writer.WriteValue(_offset);
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
			if (_limit.Key != null) variables[_limit.Key] = _limit;
			if (_offset.Key != null) variables[_offset.Key] = _offset;
			foreach (var child in _children) {
				child.GetVariables(variables);
			}
		}
	}
	public class jobStories : IEnumerable<HackerNewsItem_IChild>, HackerNewsAPI_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.HackerNewsItem).MakeArrayType(); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly VariableReference<int> _limit;
		private readonly VariableReference<int> _offset;
		private readonly List<HackerNewsItem_IChild> _children = new List<HackerNewsItem_IChild>();
		public void Add(HackerNewsItem_IChild child) { _children.Add(child); }
		public IEnumerator<HackerNewsItem_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <summary>
		/// Up to 200 of the Job stores
		/// </summary>
		/// <param name="limit">Number of items to return</param>
		/// <param name="offset">Initial offset of number of items to return</param>
		public jobStories(VariableReference<int> limit = default(VariableReference<int>), VariableReference<int> offset = default(VariableReference<int>), Meta _Meta = null) {
			_limit = limit;
			_limit.Type = "Int";
			_offset = offset;
			_offset.Type = "Int";
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("jobStories", _meta);
			bool hasParameters = false;
			if (_limit.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("limit: ");
				writer.WriteValue(_limit);
			}
			if (_offset.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("offset: ");
				writer.WriteValue(_offset);
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
			if (_limit.Key != null) variables[_limit.Key] = _limit;
			if (_offset.Key != null) variables[_offset.Key] = _offset;
			foreach (var child in _children) {
				child.GetVariables(variables);
			}
		}
	}
	public class stories : IEnumerable<HackerNewsItem_IChild>, HackerNewsAPI_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.HackerNewsItem).MakeArrayType(); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly VariableReference<int> _limit;
		private readonly VariableReference<int> _offset;
		private readonly VariableReference<string> _storyType;
		private readonly List<HackerNewsItem_IChild> _children = new List<HackerNewsItem_IChild>();
		public void Add(HackerNewsItem_IChild child) { _children.Add(child); }
		public IEnumerator<HackerNewsItem_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <summary>
		/// Return list of stories
		/// </summary>
		/// <param name="limit">Number of items to return</param>
		/// <param name="offset">Initial offset of number of items to return</param>
		/// <param name="storyType">Type of story to list</param>
		public stories(VariableReference<int> limit = default(VariableReference<int>), VariableReference<int> offset = default(VariableReference<int>), VariableReference<string> storyType = default(VariableReference<string>), Meta _Meta = null) {
			_limit = limit;
			_limit.Type = "Int";
			_offset = offset;
			_offset.Type = "Int";
			_storyType = storyType;
			_storyType.Type = "String!";
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("stories", _meta);
			bool hasParameters = false;
			if (_limit.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("limit: ");
				writer.WriteValue(_limit);
			}
			if (_offset.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("offset: ");
				writer.WriteValue(_offset);
			}
			if (_storyType.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("storyType: ");
				writer.WriteValue(_storyType);
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
			if (_limit.Key != null) variables[_limit.Key] = _limit;
			if (_offset.Key != null) variables[_offset.Key] = _offset;
			if (_storyType.Key != null) variables[_storyType.Key] = _storyType;
			foreach (var child in _children) {
				child.GetVariables(variables);
			}
		}
	}
	public class id : HackerNewsItem_IChild, HackerNewsUser_IChild, KeyValueItem_IChild, GiphyGIFData_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		/// <summary>
		/// The item's unique id.
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
	public class deleted : HackerNewsItem_IChild, HackerNewsV2Story_IChild, HackerNewsV2Comment_IChild, HackerNewsV2Job_IChild, HackerNewsV2Poll_IChild, HackerNewsV2PollPart_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(bool); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		/// <summary>
		/// if the item is deleted
		/// </summary>
		public deleted(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("deleted", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class type : HackerNewsItem_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.ItemType); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		/// <summary>
		/// The type of item. One of "job", "story", "comment", "poll", or "pollopt".
		/// </summary>
		public type(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("type", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class by : IEnumerable<HackerNewsUser_IChild>, HackerNewsItem_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.HackerNewsUser); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<HackerNewsUser_IChild> _children = new List<HackerNewsUser_IChild>();
		public void Add(HackerNewsUser_IChild child) { _children.Add(child); }
		public IEnumerator<HackerNewsUser_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <summary>
		/// The item's author.
		/// </summary>
		public by(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("by", _meta);
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
	public class time : HackerNewsItem_IChild, HackerNewsV2Story_IChild, HackerNewsV2Comment_IChild, HackerNewsV2Job_IChild, HackerNewsV2Poll_IChild, HackerNewsV2PollPart_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(int); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		/// <summary>
		/// Creation date of the item, in Unix Time.
		/// </summary>
		public time(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("time", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class timeISO : HackerNewsItem_IChild, HackerNewsV2Story_IChild, HackerNewsV2Comment_IChild, HackerNewsV2Job_IChild, HackerNewsV2Poll_IChild, HackerNewsV2PollPart_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		/// <summary>
		/// Creation date of the item, in ISO8601
		/// </summary>
		public timeISO(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("timeISO", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class text : HackerNewsItem_IChild, HackerNewsV2Story_IChild, HackerNewsV2Comment_IChild, HackerNewsV2Job_IChild, HackerNewsV2Poll_IChild, HackerNewsV2PollPart_IChild, Tweet_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public text(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("text", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class dead : HackerNewsItem_IChild, HackerNewsV2Story_IChild, HackerNewsV2Comment_IChild, HackerNewsV2Job_IChild, HackerNewsV2Poll_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(bool); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		/// <summary>
		/// if the item is dead
		/// </summary>
		public dead(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("dead", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class url : HackerNewsItem_IChild, HackerNewsV2Story_IChild, HackerNewsV2Job_IChild, GithubIssueLabelType_IChild, TwitterUser_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public url(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("url", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class score : HackerNewsItem_IChild, HackerNewsV2Story_IChild, HackerNewsV2Job_IChild, HackerNewsV2Poll_IChild, HackerNewsV2PollPart_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(int); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		/// <summary>
		/// The story's score, or the votes for a pollopt.
		/// </summary>
		public score(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("score", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class title : HackerNewsItem_IChild, HackerNewsV2Story_IChild, HackerNewsV2Job_IChild, HackerNewsV2Poll_IChild, GithubIssue_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public title(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("title", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class kids : IEnumerable<HackerNewsItem_IChild>, HackerNewsItem_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.HackerNewsItem).MakeArrayType(); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly VariableReference<int> _limit;
		private readonly VariableReference<int> _offset;
		private readonly List<HackerNewsItem_IChild> _children = new List<HackerNewsItem_IChild>();
		public void Add(HackerNewsItem_IChild child) { _children.Add(child); }
		public IEnumerator<HackerNewsItem_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <summary>
		/// The item's comments, in ranked display order.
		/// </summary>
		/// <param name="limit">Number of items to return</param>
		/// <param name="offset">Initial offset of number of items to return</param>
		public kids(VariableReference<int> limit = default(VariableReference<int>), VariableReference<int> offset = default(VariableReference<int>), Meta _Meta = null) {
			_limit = limit;
			_limit.Type = "Int";
			_offset = offset;
			_offset.Type = "Int";
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("kids", _meta);
			bool hasParameters = false;
			if (_limit.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("limit: ");
				writer.WriteValue(_limit);
			}
			if (_offset.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("offset: ");
				writer.WriteValue(_offset);
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
			if (_limit.Key != null) variables[_limit.Key] = _limit;
			if (_offset.Key != null) variables[_offset.Key] = _offset;
			foreach (var child in _children) {
				child.GetVariables(variables);
			}
		}
	}
	public class parent : IEnumerable<HackerNewsItem_IChild>, HackerNewsItem_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.HackerNewsItem); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<HackerNewsItem_IChild> _children = new List<HackerNewsItem_IChild>();
		public void Add(HackerNewsItem_IChild child) { _children.Add(child); }
		public IEnumerator<HackerNewsItem_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <summary>
		/// The item's parent. For comments, either another comment or the relevant story. For pollopts, the relevant poll.
		/// </summary>
		public parent(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("parent", _meta);
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
	public class parts : IEnumerable<HackerNewsItem_IChild>, HackerNewsItem_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.HackerNewsItem).MakeArrayType(); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<HackerNewsItem_IChild> _children = new List<HackerNewsItem_IChild>();
		public void Add(HackerNewsItem_IChild child) { _children.Add(child); }
		public IEnumerator<HackerNewsItem_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <summary>
		/// A list of related pollopts, in display order.
		/// </summary>
		public parts(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("parts", _meta);
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
	public class descendants : HackerNewsItem_IChild, HackerNewsV2Story_IChild, HackerNewsV2Poll_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(int); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		/// <summary>
		/// In the case of stories or polls, the total comment count.
		/// </summary>
		public descendants(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("descendants", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class delay : HackerNewsUser_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(int); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		/// <summary>
		/// Delay in minutes between a comment's creation and its visibility to other users.
		/// </summary>
		public delay(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("delay", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class created : HackerNewsUser_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(int); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		/// <summary>
		/// Creation date of the user, in Unix Time.
		/// </summary>
		public created(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("created", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class createdISO : HackerNewsUser_IChild, RedditSubreddit_IChild, RedditUser_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		/// <summary>
		/// Creation date of the user, in ISO8601
		/// </summary>
		public createdISO(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("createdISO", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class about : HackerNewsUser_IChild, HackerNewsV2User_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		/// <summary>
		/// The user's optional self-description. HTML.
		/// </summary>
		public about(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("about", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class submitted : IEnumerable<HackerNewsItem_IChild>, HackerNewsUser_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.HackerNewsItem).MakeArrayType(); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly VariableReference<int> _limit;
		private readonly VariableReference<int> _offset;
		private readonly List<HackerNewsItem_IChild> _children = new List<HackerNewsItem_IChild>();
		public void Add(HackerNewsItem_IChild child) { _children.Add(child); }
		public IEnumerator<HackerNewsItem_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <summary>
		/// List of the user's stories, polls and comments.
		/// </summary>
		/// <param name="limit">Number of items to return</param>
		/// <param name="offset">Initial offset of number of items to return</param>
		public submitted(VariableReference<int> limit = default(VariableReference<int>), VariableReference<int> offset = default(VariableReference<int>), Meta _Meta = null) {
			_limit = limit;
			_limit.Type = "Int";
			_offset = offset;
			_offset.Type = "Int";
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("submitted", _meta);
			bool hasParameters = false;
			if (_limit.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("limit: ");
				writer.WriteValue(_limit);
			}
			if (_offset.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("offset: ");
				writer.WriteValue(_offset);
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
			if (_limit.Key != null) variables[_limit.Key] = _limit;
			if (_offset.Key != null) variables[_offset.Key] = _offset;
			foreach (var child in _children) {
				child.GetVariables(variables);
			}
		}
	}
	public class node : IEnumerable<Node_IChild>, HackerNewsAPIV2_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.Node); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly VariableReference<string> _id;
		private readonly List<Node_IChild> _children = new List<Node_IChild>();
		public void Add(Node_IChild child) { _children.Add(child); }
		public IEnumerator<Node_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <summary>
		/// Fetches an object given its ID
		/// </summary>
		/// <param name="id">The ID of an object</param>
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
	public class nodeFromHnId : IEnumerable<Node_IChild>, HackerNewsAPIV2_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.Node); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly VariableReference<string> _id;
		private readonly VariableReference<bool> _isUserId;
		private readonly List<Node_IChild> _children = new List<Node_IChild>();
		public void Add(Node_IChild child) { _children.Add(child); }
		public IEnumerator<Node_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <summary>
		/// To ensure Node IDs are globally unique, GraphQLHub coerces IDs returned by the HN API. Use this field to get nodes via normal HN IDs
		/// </summary>
		public nodeFromHnId(VariableReference<string> id = default(VariableReference<string>), VariableReference<bool> isUserId = default(VariableReference<bool>), Meta _Meta = null) {
			_id = id;
			_id.Type = "String!";
			_isUserId = isUserId;
			_isUserId.Type = "Boolean!";
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("nodeFromHnId", _meta);
			bool hasParameters = false;
			if (_id.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("id: ");
				writer.WriteValue(_id);
			}
			if (_isUserId.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("isUserId: ");
				writer.WriteValue(_isUserId);
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
			if (_isUserId.Key != null) variables[_isUserId.Key] = _isUserId;
			foreach (var child in _children) {
				child.GetVariables(variables);
			}
		}
	}
	public class Node_id : Node_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		/// <summary>
		/// The id of the object.
		/// </summary>
		public Node_id(Meta _Meta = null) {
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
	public class HackerNewsV2Story_id : HackerNewsV2Story_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		/// <summary>
		/// The ID of an object
		/// </summary>
		public HackerNewsV2Story_id(Meta _Meta = null) {
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
	public class hnId : HackerNewsV2Story_IChild, HackerNewsV2User_IChild, HackerNewsV2Comment_IChild, HackerNewsV2Job_IChild, HackerNewsV2Poll_IChild, HackerNewsV2PollPart_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		/// <summary>
		/// The item's unique id.
		/// </summary>
		public hnId(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("hnId", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class HackerNewsV2Story_by : IEnumerable<HackerNewsV2User_IChild>, HackerNewsV2Story_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.HackerNewsV2User); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<HackerNewsV2User_IChild> _children = new List<HackerNewsV2User_IChild>();
		public void Add(HackerNewsV2User_IChild child) { _children.Add(child); }
		public IEnumerator<HackerNewsV2User_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <summary>
		/// The item's author.
		/// </summary>
		public HackerNewsV2Story_by(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("by", _meta);
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
	public class HackerNewsV2Story_kids : IEnumerable<HackerNewsV2CommentConnection_IChild>, HackerNewsV2Story_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.HackerNewsV2CommentConnection); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly VariableReference<string> _after;
		private readonly VariableReference<int> _first;
		private readonly VariableReference<string> _before;
		private readonly VariableReference<int> _last;
		private readonly List<HackerNewsV2CommentConnection_IChild> _children = new List<HackerNewsV2CommentConnection_IChild>();
		public void Add(HackerNewsV2CommentConnection_IChild child) { _children.Add(child); }
		public IEnumerator<HackerNewsV2CommentConnection_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <summary>
		/// The item's comments, in ranked display order.
		/// </summary>
		public HackerNewsV2Story_kids(VariableReference<string> after = default(VariableReference<string>), VariableReference<int> first = default(VariableReference<int>), VariableReference<string> before = default(VariableReference<string>), VariableReference<int> last = default(VariableReference<int>), Meta _Meta = null) {
			_after = after;
			_after.Type = "String";
			_first = first;
			_first.Type = "Int";
			_before = before;
			_before.Type = "String";
			_last = last;
			_last.Type = "Int";
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("kids", _meta);
			bool hasParameters = false;
			if (_after.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("after: ");
				writer.WriteValue(_after);
			}
			if (_first.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("first: ");
				writer.WriteValue(_first);
			}
			if (_before.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("before: ");
				writer.WriteValue(_before);
			}
			if (_last.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("last: ");
				writer.WriteValue(_last);
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
			if (_after.Key != null) variables[_after.Key] = _after;
			if (_first.Key != null) variables[_first.Key] = _first;
			if (_before.Key != null) variables[_before.Key] = _before;
			if (_last.Key != null) variables[_last.Key] = _last;
			foreach (var child in _children) {
				child.GetVariables(variables);
			}
		}
	}
	public class HackerNewsV2User_id : HackerNewsV2User_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		/// <summary>
		/// The ID of an object
		/// </summary>
		public HackerNewsV2User_id(Meta _Meta = null) {
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
	public class HackerNewsV2User_delay : HackerNewsV2User_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(int); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		/// <summary>
		/// Delay in minutes between a comment's creation and its visibility to other users.
		/// </summary>
		public HackerNewsV2User_delay(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("delay", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class HackerNewsV2User_created : HackerNewsV2User_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(int); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		/// <summary>
		/// Creation date of the user, in Unix Time.
		/// </summary>
		public HackerNewsV2User_created(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("created", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class HackerNewsV2User_createdISO : HackerNewsV2User_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		/// <summary>
		/// Creation date of the user, in ISO8601
		/// </summary>
		public HackerNewsV2User_createdISO(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("createdISO", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class HackerNewsV2User_submitted : IEnumerable<NodeConnection_IChild>, HackerNewsV2User_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.NodeConnection); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly VariableReference<string> _after;
		private readonly VariableReference<int> _first;
		private readonly VariableReference<string> _before;
		private readonly VariableReference<int> _last;
		private readonly List<NodeConnection_IChild> _children = new List<NodeConnection_IChild>();
		public void Add(NodeConnection_IChild child) { _children.Add(child); }
		public IEnumerator<NodeConnection_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <summary>
		/// List of the user's stories, polls and comments.
		/// </summary>
		public HackerNewsV2User_submitted(VariableReference<string> after = default(VariableReference<string>), VariableReference<int> first = default(VariableReference<int>), VariableReference<string> before = default(VariableReference<string>), VariableReference<int> last = default(VariableReference<int>), Meta _Meta = null) {
			_after = after;
			_after.Type = "String";
			_first = first;
			_first.Type = "Int";
			_before = before;
			_before.Type = "String";
			_last = last;
			_last.Type = "Int";
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("submitted", _meta);
			bool hasParameters = false;
			if (_after.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("after: ");
				writer.WriteValue(_after);
			}
			if (_first.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("first: ");
				writer.WriteValue(_first);
			}
			if (_before.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("before: ");
				writer.WriteValue(_before);
			}
			if (_last.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("last: ");
				writer.WriteValue(_last);
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
			if (_after.Key != null) variables[_after.Key] = _after;
			if (_first.Key != null) variables[_first.Key] = _first;
			if (_before.Key != null) variables[_before.Key] = _before;
			if (_last.Key != null) variables[_last.Key] = _last;
			foreach (var child in _children) {
				child.GetVariables(variables);
			}
		}
	}
	public class pageInfo : IEnumerable<PageInfo_IChild>, NodeConnection_IChild, HackerNewsV2CommentConnection_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.PageInfo); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<PageInfo_IChild> _children = new List<PageInfo_IChild>();
		public void Add(PageInfo_IChild child) { _children.Add(child); }
		public IEnumerator<PageInfo_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <summary>
		/// Information to aid in pagination.
		/// </summary>
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
	public class edges : IEnumerable<NodeEdge_IChild>, NodeConnection_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.NodeEdge).MakeArrayType(); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<NodeEdge_IChild> _children = new List<NodeEdge_IChild>();
		public void Add(NodeEdge_IChild child) { _children.Add(child); }
		public IEnumerator<NodeEdge_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <summary>
		/// Information to aid in pagination.
		/// </summary>
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
	public class hasNextPage : PageInfo_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(bool); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		/// <summary>
		/// When paginating forwards, are there more items?
		/// </summary>
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
		/// <summary>
		/// When paginating backwards, are there more items?
		/// </summary>
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
	public class startCursor : PageInfo_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		/// <summary>
		/// When paginating backwards, the cursor to continue.
		/// </summary>
		public startCursor(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("startCursor", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class endCursor : PageInfo_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		/// <summary>
		/// When paginating forwards, the cursor to continue.
		/// </summary>
		public endCursor(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("endCursor", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class NodeEdge_node : IEnumerable<Node_IChild>, NodeEdge_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.Node); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<Node_IChild> _children = new List<Node_IChild>();
		public void Add(Node_IChild child) { _children.Add(child); }
		public IEnumerator<Node_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <summary>
		/// The item at the end of the edge
		/// </summary>
		public NodeEdge_node(Meta _Meta = null) {
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
	public class cursor : NodeEdge_IChild, HackerNewsV2CommentEdge_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		/// <summary>
		/// A cursor for use in pagination
		/// </summary>
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
	public class HackerNewsV2CommentConnection_edges : IEnumerable<HackerNewsV2CommentEdge_IChild>, HackerNewsV2CommentConnection_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.HackerNewsV2CommentEdge).MakeArrayType(); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<HackerNewsV2CommentEdge_IChild> _children = new List<HackerNewsV2CommentEdge_IChild>();
		public void Add(HackerNewsV2CommentEdge_IChild child) { _children.Add(child); }
		public IEnumerator<HackerNewsV2CommentEdge_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <summary>
		/// Information to aid in pagination.
		/// </summary>
		public HackerNewsV2CommentConnection_edges(Meta _Meta = null) {
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
	public class HackerNewsV2CommentEdge_node : IEnumerable<HackerNewsV2Comment_IChild>, HackerNewsV2CommentEdge_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.HackerNewsV2Comment); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<HackerNewsV2Comment_IChild> _children = new List<HackerNewsV2Comment_IChild>();
		public void Add(HackerNewsV2Comment_IChild child) { _children.Add(child); }
		public IEnumerator<HackerNewsV2Comment_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <summary>
		/// The item at the end of the edge
		/// </summary>
		public HackerNewsV2CommentEdge_node(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("node", _meta);
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
	public class HackerNewsV2Comment_id : HackerNewsV2Comment_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		/// <summary>
		/// The ID of an object
		/// </summary>
		public HackerNewsV2Comment_id(Meta _Meta = null) {
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
	public class HackerNewsV2Comment_by : IEnumerable<HackerNewsV2User_IChild>, HackerNewsV2Comment_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.HackerNewsV2User); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<HackerNewsV2User_IChild> _children = new List<HackerNewsV2User_IChild>();
		public void Add(HackerNewsV2User_IChild child) { _children.Add(child); }
		public IEnumerator<HackerNewsV2User_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <summary>
		/// The item's author.
		/// </summary>
		public HackerNewsV2Comment_by(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("by", _meta);
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
	public class HackerNewsV2Comment_parent : IEnumerable<Node_IChild>, HackerNewsV2Comment_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.Node); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<Node_IChild> _children = new List<Node_IChild>();
		public void Add(Node_IChild child) { _children.Add(child); }
		public IEnumerator<Node_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <summary>
		/// The item's parent. For comments, either another comment or the relevant story. For pollopts, the relevant poll.
		/// </summary>
		public HackerNewsV2Comment_parent(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("parent", _meta);
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
	public class HackerNewsV2Comment_kids : IEnumerable<HackerNewsV2CommentConnection_IChild>, HackerNewsV2Comment_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.HackerNewsV2CommentConnection); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly VariableReference<string> _after;
		private readonly VariableReference<int> _first;
		private readonly VariableReference<string> _before;
		private readonly VariableReference<int> _last;
		private readonly List<HackerNewsV2CommentConnection_IChild> _children = new List<HackerNewsV2CommentConnection_IChild>();
		public void Add(HackerNewsV2CommentConnection_IChild child) { _children.Add(child); }
		public IEnumerator<HackerNewsV2CommentConnection_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <summary>
		/// The item's comments, in ranked display order.
		/// </summary>
		public HackerNewsV2Comment_kids(VariableReference<string> after = default(VariableReference<string>), VariableReference<int> first = default(VariableReference<int>), VariableReference<string> before = default(VariableReference<string>), VariableReference<int> last = default(VariableReference<int>), Meta _Meta = null) {
			_after = after;
			_after.Type = "String";
			_first = first;
			_first.Type = "Int";
			_before = before;
			_before.Type = "String";
			_last = last;
			_last.Type = "Int";
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("kids", _meta);
			bool hasParameters = false;
			if (_after.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("after: ");
				writer.WriteValue(_after);
			}
			if (_first.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("first: ");
				writer.WriteValue(_first);
			}
			if (_before.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("before: ");
				writer.WriteValue(_before);
			}
			if (_last.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("last: ");
				writer.WriteValue(_last);
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
			if (_after.Key != null) variables[_after.Key] = _after;
			if (_first.Key != null) variables[_first.Key] = _first;
			if (_before.Key != null) variables[_before.Key] = _before;
			if (_last.Key != null) variables[_last.Key] = _last;
			foreach (var child in _children) {
				child.GetVariables(variables);
			}
		}
	}
	public class HackerNewsV2Job_id : HackerNewsV2Job_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		/// <summary>
		/// The ID of an object
		/// </summary>
		public HackerNewsV2Job_id(Meta _Meta = null) {
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
	public class HackerNewsV2Job_by : IEnumerable<HackerNewsV2User_IChild>, HackerNewsV2Job_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.HackerNewsV2User); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<HackerNewsV2User_IChild> _children = new List<HackerNewsV2User_IChild>();
		public void Add(HackerNewsV2User_IChild child) { _children.Add(child); }
		public IEnumerator<HackerNewsV2User_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <summary>
		/// The item's author.
		/// </summary>
		public HackerNewsV2Job_by(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("by", _meta);
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
	public class HackerNewsV2Poll_id : HackerNewsV2Poll_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		/// <summary>
		/// The ID of an object
		/// </summary>
		public HackerNewsV2Poll_id(Meta _Meta = null) {
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
	public class HackerNewsV2Poll_by : IEnumerable<HackerNewsV2User_IChild>, HackerNewsV2Poll_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.HackerNewsV2User); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<HackerNewsV2User_IChild> _children = new List<HackerNewsV2User_IChild>();
		public void Add(HackerNewsV2User_IChild child) { _children.Add(child); }
		public IEnumerator<HackerNewsV2User_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <summary>
		/// The item's author.
		/// </summary>
		public HackerNewsV2Poll_by(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("by", _meta);
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
	public class HackerNewsV2Poll_kids : IEnumerable<HackerNewsV2CommentConnection_IChild>, HackerNewsV2Poll_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.HackerNewsV2CommentConnection); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly VariableReference<string> _after;
		private readonly VariableReference<int> _first;
		private readonly VariableReference<string> _before;
		private readonly VariableReference<int> _last;
		private readonly List<HackerNewsV2CommentConnection_IChild> _children = new List<HackerNewsV2CommentConnection_IChild>();
		public void Add(HackerNewsV2CommentConnection_IChild child) { _children.Add(child); }
		public IEnumerator<HackerNewsV2CommentConnection_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <summary>
		/// The item's comments, in ranked display order.
		/// </summary>
		public HackerNewsV2Poll_kids(VariableReference<string> after = default(VariableReference<string>), VariableReference<int> first = default(VariableReference<int>), VariableReference<string> before = default(VariableReference<string>), VariableReference<int> last = default(VariableReference<int>), Meta _Meta = null) {
			_after = after;
			_after.Type = "String";
			_first = first;
			_first.Type = "Int";
			_before = before;
			_before.Type = "String";
			_last = last;
			_last.Type = "Int";
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("kids", _meta);
			bool hasParameters = false;
			if (_after.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("after: ");
				writer.WriteValue(_after);
			}
			if (_first.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("first: ");
				writer.WriteValue(_first);
			}
			if (_before.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("before: ");
				writer.WriteValue(_before);
			}
			if (_last.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("last: ");
				writer.WriteValue(_last);
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
			if (_after.Key != null) variables[_after.Key] = _after;
			if (_first.Key != null) variables[_first.Key] = _first;
			if (_before.Key != null) variables[_before.Key] = _before;
			if (_last.Key != null) variables[_last.Key] = _last;
			foreach (var child in _children) {
				child.GetVariables(variables);
			}
		}
	}
	public class HackerNewsV2Poll_parts : IEnumerable<HackerNewsV2PollPart_IChild>, HackerNewsV2Poll_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.HackerNewsV2PollPart).MakeArrayType(); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<HackerNewsV2PollPart_IChild> _children = new List<HackerNewsV2PollPart_IChild>();
		public void Add(HackerNewsV2PollPart_IChild child) { _children.Add(child); }
		public IEnumerator<HackerNewsV2PollPart_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <summary>
		/// A list of related pollopts, in display order.
		/// </summary>
		public HackerNewsV2Poll_parts(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("parts", _meta);
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
	public class HackerNewsV2PollPart_id : HackerNewsV2PollPart_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		/// <summary>
		/// The ID of an object
		/// </summary>
		public HackerNewsV2PollPart_id(Meta _Meta = null) {
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
	public class HackerNewsV2PollPart_by : IEnumerable<HackerNewsV2User_IChild>, HackerNewsV2PollPart_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.HackerNewsV2User); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<HackerNewsV2User_IChild> _children = new List<HackerNewsV2User_IChild>();
		public void Add(HackerNewsV2User_IChild child) { _children.Add(child); }
		public IEnumerator<HackerNewsV2User_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <summary>
		/// The item's author.
		/// </summary>
		public HackerNewsV2PollPart_by(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("by", _meta);
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
	public class HackerNewsV2PollPart_parent : IEnumerable<Node_IChild>, HackerNewsV2PollPart_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.Node); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<Node_IChild> _children = new List<Node_IChild>();
		public void Add(Node_IChild child) { _children.Add(child); }
		public IEnumerator<Node_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <summary>
		/// The item's parent. For comments, either another comment or the relevant story. For pollopts, the relevant poll.
		/// </summary>
		public HackerNewsV2PollPart_parent(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("parent", _meta);
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
	public class subreddit : IEnumerable<RedditSubreddit_IChild>, RedditAPI_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.RedditSubreddit); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly VariableReference<string> _name;
		private readonly List<RedditSubreddit_IChild> _children = new List<RedditSubreddit_IChild>();
		public void Add(RedditSubreddit_IChild child) { _children.Add(child); }
		public IEnumerator<RedditSubreddit_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <param name="name">Name of the subreddit</param>
		public subreddit(VariableReference<string> name = default(VariableReference<string>), Meta _Meta = null) {
			_name = name;
			_name.Type = "String!";
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("subreddit", _meta);
			bool hasParameters = false;
			if (_name.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("name: ");
				writer.WriteValue(_name);
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
			if (_name.Key != null) variables[_name.Key] = _name;
			foreach (var child in _children) {
				child.GetVariables(variables);
			}
		}
	}
	public class RedditAPI_user : IEnumerable<RedditUser_IChild>, RedditAPI_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.RedditUser); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly VariableReference<string> _username;
		private readonly List<RedditUser_IChild> _children = new List<RedditUser_IChild>();
		public void Add(RedditUser_IChild child) { _children.Add(child); }
		public IEnumerator<RedditUser_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <param name="username">Username of the user</param>
		public RedditAPI_user(VariableReference<string> username = default(VariableReference<string>), Meta _Meta = null) {
			_username = username;
			_username.Type = "String!";
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("user", _meta);
			bool hasParameters = false;
			if (_username.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("username: ");
				writer.WriteValue(_username);
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
			if (_username.Key != null) variables[_username.Key] = _username;
			foreach (var child in _children) {
				child.GetVariables(variables);
			}
		}
	}
	public class name : RedditSubreddit_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		/// <summary>
		/// Name of the subreddit
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
	public class fullnameId : RedditSubreddit_IChild, RedditLink_IChild, RedditUser_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		/// <summary>
		/// The Reddit API fullname of the user
		/// </summary>
		public fullnameId(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("fullnameId", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class RedditSubreddit_title : RedditSubreddit_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		/// <summary>
		/// Title of the subreddit
		/// </summary>
		public RedditSubreddit_title(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("title", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class publicDescription : RedditSubreddit_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		/// <summary>
		/// Description of the subreddit
		/// </summary>
		public publicDescription(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("publicDescription", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class accountsActive : RedditSubreddit_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(int); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		/// <summary>
		/// Accounts active right now on the subreddit
		/// </summary>
		public accountsActive(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("accountsActive", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class subscribers : RedditSubreddit_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(int); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		/// <summary>
		/// Number of subscribers to the subreddit
		/// </summary>
		public subscribers(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("subscribers", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class RedditSubreddit_created : RedditSubreddit_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(float); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		/// <summary>
		/// Creation date of the subreddit, in Unix Time (UTC)
		/// </summary>
		public RedditSubreddit_created(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("created", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class hotListings : IEnumerable<RedditLink_IChild>, RedditSubreddit_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.RedditLink).MakeArrayType(); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly VariableReference<string> _after;
		private readonly VariableReference<string> _before;
		private readonly VariableReference<int> _count;
		private readonly VariableReference<int> _limit;
		private readonly List<RedditLink_IChild> _children = new List<RedditLink_IChild>();
		public void Add(RedditLink_IChild child) { _children.Add(child); }
		public IEnumerator<RedditLink_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <summary>
		/// Hot/"Front Page" listings of the subreddit
		/// </summary>
		/// <param name="after">FullnameId of an item in the listing to use as the anchor point of the slice.</param>
		/// <param name="before">FullnameId of an item in the listing to use as the anchor point of the slice.</param>
		/// <param name="count">The number of items already seen in this listing</param>
		/// <param name="limit">The maximum number of items to return in this slice of the listing.</param>
		public hotListings(VariableReference<string> after = default(VariableReference<string>), VariableReference<string> before = default(VariableReference<string>), VariableReference<int> count = default(VariableReference<int>), VariableReference<int> limit = default(VariableReference<int>), Meta _Meta = null) {
			_after = after;
			_after.Type = "String";
			_before = before;
			_before.Type = "String";
			_count = count;
			_count.Type = "Int";
			_limit = limit;
			_limit.Type = "Int";
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("hotListings", _meta);
			bool hasParameters = false;
			if (_after.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("after: ");
				writer.WriteValue(_after);
			}
			if (_before.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("before: ");
				writer.WriteValue(_before);
			}
			if (_count.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("count: ");
				writer.WriteValue(_count);
			}
			if (_limit.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("limit: ");
				writer.WriteValue(_limit);
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
			if (_after.Key != null) variables[_after.Key] = _after;
			if (_before.Key != null) variables[_before.Key] = _before;
			if (_count.Key != null) variables[_count.Key] = _count;
			if (_limit.Key != null) variables[_limit.Key] = _limit;
			foreach (var child in _children) {
				child.GetVariables(variables);
			}
		}
	}
	public class newListings : IEnumerable<RedditLink_IChild>, RedditSubreddit_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.RedditLink).MakeArrayType(); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly VariableReference<string> _after;
		private readonly VariableReference<string> _before;
		private readonly VariableReference<int> _count;
		private readonly VariableReference<int> _limit;
		private readonly List<RedditLink_IChild> _children = new List<RedditLink_IChild>();
		public void Add(RedditLink_IChild child) { _children.Add(child); }
		public IEnumerator<RedditLink_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <summary>
		/// Newest listings of the subreddit
		/// </summary>
		/// <param name="after">FullnameId of an item in the listing to use as the anchor point of the slice.</param>
		/// <param name="before">FullnameId of an item in the listing to use as the anchor point of the slice.</param>
		/// <param name="count">The number of items already seen in this listing</param>
		/// <param name="limit">The maximum number of items to return in this slice of the listing.</param>
		public newListings(VariableReference<string> after = default(VariableReference<string>), VariableReference<string> before = default(VariableReference<string>), VariableReference<int> count = default(VariableReference<int>), VariableReference<int> limit = default(VariableReference<int>), Meta _Meta = null) {
			_after = after;
			_after.Type = "String";
			_before = before;
			_before.Type = "String";
			_count = count;
			_count.Type = "Int";
			_limit = limit;
			_limit.Type = "Int";
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("newListings", _meta);
			bool hasParameters = false;
			if (_after.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("after: ");
				writer.WriteValue(_after);
			}
			if (_before.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("before: ");
				writer.WriteValue(_before);
			}
			if (_count.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("count: ");
				writer.WriteValue(_count);
			}
			if (_limit.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("limit: ");
				writer.WriteValue(_limit);
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
			if (_after.Key != null) variables[_after.Key] = _after;
			if (_before.Key != null) variables[_before.Key] = _before;
			if (_count.Key != null) variables[_count.Key] = _count;
			if (_limit.Key != null) variables[_limit.Key] = _limit;
			foreach (var child in _children) {
				child.GetVariables(variables);
			}
		}
	}
	public class risingListings : IEnumerable<RedditLink_IChild>, RedditSubreddit_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.RedditLink).MakeArrayType(); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly VariableReference<string> _after;
		private readonly VariableReference<string> _before;
		private readonly VariableReference<int> _count;
		private readonly VariableReference<int> _limit;
		private readonly List<RedditLink_IChild> _children = new List<RedditLink_IChild>();
		public void Add(RedditLink_IChild child) { _children.Add(child); }
		public IEnumerator<RedditLink_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <summary>
		/// Rising listings of the subreddit
		/// </summary>
		/// <param name="after">FullnameId of an item in the listing to use as the anchor point of the slice.</param>
		/// <param name="before">FullnameId of an item in the listing to use as the anchor point of the slice.</param>
		/// <param name="count">The number of items already seen in this listing</param>
		/// <param name="limit">The maximum number of items to return in this slice of the listing.</param>
		public risingListings(VariableReference<string> after = default(VariableReference<string>), VariableReference<string> before = default(VariableReference<string>), VariableReference<int> count = default(VariableReference<int>), VariableReference<int> limit = default(VariableReference<int>), Meta _Meta = null) {
			_after = after;
			_after.Type = "String";
			_before = before;
			_before.Type = "String";
			_count = count;
			_count.Type = "Int";
			_limit = limit;
			_limit.Type = "Int";
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("risingListings", _meta);
			bool hasParameters = false;
			if (_after.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("after: ");
				writer.WriteValue(_after);
			}
			if (_before.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("before: ");
				writer.WriteValue(_before);
			}
			if (_count.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("count: ");
				writer.WriteValue(_count);
			}
			if (_limit.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("limit: ");
				writer.WriteValue(_limit);
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
			if (_after.Key != null) variables[_after.Key] = _after;
			if (_before.Key != null) variables[_before.Key] = _before;
			if (_count.Key != null) variables[_count.Key] = _count;
			if (_limit.Key != null) variables[_limit.Key] = _limit;
			foreach (var child in _children) {
				child.GetVariables(variables);
			}
		}
	}
	public class controversialListings : IEnumerable<RedditLink_IChild>, RedditSubreddit_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.RedditLink).MakeArrayType(); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly VariableReference<string> _after;
		private readonly VariableReference<string> _before;
		private readonly VariableReference<int> _count;
		private readonly VariableReference<int> _limit;
		private readonly VariableReference<Sample.GraphQLHub.R.TimeInterval> _timeInterval;
		private readonly List<RedditLink_IChild> _children = new List<RedditLink_IChild>();
		public void Add(RedditLink_IChild child) { _children.Add(child); }
		public IEnumerator<RedditLink_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <summary>
		/// Controversial listings of the subreddit
		/// </summary>
		/// <param name="after">FullnameId of an item in the listing to use as the anchor point of the slice.</param>
		/// <param name="before">FullnameId of an item in the listing to use as the anchor point of the slice.</param>
		/// <param name="count">The number of items already seen in this listing</param>
		/// <param name="limit">The maximum number of items to return in this slice of the listing.</param>
		/// <param name="timeInterval">Time interval to retrieve listings</param>
		public controversialListings(VariableReference<string> after = default(VariableReference<string>), VariableReference<string> before = default(VariableReference<string>), VariableReference<int> count = default(VariableReference<int>), VariableReference<int> limit = default(VariableReference<int>), VariableReference<Sample.GraphQLHub.R.TimeInterval> timeInterval = default(VariableReference<Sample.GraphQLHub.R.TimeInterval>), Meta _Meta = null) {
			_after = after;
			_after.Type = "String";
			_before = before;
			_before.Type = "String";
			_count = count;
			_count.Type = "Int";
			_limit = limit;
			_limit.Type = "Int";
			_timeInterval = timeInterval;
			_timeInterval.Type = "TimeInterval";
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("controversialListings", _meta);
			bool hasParameters = false;
			if (_after.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("after: ");
				writer.WriteValue(_after);
			}
			if (_before.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("before: ");
				writer.WriteValue(_before);
			}
			if (_count.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("count: ");
				writer.WriteValue(_count);
			}
			if (_limit.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("limit: ");
				writer.WriteValue(_limit);
			}
			if (_timeInterval.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("timeInterval: ");
				writer.WriteEnumValue(_timeInterval);
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
			if (_after.Key != null) variables[_after.Key] = _after;
			if (_before.Key != null) variables[_before.Key] = _before;
			if (_count.Key != null) variables[_count.Key] = _count;
			if (_limit.Key != null) variables[_limit.Key] = _limit;
			if (_timeInterval.Key != null) variables[_timeInterval.Key] = _timeInterval;
			foreach (var child in _children) {
				child.GetVariables(variables);
			}
		}
	}
	public class topListings : IEnumerable<RedditLink_IChild>, RedditSubreddit_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.RedditLink).MakeArrayType(); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly VariableReference<string> _after;
		private readonly VariableReference<string> _before;
		private readonly VariableReference<int> _count;
		private readonly VariableReference<int> _limit;
		private readonly VariableReference<Sample.GraphQLHub.R.TimeInterval> _timeInterval;
		private readonly List<RedditLink_IChild> _children = new List<RedditLink_IChild>();
		public void Add(RedditLink_IChild child) { _children.Add(child); }
		public IEnumerator<RedditLink_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <summary>
		/// Top listings of the subreddit
		/// </summary>
		/// <param name="after">FullnameId of an item in the listing to use as the anchor point of the slice.</param>
		/// <param name="before">FullnameId of an item in the listing to use as the anchor point of the slice.</param>
		/// <param name="count">The number of items already seen in this listing</param>
		/// <param name="limit">The maximum number of items to return in this slice of the listing.</param>
		/// <param name="timeInterval">Time interval to retrieve listings</param>
		public topListings(VariableReference<string> after = default(VariableReference<string>), VariableReference<string> before = default(VariableReference<string>), VariableReference<int> count = default(VariableReference<int>), VariableReference<int> limit = default(VariableReference<int>), VariableReference<Sample.GraphQLHub.R.TimeInterval> timeInterval = default(VariableReference<Sample.GraphQLHub.R.TimeInterval>), Meta _Meta = null) {
			_after = after;
			_after.Type = "String";
			_before = before;
			_before.Type = "String";
			_count = count;
			_count.Type = "Int";
			_limit = limit;
			_limit.Type = "Int";
			_timeInterval = timeInterval;
			_timeInterval.Type = "TimeInterval";
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("topListings", _meta);
			bool hasParameters = false;
			if (_after.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("after: ");
				writer.WriteValue(_after);
			}
			if (_before.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("before: ");
				writer.WriteValue(_before);
			}
			if (_count.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("count: ");
				writer.WriteValue(_count);
			}
			if (_limit.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("limit: ");
				writer.WriteValue(_limit);
			}
			if (_timeInterval.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("timeInterval: ");
				writer.WriteEnumValue(_timeInterval);
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
			if (_after.Key != null) variables[_after.Key] = _after;
			if (_before.Key != null) variables[_before.Key] = _before;
			if (_count.Key != null) variables[_count.Key] = _count;
			if (_limit.Key != null) variables[_limit.Key] = _limit;
			if (_timeInterval.Key != null) variables[_timeInterval.Key] = _timeInterval;
			foreach (var child in _children) {
				child.GetVariables(variables);
			}
		}
	}
	public class RedditLink_title : RedditLink_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		/// <summary>
		/// Title of the link
		/// </summary>
		public RedditLink_title(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("title", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class RedditLink_score : RedditLink_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(int); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		/// <summary>
		/// Score of the link
		/// </summary>
		public RedditLink_score(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("score", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class numComments : RedditLink_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(int); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		/// <summary>
		/// Number of comments
		/// </summary>
		public numComments(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("numComments", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class RedditLink_url : RedditLink_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		/// <summary>
		/// URL of the link
		/// </summary>
		public RedditLink_url(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("url", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class author : IEnumerable<RedditUser_IChild>, RedditLink_IChild, RedditComment_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.RedditUser); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<RedditUser_IChild> _children = new List<RedditUser_IChild>();
		public void Add(RedditUser_IChild child) { _children.Add(child); }
		public IEnumerator<RedditUser_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <summary>
		/// Author of the comment
		/// </summary>
		public author(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("author", _meta);
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
	public class comments : IEnumerable<RedditComment_IChild>, RedditLink_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.RedditComment).MakeArrayType(); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly VariableReference<int> _depth;
		private readonly VariableReference<int> _limit;
		private readonly List<RedditComment_IChild> _children = new List<RedditComment_IChild>();
		public void Add(RedditComment_IChild child) { _children.Add(child); }
		public IEnumerator<RedditComment_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <summary>
		/// Comments on the link
		/// </summary>
		/// <param name="depth">Maximum depth of subtrees in the thread</param>
		/// <param name="limit">Maximum number of comments to return</param>
		public comments(VariableReference<int> depth = default(VariableReference<int>), VariableReference<int> limit = default(VariableReference<int>), Meta _Meta = null) {
			_depth = depth;
			_depth.Type = "Int";
			_limit = limit;
			_limit.Type = "Int";
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("comments", _meta);
			bool hasParameters = false;
			if (_depth.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("depth: ");
				writer.WriteValue(_depth);
			}
			if (_limit.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("limit: ");
				writer.WriteValue(_limit);
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
			if (_depth.Key != null) variables[_depth.Key] = _depth;
			if (_limit.Key != null) variables[_limit.Key] = _limit;
			foreach (var child in _children) {
				child.GetVariables(variables);
			}
		}
	}
	public class username : RedditUser_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		/// <summary>
		/// The user's unique username.
		/// </summary>
		public username(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("username", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class RedditUser_created : RedditUser_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(float); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		/// <summary>
		/// Creation date of the user, in Unix Time (UTC)
		/// </summary>
		public RedditUser_created(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("created", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class linkKarma : RedditUser_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(int); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		/// <summary>
		/// Karma by links of the user
		/// </summary>
		public linkKarma(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("linkKarma", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class commentKarma : RedditUser_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(int); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		/// <summary>
		/// Karma by comments of the user
		/// </summary>
		public commentKarma(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("commentKarma", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class body : RedditComment_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		/// <summary>
		/// Body of the comment
		/// </summary>
		public body(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("body", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class replies : IEnumerable<RedditComment_IChild>, RedditComment_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.RedditComment).MakeArrayType(); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly VariableReference<int> _depth;
		private readonly VariableReference<int> _limit;
		private readonly List<RedditComment_IChild> _children = new List<RedditComment_IChild>();
		public void Add(RedditComment_IChild child) { _children.Add(child); }
		public IEnumerator<RedditComment_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <summary>
		/// Replies to the comment
		/// </summary>
		/// <param name="depth">Maximum depth of subtrees in the thread</param>
		/// <param name="limit">Maximum number of comments to return</param>
		public replies(VariableReference<int> depth = default(VariableReference<int>), VariableReference<int> limit = default(VariableReference<int>), Meta _Meta = null) {
			_depth = depth;
			_depth.Type = "Int";
			_limit = limit;
			_limit.Type = "Int";
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("replies", _meta);
			bool hasParameters = false;
			if (_depth.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("depth: ");
				writer.WriteValue(_depth);
			}
			if (_limit.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("limit: ");
				writer.WriteValue(_limit);
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
			if (_depth.Key != null) variables[_depth.Key] = _depth;
			if (_limit.Key != null) variables[_limit.Key] = _limit;
			foreach (var child in _children) {
				child.GetVariables(variables);
			}
		}
	}
	public class getValue : IEnumerable<KeyValueItem_IChild>, KeyValueAPI_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.KeyValueItem); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly VariableReference<string> _id;
		private readonly List<KeyValueItem_IChild> _children = new List<KeyValueItem_IChild>();
		public void Add(KeyValueItem_IChild child) { _children.Add(child); }
		public IEnumerator<KeyValueItem_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <param name="id">id of the item</param>
		public getValue(VariableReference<string> id = default(VariableReference<string>), Meta _Meta = null) {
			_id = id;
			_id.Type = "String!";
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("getValue", _meta);
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
	public class value : KeyValueItem_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		/// <summary>
		/// The item's value.
		/// </summary>
		public value(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("value", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class GithubAPI_user : IEnumerable<GithubUser_IChild>, GithubAPI_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GithubUser); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly VariableReference<string> _username;
		private readonly List<GithubUser_IChild> _children = new List<GithubUser_IChild>();
		public void Add(GithubUser_IChild child) { _children.Add(child); }
		public IEnumerator<GithubUser_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <param name="username">Username of the user</param>
		public GithubAPI_user(VariableReference<string> username = default(VariableReference<string>), Meta _Meta = null) {
			_username = username;
			_username.Type = "String!";
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("user", _meta);
			bool hasParameters = false;
			if (_username.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("username: ");
				writer.WriteValue(_username);
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
			if (_username.Key != null) variables[_username.Key] = _username;
			foreach (var child in _children) {
				child.GetVariables(variables);
			}
		}
	}
	public class repo : IEnumerable<GithubRepo_IChild>, GithubAPI_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GithubRepo); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly VariableReference<string> _name;
		private readonly VariableReference<string> _ownerUsername;
		private readonly List<GithubRepo_IChild> _children = new List<GithubRepo_IChild>();
		public void Add(GithubRepo_IChild child) { _children.Add(child); }
		public IEnumerator<GithubRepo_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <param name="name">Name of the repo</param>
		/// <param name="ownerUsername">Username of the owner</param>
		public repo(VariableReference<string> name = default(VariableReference<string>), VariableReference<string> ownerUsername = default(VariableReference<string>), Meta _Meta = null) {
			_name = name;
			_name.Type = "String!";
			_ownerUsername = ownerUsername;
			_ownerUsername.Type = "String!";
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("repo", _meta);
			bool hasParameters = false;
			if (_name.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("name: ");
				writer.WriteValue(_name);
			}
			if (_ownerUsername.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("ownerUsername: ");
				writer.WriteValue(_ownerUsername);
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
			if (_name.Key != null) variables[_name.Key] = _name;
			if (_ownerUsername.Key != null) variables[_ownerUsername.Key] = _ownerUsername;
			foreach (var child in _children) {
				child.GetVariables(variables);
			}
		}
	}
	public class login : GithubUser_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public login(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("login", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class GithubUser_id : GithubUser_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(int); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public GithubUser_id(Meta _Meta = null) {
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
	public class company : GithubUser_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public company(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("company", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class avatar_url : GithubUser_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public avatar_url(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("avatar_url", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class repos : IEnumerable<GithubRepo_IChild>, GithubUser_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GithubRepo).MakeArrayType(); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GithubRepo_IChild> _children = new List<GithubRepo_IChild>();
		public void Add(GithubRepo_IChild child) { _children.Add(child); }
		public IEnumerator<GithubRepo_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public repos(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("repos", _meta);
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
	public class GithubRepo_id : GithubRepo_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(int); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public GithubRepo_id(Meta _Meta = null) {
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
	public class GithubRepo_name : GithubRepo_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public GithubRepo_name(Meta _Meta = null) {
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
	public class commits : IEnumerable<GithubCommit_IChild>, GithubRepo_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GithubCommit).MakeArrayType(); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly VariableReference<int> _limit;
		private readonly List<GithubCommit_IChild> _children = new List<GithubCommit_IChild>();
		public void Add(GithubCommit_IChild child) { _children.Add(child); }
		public IEnumerator<GithubCommit_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public commits(VariableReference<int> limit = default(VariableReference<int>), Meta _Meta = null) {
			_limit = limit;
			_limit.Type = "Int";
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("commits", _meta);
			bool hasParameters = false;
			if (_limit.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("limit: ");
				writer.WriteValue(_limit);
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
			if (_limit.Key != null) variables[_limit.Key] = _limit;
			foreach (var child in _children) {
				child.GetVariables(variables);
			}
		}
	}
	public class issues : IEnumerable<GithubIssue_IChild>, GithubRepo_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GithubIssue).MakeArrayType(); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly VariableReference<int> _limit;
		private readonly List<GithubIssue_IChild> _children = new List<GithubIssue_IChild>();
		public void Add(GithubIssue_IChild child) { _children.Add(child); }
		public IEnumerator<GithubIssue_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public issues(VariableReference<int> limit = default(VariableReference<int>), Meta _Meta = null) {
			_limit = limit;
			_limit.Type = "Int";
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("issues", _meta);
			bool hasParameters = false;
			if (_limit.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("limit: ");
				writer.WriteValue(_limit);
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
			if (_limit.Key != null) variables[_limit.Key] = _limit;
			foreach (var child in _children) {
				child.GetVariables(variables);
			}
		}
	}
	public class branches : IEnumerable<GithubBranch_IChild>, GithubRepo_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GithubBranch).MakeArrayType(); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly VariableReference<int> _limit;
		private readonly List<GithubBranch_IChild> _children = new List<GithubBranch_IChild>();
		public void Add(GithubBranch_IChild child) { _children.Add(child); }
		public IEnumerator<GithubBranch_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public branches(VariableReference<int> limit = default(VariableReference<int>), Meta _Meta = null) {
			_limit = limit;
			_limit.Type = "Int";
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("branches", _meta);
			bool hasParameters = false;
			if (_limit.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("limit: ");
				writer.WriteValue(_limit);
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
			if (_limit.Key != null) variables[_limit.Key] = _limit;
			foreach (var child in _children) {
				child.GetVariables(variables);
			}
		}
	}
	public class owner : IEnumerable<GithubUser_IChild>, GithubRepo_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GithubUser); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GithubUser_IChild> _children = new List<GithubUser_IChild>();
		public void Add(GithubUser_IChild child) { _children.Add(child); }
		public IEnumerator<GithubUser_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public owner(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("owner", _meta);
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
	public class sha : GithubCommit_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public sha(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("sha", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class GithubCommit_author : GithubCommit_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.UserOrCommitAuthor); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public GithubCommit_author(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("author", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class message : GithubCommit_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public message(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("message", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class date : GithubCommit_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public date(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("date", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class status : IEnumerable<GithubStatus_IChild>, GithubCommit_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GithubStatus).MakeArrayType(); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GithubStatus_IChild> _children = new List<GithubStatus_IChild>();
		public void Add(GithubStatus_IChild child) { _children.Add(child); }
		public IEnumerator<GithubStatus_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public status(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("status", _meta);
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
	public class tree : IEnumerable<GithubTree_IChild>, GithubCommit_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GithubTree); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GithubTree_IChild> _children = new List<GithubTree_IChild>();
		public void Add(GithubTree_IChild child) { _children.Add(child); }
		public IEnumerator<GithubTree_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public tree(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("tree", _meta);
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
	public class email : GithubCommitAuthor_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public email(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("email", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class GithubCommitAuthor_name : GithubCommitAuthor_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public GithubCommitAuthor_name(Meta _Meta = null) {
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
	public class state : GithubStatus_IChild, GithubIssue_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public state(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("state", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class description : GithubStatus_IChild, TwitterUser_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public description(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("description", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class target_url : GithubStatus_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public target_url(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("target_url", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class context : GithubStatus_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public context(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("context", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class updated_at : GithubStatus_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public updated_at(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("updated_at", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class entries : IEnumerable<GithubTreeEntry_IChild>, GithubTree_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GithubTreeEntry).MakeArrayType(); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GithubTreeEntry_IChild> _children = new List<GithubTreeEntry_IChild>();
		public void Add(GithubTreeEntry_IChild child) { _children.Add(child); }
		public IEnumerator<GithubTreeEntry_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public entries(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("entries", _meta);
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
	public class path : GithubTreeEntry_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public path(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("path", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class last_commit : IEnumerable<GithubCommit_IChild>, GithubTreeEntry_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GithubCommit); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GithubCommit_IChild> _children = new List<GithubCommit_IChild>();
		public void Add(GithubCommit_IChild child) { _children.Add(child); }
		public IEnumerator<GithubCommit_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public last_commit(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("last_commit", _meta);
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
	public class GithubIssue_id : GithubIssue_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(int); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public GithubIssue_id(Meta _Meta = null) {
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
	public class GithubIssue_body : GithubIssue_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public GithubIssue_body(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("body", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class GithubIssue_user : IEnumerable<GithubUser_IChild>, GithubIssue_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GithubUser); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GithubUser_IChild> _children = new List<GithubUser_IChild>();
		public void Add(GithubUser_IChild child) { _children.Add(child); }
		public IEnumerator<GithubUser_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public GithubIssue_user(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("user", _meta);
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
	public class assignee : IEnumerable<GithubUser_IChild>, GithubIssue_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GithubUser); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GithubUser_IChild> _children = new List<GithubUser_IChild>();
		public void Add(GithubUser_IChild child) { _children.Add(child); }
		public IEnumerator<GithubUser_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public assignee(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("assignee", _meta);
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
	public class closed_by : IEnumerable<GithubUser_IChild>, GithubIssue_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GithubUser); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GithubUser_IChild> _children = new List<GithubUser_IChild>();
		public void Add(GithubUser_IChild child) { _children.Add(child); }
		public IEnumerator<GithubUser_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public closed_by(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("closed_by", _meta);
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
	public class labels : IEnumerable<GithubIssueLabelType_IChild>, GithubIssue_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GithubIssueLabelType).MakeArrayType(); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GithubIssueLabelType_IChild> _children = new List<GithubIssueLabelType_IChild>();
		public void Add(GithubIssueLabelType_IChild child) { _children.Add(child); }
		public IEnumerator<GithubIssueLabelType_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public labels(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("labels", _meta);
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
	public class commentCount : GithubIssue_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(int); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public commentCount(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("commentCount", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class GithubIssue_comments : IEnumerable<GithubIssueCommentType_IChild>, GithubIssue_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GithubIssueCommentType).MakeArrayType(); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GithubIssueCommentType_IChild> _children = new List<GithubIssueCommentType_IChild>();
		public void Add(GithubIssueCommentType_IChild child) { _children.Add(child); }
		public IEnumerator<GithubIssueCommentType_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public GithubIssue_comments(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("comments", _meta);
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
	public class GithubIssueLabelType_name : GithubIssueLabelType_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public GithubIssueLabelType_name(Meta _Meta = null) {
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
	public class color : GithubIssueLabelType_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public color(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("color", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class GithubIssueCommentType_id : GithubIssueCommentType_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(int); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public GithubIssueCommentType_id(Meta _Meta = null) {
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
	public class GithubIssueCommentType_body : GithubIssueCommentType_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public GithubIssueCommentType_body(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("body", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class GithubIssueCommentType_user : IEnumerable<GithubUser_IChild>, GithubIssueCommentType_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GithubUser); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GithubUser_IChild> _children = new List<GithubUser_IChild>();
		public void Add(GithubUser_IChild child) { _children.Add(child); }
		public IEnumerator<GithubUser_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public GithubIssueCommentType_user(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("user", _meta);
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
	public class GithubBranch_name : GithubBranch_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public GithubBranch_name(Meta _Meta = null) {
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
	public class lastCommit : IEnumerable<GithubCommit_IChild>, GithubBranch_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GithubCommit); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GithubCommit_IChild> _children = new List<GithubCommit_IChild>();
		public void Add(GithubCommit_IChild child) { _children.Add(child); }
		public IEnumerator<GithubCommit_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public lastCommit(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("lastCommit", _meta);
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
	public class TwitterAPI_user : IEnumerable<TwitterUser_IChild>, TwitterAPI_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.TwitterUser); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly VariableReference<Sample.GraphQLHub.R.UserIdentifier> _identifier;
		private readonly VariableReference<string> _identity;
		private readonly List<TwitterUser_IChild> _children = new List<TwitterUser_IChild>();
		public void Add(TwitterUser_IChild child) { _children.Add(child); }
		public IEnumerator<TwitterUser_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <param name="identifier">Either user_id or screen_name</param>
		/// <param name="identity">User ID (Integer) or Screen name (String) to identify user</param>
		public TwitterAPI_user(VariableReference<Sample.GraphQLHub.R.UserIdentifier> identifier = default(VariableReference<Sample.GraphQLHub.R.UserIdentifier>), VariableReference<string> identity = default(VariableReference<string>), Meta _Meta = null) {
			_identifier = identifier;
			_identifier.Type = "UserIdentifier!";
			_identity = identity;
			_identity.Type = "UserIdentity!";
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("user", _meta);
			bool hasParameters = false;
			if (_identifier.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("identifier: ");
				writer.WriteEnumValue(_identifier);
			}
			if (_identity.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("identity: ");
				writer.WriteValue(_identity);
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
			if (_identifier.Key != null) variables[_identifier.Key] = _identifier;
			if (_identity.Key != null) variables[_identity.Key] = _identity;
			foreach (var child in _children) {
				child.GetVariables(variables);
			}
		}
	}
	public class tweet : IEnumerable<Tweet_IChild>, TwitterAPI_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.Tweet); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly VariableReference<string> _id;
		private readonly List<Tweet_IChild> _children = new List<Tweet_IChild>();
		public void Add(Tweet_IChild child) { _children.Add(child); }
		public IEnumerator<Tweet_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <param name="id">Unique ID of tweet</param>
		public tweet(VariableReference<string> id = default(VariableReference<string>), Meta _Meta = null) {
			_id = id;
			_id.Type = "String!";
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("tweet", _meta);
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
	public class search : IEnumerable<Tweet_IChild>, TwitterAPI_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.Tweet).MakeArrayType(); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly VariableReference<string> _q;
		private readonly VariableReference<int> _count;
		private readonly VariableReference<Sample.GraphQLHub.R.SearchReponse> _result_type;
		private readonly List<Tweet_IChild> _children = new List<Tweet_IChild>();
		public void Add(Tweet_IChild child) { _children.Add(child); }
		public IEnumerator<Tweet_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <summary>
		/// Returns a collection of relevant Tweets matching a specified query.
		/// </summary>
		/// <param name="q">A UTF-8, URL-encoded search query of 500 characters maximum, including operators. Queries may additionally be limited by complexity.</param>
		/// <param name="count">The number of tweets to return per page, up to a maximum of 100. This was formerly the â€œrppâ€ parameter in the old Search API.</param>
		/// <param name="result_type">
		/// Specifies what type of search results you would prefer to receive. Valid values include:
		///           * mixed: Include both popular and real time results in the response.
		///           * recent: return only the most recent results in the response
		///           * popular: return only the most popular results in the response.
		/// </param>
		public search(VariableReference<string> q = default(VariableReference<string>), VariableReference<int> count = default(VariableReference<int>), VariableReference<Sample.GraphQLHub.R.SearchReponse> result_type = default(VariableReference<Sample.GraphQLHub.R.SearchReponse>), Meta _Meta = null) {
			_q = q;
			_q.Type = "String!";
			_count = count;
			_count.Type = "Int";
			_result_type = result_type;
			_result_type.Type = "SearchReponse";
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("search", _meta);
			bool hasParameters = false;
			if (_q.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("q: ");
				writer.WriteValue(_q);
			}
			if (_count.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("count: ");
				writer.WriteValue(_count);
			}
			if (_result_type.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("result_type: ");
				writer.WriteEnumValue(_result_type);
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
			if (_q.Key != null) variables[_q.Key] = _q;
			if (_count.Key != null) variables[_count.Key] = _count;
			if (_result_type.Key != null) variables[_result_type.Key] = _result_type;
			foreach (var child in _children) {
				child.GetVariables(variables);
			}
		}
	}
	public class created_at : TwitterUser_IChild, Tweet_IChild, Retweet_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public created_at(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("created_at", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class TwitterUser_id : TwitterUser_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public TwitterUser_id(Meta _Meta = null) {
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
	public class screen_name : TwitterUser_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public screen_name(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("screen_name", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class TwitterUser_name : TwitterUser_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public TwitterUser_name(Meta _Meta = null) {
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
	public class profile_image_url : TwitterUser_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public profile_image_url(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("profile_image_url", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class tweets_count : TwitterUser_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(int); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public tweets_count(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("tweets_count", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class followers_count : TwitterUser_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(int); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public followers_count(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("followers_count", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class tweets : IEnumerable<Tweet_IChild>, TwitterUser_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.Tweet).MakeArrayType(); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly VariableReference<int> _limit;
		private readonly List<Tweet_IChild> _children = new List<Tweet_IChild>();
		public void Add(Tweet_IChild child) { _children.Add(child); }
		public IEnumerator<Tweet_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <summary>
		/// Get a list of tweets for current user
		/// </summary>
		public tweets(VariableReference<int> limit = default(VariableReference<int>), Meta _Meta = null) {
			_limit = limit;
			_limit.Type = "Int";
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("tweets", _meta);
			bool hasParameters = false;
			if (_limit.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("limit: ");
				writer.WriteValue(_limit);
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
			if (_limit.Key != null) variables[_limit.Key] = _limit;
			foreach (var child in _children) {
				child.GetVariables(variables);
			}
		}
	}
	public class Tweet_id : Tweet_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public Tweet_id(Meta _Meta = null) {
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
	public class retweet_count : Tweet_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(int); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public retweet_count(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("retweet_count", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class Tweet_user : IEnumerable<TwitterUser_IChild>, Tweet_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.TwitterUser); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<TwitterUser_IChild> _children = new List<TwitterUser_IChild>();
		public void Add(TwitterUser_IChild child) { _children.Add(child); }
		public IEnumerator<TwitterUser_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public Tweet_user(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("user", _meta);
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
	public class retweets : IEnumerable<Retweet_IChild>, Tweet_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.Retweet).MakeArrayType(); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly VariableReference<int> _limit;
		private readonly List<Retweet_IChild> _children = new List<Retweet_IChild>();
		public void Add(Retweet_IChild child) { _children.Add(child); }
		public IEnumerator<Retweet_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <summary>
		/// Get a list of retweets
		/// </summary>
		public retweets(VariableReference<int> limit = default(VariableReference<int>), Meta _Meta = null) {
			_limit = limit;
			_limit.Type = "Int";
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("retweets", _meta);
			bool hasParameters = false;
			if (_limit.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("limit: ");
				writer.WriteValue(_limit);
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
			if (_limit.Key != null) variables[_limit.Key] = _limit;
			foreach (var child in _children) {
				child.GetVariables(variables);
			}
		}
	}
	public class Retweet_id : Retweet_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public Retweet_id(Meta _Meta = null) {
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
	public class in_reply_to_tweet_id : Retweet_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public in_reply_to_tweet_id(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("in_reply_to_tweet_id", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class in_reply_to_user_id : Retweet_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(int); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public in_reply_to_user_id(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("in_reply_to_user_id", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class in_reply_to_screen_name : Retweet_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public in_reply_to_screen_name(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("in_reply_to_screen_name", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class retweeted_status : IEnumerable<Tweet_IChild>, Retweet_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.Tweet); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<Tweet_IChild> _children = new List<Tweet_IChild>();
		public void Add(Tweet_IChild child) { _children.Add(child); }
		public IEnumerator<Tweet_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public retweeted_status(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("retweeted_status", _meta);
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
	public class Retweet_user : IEnumerable<TwitterUser_IChild>, Retweet_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.TwitterUser); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<TwitterUser_IChild> _children = new List<TwitterUser_IChild>();
		public void Add(TwitterUser_IChild child) { _children.Add(child); }
		public IEnumerator<TwitterUser_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public Retweet_user(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("user", _meta);
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
	public class gif : IEnumerable<GiphyGIFData_IChild>, GiphyAPI_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GiphyGIFData); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly VariableReference<string> _id;
		private readonly List<GiphyGIFData_IChild> _children = new List<GiphyGIFData_IChild>();
		public void Add(GiphyGIFData_IChild child) { _children.Add(child); }
		public IEnumerator<GiphyGIFData_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <param name="id">id of the item</param>
		public gif(VariableReference<string> id = default(VariableReference<string>), Meta _Meta = null) {
			_id = id;
			_id.Type = "String!";
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("gif", _meta);
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
	public class GiphyAPI_search : IEnumerable<GiphyGIFData_IChild>, GiphyAPI_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GiphyGIFData).MakeArrayType(); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly VariableReference<string> _query;
		private readonly VariableReference<int> _limit;
		private readonly VariableReference<int> _offset;
		private readonly VariableReference<Sample.GraphQLHub.R.GiphyRatingType> _rating;
		private readonly List<GiphyGIFData_IChild> _children = new List<GiphyGIFData_IChild>();
		public void Add(GiphyGIFData_IChild child) { _children.Add(child); }
		public IEnumerator<GiphyGIFData_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <param name="query">Search query or phrase</param>
		public GiphyAPI_search(VariableReference<string> query = default(VariableReference<string>), VariableReference<int> limit = default(VariableReference<int>), VariableReference<int> offset = default(VariableReference<int>), VariableReference<Sample.GraphQLHub.R.GiphyRatingType> rating = default(VariableReference<Sample.GraphQLHub.R.GiphyRatingType>), Meta _Meta = null) {
			_query = query;
			_query.Type = "String!";
			_limit = limit;
			_limit.Type = "Int";
			_offset = offset;
			_offset.Type = "Int";
			_rating = rating;
			_rating.Type = "GiphyRatingType";
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("search", _meta);
			bool hasParameters = false;
			if (_query.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("query: ");
				writer.WriteValue(_query);
			}
			if (_limit.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("limit: ");
				writer.WriteValue(_limit);
			}
			if (_offset.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("offset: ");
				writer.WriteValue(_offset);
			}
			if (_rating.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("rating: ");
				writer.WriteEnumValue(_rating);
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
			if (_query.Key != null) variables[_query.Key] = _query;
			if (_limit.Key != null) variables[_limit.Key] = _limit;
			if (_offset.Key != null) variables[_offset.Key] = _offset;
			if (_rating.Key != null) variables[_rating.Key] = _rating;
			foreach (var child in _children) {
				child.GetVariables(variables);
			}
		}
	}
	public class random : IEnumerable<GiphyGIFData_IChild>, GiphyAPI_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GiphyGIFData); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly VariableReference<string> _tag;
		private readonly VariableReference<Sample.GraphQLHub.R.GiphyRatingType> _rating;
		private readonly List<GiphyGIFData_IChild> _children = new List<GiphyGIFData_IChild>();
		public void Add(GiphyGIFData_IChild child) { _children.Add(child); }
		public IEnumerator<GiphyGIFData_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		/// <param name="tag">the GIF tag to limit randomness by</param>
		public random(VariableReference<string> tag = default(VariableReference<string>), VariableReference<Sample.GraphQLHub.R.GiphyRatingType> rating = default(VariableReference<Sample.GraphQLHub.R.GiphyRatingType>), Meta _Meta = null) {
			_tag = tag;
			_tag.Type = "String";
			_rating = rating;
			_rating.Type = "GiphyRatingType";
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("random", _meta);
			bool hasParameters = false;
			if (_tag.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("tag: ");
				writer.WriteValue(_tag);
			}
			if (_rating.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("rating: ");
				writer.WriteEnumValue(_rating);
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
			if (_tag.Key != null) variables[_tag.Key] = _tag;
			if (_rating.Key != null) variables[_rating.Key] = _rating;
			foreach (var child in _children) {
				child.GetVariables(variables);
			}
		}
	}
	public class GiphyGIFData_url : GiphyGIFData_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public GiphyGIFData_url(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("url", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class images : IEnumerable<GiphyGIFImages_IChild>, GiphyGIFData_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GiphyGIFImages); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GiphyGIFImages_IChild> _children = new List<GiphyGIFImages_IChild>();
		public void Add(GiphyGIFImages_IChild child) { _children.Add(child); }
		public IEnumerator<GiphyGIFImages_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public images(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("images", _meta);
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
	public class fixed_height : IEnumerable<GiphyGIFImageDataFixedHeight_IChild>, GiphyGIFImages_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GiphyGIFImageDataFixedHeight); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GiphyGIFImageDataFixedHeight_IChild> _children = new List<GiphyGIFImageDataFixedHeight_IChild>();
		public void Add(GiphyGIFImageDataFixedHeight_IChild child) { _children.Add(child); }
		public IEnumerator<GiphyGIFImageDataFixedHeight_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public fixed_height(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("fixed_height", _meta);
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
	public class fixed_height_still : IEnumerable<GiphyGIFImageDataFixedHeightStill_IChild>, GiphyGIFImages_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GiphyGIFImageDataFixedHeightStill); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GiphyGIFImageDataFixedHeightStill_IChild> _children = new List<GiphyGIFImageDataFixedHeightStill_IChild>();
		public void Add(GiphyGIFImageDataFixedHeightStill_IChild child) { _children.Add(child); }
		public IEnumerator<GiphyGIFImageDataFixedHeightStill_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public fixed_height_still(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("fixed_height_still", _meta);
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
	public class fixed_height_downsampled : IEnumerable<GiphyGIFImageDataFixedHeightDownsample_IChild>, GiphyGIFImages_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GiphyGIFImageDataFixedHeightDownsample); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GiphyGIFImageDataFixedHeightDownsample_IChild> _children = new List<GiphyGIFImageDataFixedHeightDownsample_IChild>();
		public void Add(GiphyGIFImageDataFixedHeightDownsample_IChild child) { _children.Add(child); }
		public IEnumerator<GiphyGIFImageDataFixedHeightDownsample_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public fixed_height_downsampled(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("fixed_height_downsampled", _meta);
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
	public class fixed_width : IEnumerable<GiphyGIFImageDataFixedWidth_IChild>, GiphyGIFImages_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GiphyGIFImageDataFixedWidth); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GiphyGIFImageDataFixedWidth_IChild> _children = new List<GiphyGIFImageDataFixedWidth_IChild>();
		public void Add(GiphyGIFImageDataFixedWidth_IChild child) { _children.Add(child); }
		public IEnumerator<GiphyGIFImageDataFixedWidth_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public fixed_width(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("fixed_width", _meta);
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
	public class fixed_width_still : IEnumerable<GiphyGIFImageDataFixedWidthStill_IChild>, GiphyGIFImages_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GiphyGIFImageDataFixedWidthStill); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GiphyGIFImageDataFixedWidthStill_IChild> _children = new List<GiphyGIFImageDataFixedWidthStill_IChild>();
		public void Add(GiphyGIFImageDataFixedWidthStill_IChild child) { _children.Add(child); }
		public IEnumerator<GiphyGIFImageDataFixedWidthStill_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public fixed_width_still(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("fixed_width_still", _meta);
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
	public class fixed_width_downsampled : IEnumerable<GiphyGIFImageDataFixedWidthDownsample_IChild>, GiphyGIFImages_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GiphyGIFImageDataFixedWidthDownsample); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GiphyGIFImageDataFixedWidthDownsample_IChild> _children = new List<GiphyGIFImageDataFixedWidthDownsample_IChild>();
		public void Add(GiphyGIFImageDataFixedWidthDownsample_IChild child) { _children.Add(child); }
		public IEnumerator<GiphyGIFImageDataFixedWidthDownsample_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public fixed_width_downsampled(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("fixed_width_downsampled", _meta);
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
	public class fixed_height_small : IEnumerable<GiphyGIFImageDataFixedHeightSmall_IChild>, GiphyGIFImages_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GiphyGIFImageDataFixedHeightSmall); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GiphyGIFImageDataFixedHeightSmall_IChild> _children = new List<GiphyGIFImageDataFixedHeightSmall_IChild>();
		public void Add(GiphyGIFImageDataFixedHeightSmall_IChild child) { _children.Add(child); }
		public IEnumerator<GiphyGIFImageDataFixedHeightSmall_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public fixed_height_small(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("fixed_height_small", _meta);
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
	public class fixed_height_small_still : IEnumerable<GiphyGIFImageDataFixedHeightSmallStill_IChild>, GiphyGIFImages_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GiphyGIFImageDataFixedHeightSmallStill); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GiphyGIFImageDataFixedHeightSmallStill_IChild> _children = new List<GiphyGIFImageDataFixedHeightSmallStill_IChild>();
		public void Add(GiphyGIFImageDataFixedHeightSmallStill_IChild child) { _children.Add(child); }
		public IEnumerator<GiphyGIFImageDataFixedHeightSmallStill_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public fixed_height_small_still(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("fixed_height_small_still", _meta);
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
	public class fixed_width_small : IEnumerable<GiphyGIFImageDataFixedWidthSmall_IChild>, GiphyGIFImages_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GiphyGIFImageDataFixedWidthSmall); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GiphyGIFImageDataFixedWidthSmall_IChild> _children = new List<GiphyGIFImageDataFixedWidthSmall_IChild>();
		public void Add(GiphyGIFImageDataFixedWidthSmall_IChild child) { _children.Add(child); }
		public IEnumerator<GiphyGIFImageDataFixedWidthSmall_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public fixed_width_small(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("fixed_width_small", _meta);
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
	public class fixed_width_small_still : IEnumerable<GiphyGIFImageDataFixedWidthSmallStill_IChild>, GiphyGIFImages_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GiphyGIFImageDataFixedWidthSmallStill); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GiphyGIFImageDataFixedWidthSmallStill_IChild> _children = new List<GiphyGIFImageDataFixedWidthSmallStill_IChild>();
		public void Add(GiphyGIFImageDataFixedWidthSmallStill_IChild child) { _children.Add(child); }
		public IEnumerator<GiphyGIFImageDataFixedWidthSmallStill_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public fixed_width_small_still(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("fixed_width_small_still", _meta);
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
	public class downsized : IEnumerable<GiphyGIFImageDataDownsized_IChild>, GiphyGIFImages_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GiphyGIFImageDataDownsized); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GiphyGIFImageDataDownsized_IChild> _children = new List<GiphyGIFImageDataDownsized_IChild>();
		public void Add(GiphyGIFImageDataDownsized_IChild child) { _children.Add(child); }
		public IEnumerator<GiphyGIFImageDataDownsized_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public downsized(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("downsized", _meta);
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
	public class downsized_still : IEnumerable<GiphyGIFImageDataDownsizedStill_IChild>, GiphyGIFImages_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GiphyGIFImageDataDownsizedStill); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GiphyGIFImageDataDownsizedStill_IChild> _children = new List<GiphyGIFImageDataDownsizedStill_IChild>();
		public void Add(GiphyGIFImageDataDownsizedStill_IChild child) { _children.Add(child); }
		public IEnumerator<GiphyGIFImageDataDownsizedStill_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public downsized_still(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("downsized_still", _meta);
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
	public class downsized_large : IEnumerable<GiphyGIFImageDataDownsizedLarge_IChild>, GiphyGIFImages_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GiphyGIFImageDataDownsizedLarge); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GiphyGIFImageDataDownsizedLarge_IChild> _children = new List<GiphyGIFImageDataDownsizedLarge_IChild>();
		public void Add(GiphyGIFImageDataDownsizedLarge_IChild child) { _children.Add(child); }
		public IEnumerator<GiphyGIFImageDataDownsizedLarge_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public downsized_large(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("downsized_large", _meta);
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
	public class original : IEnumerable<GiphyGIFImageDataOriginal_IChild>, GiphyGIFImages_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GiphyGIFImageDataOriginal); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GiphyGIFImageDataOriginal_IChild> _children = new List<GiphyGIFImageDataOriginal_IChild>();
		public void Add(GiphyGIFImageDataOriginal_IChild child) { _children.Add(child); }
		public IEnumerator<GiphyGIFImageDataOriginal_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public original(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("original", _meta);
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
	public class original_still : IEnumerable<GiphyGIFImageDataOriginalStill_IChild>, GiphyGIFImages_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GiphyGIFImageDataOriginalStill); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GiphyGIFImageDataOriginalStill_IChild> _children = new List<GiphyGIFImageDataOriginalStill_IChild>();
		public void Add(GiphyGIFImageDataOriginalStill_IChild child) { _children.Add(child); }
		public IEnumerator<GiphyGIFImageDataOriginalStill_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public original_still(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("original_still", _meta);
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
	public class looping : IEnumerable<GiphyGIFImageDataLooping_IChild>, GiphyGIFImages_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.GiphyGIFImageDataLooping); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<GiphyGIFImageDataLooping_IChild> _children = new List<GiphyGIFImageDataLooping_IChild>();
		public void Add(GiphyGIFImageDataLooping_IChild child) { _children.Add(child); }
		public IEnumerator<GiphyGIFImageDataLooping_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public looping(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("looping", _meta);
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
	public class GiphyGIFImageDataFixedHeight_url : GiphyGIFImageDataFixedHeight_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public GiphyGIFImageDataFixedHeight_url(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("url", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class width : GiphyGIFImageDataFixedHeight_IChild, GiphyGIFImageDataFixedHeightStill_IChild, GiphyGIFImageDataFixedHeightDownsample_IChild, GiphyGIFImageDataFixedWidth_IChild, GiphyGIFImageDataFixedWidthStill_IChild, GiphyGIFImageDataFixedWidthDownsample_IChild, GiphyGIFImageDataFixedHeightSmall_IChild, GiphyGIFImageDataFixedHeightSmallStill_IChild, GiphyGIFImageDataFixedWidthSmall_IChild, GiphyGIFImageDataFixedWidthSmallStill_IChild, GiphyGIFImageDataDownsized_IChild, GiphyGIFImageDataDownsizedStill_IChild, GiphyGIFImageDataDownsizedLarge_IChild, GiphyGIFImageDataOriginal_IChild, GiphyGIFImageDataOriginalStill_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public width(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("width", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class height : GiphyGIFImageDataFixedHeight_IChild, GiphyGIFImageDataFixedHeightStill_IChild, GiphyGIFImageDataFixedHeightDownsample_IChild, GiphyGIFImageDataFixedWidth_IChild, GiphyGIFImageDataFixedWidthStill_IChild, GiphyGIFImageDataFixedWidthDownsample_IChild, GiphyGIFImageDataFixedHeightSmall_IChild, GiphyGIFImageDataFixedHeightSmallStill_IChild, GiphyGIFImageDataFixedWidthSmall_IChild, GiphyGIFImageDataFixedWidthSmallStill_IChild, GiphyGIFImageDataDownsized_IChild, GiphyGIFImageDataDownsizedStill_IChild, GiphyGIFImageDataDownsizedLarge_IChild, GiphyGIFImageDataOriginal_IChild, GiphyGIFImageDataOriginalStill_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public height(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("height", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class size : GiphyGIFImageDataFixedHeight_IChild, GiphyGIFImageDataFixedHeightDownsample_IChild, GiphyGIFImageDataFixedWidth_IChild, GiphyGIFImageDataFixedWidthDownsample_IChild, GiphyGIFImageDataFixedHeightSmall_IChild, GiphyGIFImageDataFixedWidthSmall_IChild, GiphyGIFImageDataDownsizedLarge_IChild, GiphyGIFImageDataOriginal_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public size(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("size", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class mp4 : GiphyGIFImageDataFixedHeight_IChild, GiphyGIFImageDataFixedWidth_IChild, GiphyGIFImageDataOriginal_IChild, GiphyGIFImageDataLooping_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public mp4(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("mp4", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class mp4_size : GiphyGIFImageDataFixedHeight_IChild, GiphyGIFImageDataFixedWidth_IChild, GiphyGIFImageDataOriginal_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public mp4_size(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("mp4_size", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class webp : GiphyGIFImageDataFixedHeight_IChild, GiphyGIFImageDataFixedHeightDownsample_IChild, GiphyGIFImageDataFixedWidth_IChild, GiphyGIFImageDataFixedWidthDownsample_IChild, GiphyGIFImageDataFixedHeightSmall_IChild, GiphyGIFImageDataFixedWidthSmall_IChild, GiphyGIFImageDataOriginal_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public webp(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("webp", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class webp_size : GiphyGIFImageDataFixedHeight_IChild, GiphyGIFImageDataFixedHeightDownsample_IChild, GiphyGIFImageDataFixedWidth_IChild, GiphyGIFImageDataFixedWidthDownsample_IChild, GiphyGIFImageDataFixedHeightSmall_IChild, GiphyGIFImageDataFixedWidthSmall_IChild, GiphyGIFImageDataOriginal_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public webp_size(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("webp_size", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class GiphyGIFImageDataFixedHeightStill_url : GiphyGIFImageDataFixedHeightStill_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public GiphyGIFImageDataFixedHeightStill_url(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("url", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class GiphyGIFImageDataFixedHeightDownsample_url : GiphyGIFImageDataFixedHeightDownsample_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public GiphyGIFImageDataFixedHeightDownsample_url(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("url", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class GiphyGIFImageDataFixedWidth_url : GiphyGIFImageDataFixedWidth_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public GiphyGIFImageDataFixedWidth_url(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("url", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class GiphyGIFImageDataFixedWidthStill_url : GiphyGIFImageDataFixedWidthStill_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public GiphyGIFImageDataFixedWidthStill_url(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("url", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class GiphyGIFImageDataFixedWidthDownsample_url : GiphyGIFImageDataFixedWidthDownsample_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public GiphyGIFImageDataFixedWidthDownsample_url(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("url", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class GiphyGIFImageDataFixedHeightSmall_url : GiphyGIFImageDataFixedHeightSmall_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public GiphyGIFImageDataFixedHeightSmall_url(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("url", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class GiphyGIFImageDataFixedHeightSmallStill_url : GiphyGIFImageDataFixedHeightSmallStill_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public GiphyGIFImageDataFixedHeightSmallStill_url(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("url", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class GiphyGIFImageDataFixedWidthSmall_url : GiphyGIFImageDataFixedWidthSmall_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public GiphyGIFImageDataFixedWidthSmall_url(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("url", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class GiphyGIFImageDataFixedWidthSmallStill_url : GiphyGIFImageDataFixedWidthSmallStill_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public GiphyGIFImageDataFixedWidthSmallStill_url(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("url", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class GiphyGIFImageDataDownsized_url : GiphyGIFImageDataDownsized_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public GiphyGIFImageDataDownsized_url(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("url", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class small : GiphyGIFImageDataDownsized_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public small(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("small", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class GiphyGIFImageDataDownsizedStill_url : GiphyGIFImageDataDownsizedStill_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public GiphyGIFImageDataDownsizedStill_url(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("url", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class GiphyGIFImageDataDownsizedLarge_url : GiphyGIFImageDataDownsizedLarge_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public GiphyGIFImageDataDownsizedLarge_url(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("url", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class GiphyGIFImageDataOriginal_url : GiphyGIFImageDataOriginal_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public GiphyGIFImageDataOriginal_url(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("url", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class frames : GiphyGIFImageDataOriginal_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public frames(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("frames", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class GiphyGIFImageDataOriginalStill_url : GiphyGIFImageDataOriginalStill_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public GiphyGIFImageDataOriginalStill_url(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("url", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
	public class keyValue_setValue : IEnumerable<SetValueForKeyPayload_IChild>, GraphQLHubMutationAPI_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.SetValueForKeyPayload); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly VariableReference<SetValueForKeyInput> _input;
		private readonly List<SetValueForKeyPayload_IChild> _children = new List<SetValueForKeyPayload_IChild>();
		public void Add(SetValueForKeyPayload_IChild child) { _children.Add(child); }
		public IEnumerator<SetValueForKeyPayload_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public keyValue_setValue(VariableReference<SetValueForKeyInput> input = default(VariableReference<SetValueForKeyInput>), Meta _Meta = null) {
			_input = input;
			_input.Type = "SetValueForKeyInput!";
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("keyValue_setValue", _meta);
			bool hasParameters = false;
			if (_input.HasValue) {
				if (hasParameters) writer.Write(", ");
				else { hasParameters = true; writer.Write("("); }
				writer.Write("input: ");
				writer.WriteValue(_input);
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
			if (_input.Key != null) variables[_input.Key] = _input;
			foreach (var child in _children) {
				child.GetVariables(variables);
			}
		}
	}
	public class SetValueForKeyPayload_item : IEnumerable<KeyValueItem_IChild>, SetValueForKeyPayload_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(Sample.GraphQLHub.R.KeyValueItem); } }
		public IEnumerable<INode> Children { get { return _children; } }
		public Meta Meta { get { return _meta; } }
		private readonly List<KeyValueItem_IChild> _children = new List<KeyValueItem_IChild>();
		public void Add(KeyValueItem_IChild child) { _children.Add(child); }
		public IEnumerator<KeyValueItem_IChild> GetEnumerator() { return _children.GetEnumerator(); }
		IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
		public SetValueForKeyPayload_item(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("item", _meta);
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
	public class clientMutationId : SetValueForKeyPayload_IChild {
		GraphQL2Net.Support.Meta _meta;
		public System.Type ResultType { get { return typeof(string); } }
		public IEnumerable<INode> Children { get { return new INode[0]; } }
		public Meta Meta { get { return _meta; } }
		public clientMutationId(Meta _Meta = null) {
			_meta = _Meta;
		}
		public void Write(GraphQLWriter writer) {
			writer.Write("clientMutationId", _meta);
			writer.Write(_meta);
			writer.WriteLine("");
		}
		public void GetVariables(Dictionary<string, IVariableReference> variables) {
			if (_meta != null) { _meta.GetVariables(variables); }
		}
	}
}
