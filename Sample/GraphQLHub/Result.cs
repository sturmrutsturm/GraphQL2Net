// Generated Result Text
using GraphQL2Net.Support;
using ObsoleteAttribute = System.ObsoleteAttribute;
using NotImplementedException = System.NotImplementedException;
using IEnumerator = System.Collections.IEnumerator;
using IEnumerable = System.Collections.IEnumerable;
using System.Collections.Generic;

namespace Sample.GraphQLHub.R {
	public class Helper : IHelper {
		public System.Type GetTypeObject(string typename) {
			switch (typename) {
				case "GraphQLHubAPI": return typeof(GraphQLHubAPI);
				case "HackerNewsAPI": return typeof(HackerNewsAPI);
				case "HackerNewsItem": return typeof(HackerNewsItem);
				case "HackerNewsUser": return typeof(HackerNewsUser);
				case "HackerNewsAPIV2": return typeof(HackerNewsAPIV2);
				case "HackerNewsV2Story": return typeof(HackerNewsV2Story);
				case "HackerNewsV2User": return typeof(HackerNewsV2User);
				case "NodeConnection": return typeof(NodeConnection);
				case "PageInfo": return typeof(PageInfo);
				case "NodeEdge": return typeof(NodeEdge);
				case "HackerNewsV2CommentConnection": return typeof(HackerNewsV2CommentConnection);
				case "HackerNewsV2CommentEdge": return typeof(HackerNewsV2CommentEdge);
				case "HackerNewsV2Comment": return typeof(HackerNewsV2Comment);
				case "HackerNewsV2Job": return typeof(HackerNewsV2Job);
				case "HackerNewsV2Poll": return typeof(HackerNewsV2Poll);
				case "HackerNewsV2PollPart": return typeof(HackerNewsV2PollPart);
				case "RedditAPI": return typeof(RedditAPI);
				case "RedditSubreddit": return typeof(RedditSubreddit);
				case "RedditLink": return typeof(RedditLink);
				case "RedditUser": return typeof(RedditUser);
				case "RedditComment": return typeof(RedditComment);
				case "KeyValueAPI": return typeof(KeyValueAPI);
				case "KeyValueItem": return typeof(KeyValueItem);
				case "GithubAPI": return typeof(GithubAPI);
				case "GithubUser": return typeof(GithubUser);
				case "GithubRepo": return typeof(GithubRepo);
				case "GithubCommit": return typeof(GithubCommit);
				case "GithubCommitAuthor": return typeof(GithubCommitAuthor);
				case "GithubStatus": return typeof(GithubStatus);
				case "GithubTree": return typeof(GithubTree);
				case "GithubTreeEntry": return typeof(GithubTreeEntry);
				case "GithubIssue": return typeof(GithubIssue);
				case "GithubIssueLabelType": return typeof(GithubIssueLabelType);
				case "GithubIssueCommentType": return typeof(GithubIssueCommentType);
				case "GithubBranch": return typeof(GithubBranch);
				case "TwitterAPI": return typeof(TwitterAPI);
				case "TwitterUser": return typeof(TwitterUser);
				case "Tweet": return typeof(Tweet);
				case "Retweet": return typeof(Retweet);
				case "GiphyAPI": return typeof(GiphyAPI);
				case "GiphyGIFData": return typeof(GiphyGIFData);
				case "GiphyGIFImages": return typeof(GiphyGIFImages);
				case "GiphyGIFImageDataFixedHeight": return typeof(GiphyGIFImageDataFixedHeight);
				case "GiphyGIFImageDataFixedHeightStill": return typeof(GiphyGIFImageDataFixedHeightStill);
				case "GiphyGIFImageDataFixedHeightDownsample": return typeof(GiphyGIFImageDataFixedHeightDownsample);
				case "GiphyGIFImageDataFixedWidth": return typeof(GiphyGIFImageDataFixedWidth);
				case "GiphyGIFImageDataFixedWidthStill": return typeof(GiphyGIFImageDataFixedWidthStill);
				case "GiphyGIFImageDataFixedWidthDownsample": return typeof(GiphyGIFImageDataFixedWidthDownsample);
				case "GiphyGIFImageDataFixedHeightSmall": return typeof(GiphyGIFImageDataFixedHeightSmall);
				case "GiphyGIFImageDataFixedHeightSmallStill": return typeof(GiphyGIFImageDataFixedHeightSmallStill);
				case "GiphyGIFImageDataFixedWidthSmall": return typeof(GiphyGIFImageDataFixedWidthSmall);
				case "GiphyGIFImageDataFixedWidthSmallStill": return typeof(GiphyGIFImageDataFixedWidthSmallStill);
				case "GiphyGIFImageDataDownsized": return typeof(GiphyGIFImageDataDownsized);
				case "GiphyGIFImageDataDownsizedStill": return typeof(GiphyGIFImageDataDownsizedStill);
				case "GiphyGIFImageDataDownsizedLarge": return typeof(GiphyGIFImageDataDownsizedLarge);
				case "GiphyGIFImageDataOriginal": return typeof(GiphyGIFImageDataOriginal);
				case "GiphyGIFImageDataOriginalStill": return typeof(GiphyGIFImageDataOriginalStill);
				case "GiphyGIFImageDataLooping": return typeof(GiphyGIFImageDataLooping);
				case "GraphQLHubMutationAPI": return typeof(GraphQLHubMutationAPI);
				case "SetValueForKeyPayload": return typeof(SetValueForKeyPayload);
				default: return null;
			}
		}
	}
	public class GraphQLHubAPI : AliasContainer {
		/// <summary>
		/// About GraphQLHub
		/// </summary>
		public string graphQLHub { get; set; }
		public HackerNewsAPI hn { get; set; }
		public HackerNewsAPIV2 hn2 { get; set; }
		public RedditAPI reddit { get; set; }
		public KeyValueAPI keyValue { get; set; }
		public GithubAPI github { get; set; }
		public TwitterAPI twitter { get; set; }
		public GiphyAPI giphy { get; set; }
	}
	public class HackerNewsAPI : AliasContainer {
		public HackerNewsItem item { get; set; }
		public HackerNewsUser user { get; set; }
		/// <summary>
		/// Up to 500 of the top stories
		/// </summary>
		public List<HackerNewsItem> topStories { get; set; }
		/// <summary>
		/// Up to 500 of the newest stories
		/// </summary>
		public List<HackerNewsItem> newStories { get; set; }
		/// <summary>
		/// Up to 200 of the Show HN stories
		/// </summary>
		public List<HackerNewsItem> showStories { get; set; }
		/// <summary>
		/// Up to 200 of the Ask HN stories
		/// </summary>
		public List<HackerNewsItem> askStories { get; set; }
		/// <summary>
		/// Up to 200 of the Job stores
		/// </summary>
		public List<HackerNewsItem> jobStories { get; set; }
		/// <summary>
		/// Return list of stories
		/// </summary>
		public List<HackerNewsItem> stories { get; set; }
	}
	public class HackerNewsItem : AliasContainer {
		/// <summary>
		/// The item's unique id.
		/// </summary>
		public NotNull<string> id { get; set; }
		/// <summary>
		/// if the item is deleted
		/// </summary>
		public bool? deleted { get; set; }
		/// <summary>
		/// The type of item. One of "job", "story", "comment", "poll", or "pollopt".
		/// </summary>
		public ItemType type { get; set; }
		/// <summary>
		/// The item's author.
		/// </summary>
		public HackerNewsUser by { get; set; }
		/// <summary>
		/// Creation date of the item, in Unix Time.
		/// </summary>
		public int time { get; set; }
		/// <summary>
		/// Creation date of the item, in ISO8601
		/// </summary>
		public NotNull<string> timeISO { get; set; }
		/// <summary>
		/// The comment, story or poll text. HTML.
		/// </summary>
		public string text { get; set; }
		/// <summary>
		/// if the item is dead
		/// </summary>
		public bool? dead { get; set; }
		/// <summary>
		/// The URL of the story.
		/// </summary>
		public string url { get; set; }
		/// <summary>
		/// The story's score, or the votes for a pollopt.
		/// </summary>
		public int? score { get; set; }
		/// <summary>
		/// The title of the story, poll or job.
		/// </summary>
		public string title { get; set; }
		/// <summary>
		/// The item's comments, in ranked display order.
		/// </summary>
		public List<HackerNewsItem> kids { get; set; }
		/// <summary>
		/// The item's parent. For comments, either another comment or the relevant story. For pollopts, the relevant poll.
		/// </summary>
		public HackerNewsItem parent { get; set; }
		/// <summary>
		/// A list of related pollopts, in display order.
		/// </summary>
		public List<HackerNewsItem> parts { get; set; }
		/// <summary>
		/// In the case of stories or polls, the total comment count.
		/// </summary>
		public int? descendants { get; set; }
	}
	public enum ItemType {
		job,
		story,
		comment,
		poll,
		pollopt
	}
	public class HackerNewsUser : AliasContainer {
		/// <summary>
		/// The user's unique username. Case-sensitive. Required.
		/// </summary>
		public NotNull<string> id { get; set; }
		/// <summary>
		/// Delay in minutes between a comment's creation and its visibility to other users.
		/// </summary>
		public int delay { get; set; }
		/// <summary>
		/// Creation date of the user, in Unix Time.
		/// </summary>
		public int created { get; set; }
		/// <summary>
		/// Creation date of the user, in ISO8601
		/// </summary>
		public NotNull<string> createdISO { get; set; }
		/// <summary>
		/// The user's optional self-description. HTML.
		/// </summary>
		public string about { get; set; }
		/// <summary>
		/// List of the user's stories, polls and comments.
		/// </summary>
		public List<HackerNewsItem> submitted { get; set; }
	}
	public class HackerNewsAPIV2 : AliasContainer {
		/// <summary>
		/// Fetches an object given its ID
		/// </summary>
		public Node node { get; set; }
		/// <summary>
		/// To ensure Node IDs are globally unique, GraphQLHub coerces IDs returned by the HN API. Use this field to get nodes via normal HN IDs
		/// </summary>
		public Node nodeFromHnId { get; set; }
	}
	public interface Node {
		/// <summary>
		/// The id of the object.
		/// </summary>
		NotNull<string> id{ get; }
	}
	public class HackerNewsV2Story : AliasContainer, Node {
		/// <summary>
		/// The ID of an object
		/// </summary>
		public NotNull<string> id { get; set; }
		/// <summary>
		/// The item's unique id.
		/// </summary>
		public NotNull<string> hnId { get; set; }
		/// <summary>
		/// The item's author.
		/// </summary>
		public HackerNewsV2User by { get; set; }
		/// <summary>
		/// In the case of stories or polls, the total comment count.
		/// </summary>
		public int? descendants { get; set; }
		/// <summary>
		/// The story's score, or the votes for a pollopt.
		/// </summary>
		public int? score { get; set; }
		/// <summary>
		/// Creation date of the item, in Unix Time.
		/// </summary>
		public int time { get; set; }
		/// <summary>
		/// Creation date of the item, in ISO8601
		/// </summary>
		public NotNull<string> timeISO { get; set; }
		/// <summary>
		/// The title of the story, poll or job.
		/// </summary>
		public string title { get; set; }
		/// <summary>
		/// The URL of the story.
		/// </summary>
		public string url { get; set; }
		/// <summary>
		/// The comment, story or poll text. HTML.
		/// </summary>
		public string text { get; set; }
		/// <summary>
		/// The item's comments, in ranked display order.
		/// </summary>
		public HackerNewsV2CommentConnection kids { get; set; }
		/// <summary>
		/// if the item is deleted
		/// </summary>
		public bool? deleted { get; set; }
		/// <summary>
		/// if the item is dead
		/// </summary>
		public bool? dead { get; set; }
	}
	public class HackerNewsV2User : AliasContainer, Node {
		/// <summary>
		/// The ID of an object
		/// </summary>
		public NotNull<string> id { get; set; }
		/// <summary>
		/// The item's unique id.
		/// </summary>
		public NotNull<string> hnId { get; set; }
		/// <summary>
		/// Delay in minutes between a comment's creation and its visibility to other users.
		/// </summary>
		public int? delay { get; set; }
		/// <summary>
		/// Creation date of the user, in Unix Time.
		/// </summary>
		public int? created { get; set; }
		/// <summary>
		/// Creation date of the user, in ISO8601
		/// </summary>
		public string createdISO { get; set; }
		/// <summary>
		/// The user's optional self-description. HTML.
		/// </summary>
		public string about { get; set; }
		/// <summary>
		/// List of the user's stories, polls and comments.
		/// </summary>
		public NodeConnection submitted { get; set; }
	}
	public class NodeConnection : AliasContainer {
		/// <summary>
		/// Information to aid in pagination.
		/// </summary>
		public PageInfo pageInfo { get; set; }
		/// <summary>
		/// Information to aid in pagination.
		/// </summary>
		public List<NodeEdge> edges { get; set; }
	}
	public class PageInfo : AliasContainer {
		/// <summary>
		/// When paginating forwards, are there more items?
		/// </summary>
		public bool hasNextPage { get; set; }
		/// <summary>
		/// When paginating backwards, are there more items?
		/// </summary>
		public bool hasPreviousPage { get; set; }
		/// <summary>
		/// When paginating backwards, the cursor to continue.
		/// </summary>
		public string startCursor { get; set; }
		/// <summary>
		/// When paginating forwards, the cursor to continue.
		/// </summary>
		public string endCursor { get; set; }
	}
	public class NodeEdge : AliasContainer {
		/// <summary>
		/// The item at the end of the edge
		/// </summary>
		public Node node { get; set; }
		/// <summary>
		/// A cursor for use in pagination
		/// </summary>
		public NotNull<string> cursor { get; set; }
	}
	public class HackerNewsV2CommentConnection : AliasContainer {
		/// <summary>
		/// Information to aid in pagination.
		/// </summary>
		public PageInfo pageInfo { get; set; }
		/// <summary>
		/// Information to aid in pagination.
		/// </summary>
		public List<HackerNewsV2CommentEdge> edges { get; set; }
	}
	public class HackerNewsV2CommentEdge : AliasContainer {
		/// <summary>
		/// The item at the end of the edge
		/// </summary>
		public HackerNewsV2Comment node { get; set; }
		/// <summary>
		/// A cursor for use in pagination
		/// </summary>
		public NotNull<string> cursor { get; set; }
	}
	public class HackerNewsV2Comment : AliasContainer, Node {
		/// <summary>
		/// The ID of an object
		/// </summary>
		public NotNull<string> id { get; set; }
		/// <summary>
		/// The item's unique id.
		/// </summary>
		public NotNull<string> hnId { get; set; }
		/// <summary>
		/// The item's author.
		/// </summary>
		public HackerNewsV2User by { get; set; }
		/// <summary>
		/// The item's parent. For comments, either another comment or the relevant story. For pollopts, the relevant poll.
		/// </summary>
		public Node parent { get; set; }
		/// <summary>
		/// The comment, story or poll text. HTML.
		/// </summary>
		public string text { get; set; }
		/// <summary>
		/// Creation date of the item, in Unix Time.
		/// </summary>
		public int time { get; set; }
		/// <summary>
		/// Creation date of the item, in ISO8601
		/// </summary>
		public NotNull<string> timeISO { get; set; }
		/// <summary>
		/// The item's comments, in ranked display order.
		/// </summary>
		public HackerNewsV2CommentConnection kids { get; set; }
		/// <summary>
		/// if the item is deleted
		/// </summary>
		public bool? deleted { get; set; }
		/// <summary>
		/// if the item is dead
		/// </summary>
		public bool? dead { get; set; }
	}
	public class HackerNewsV2Job : AliasContainer, Node {
		/// <summary>
		/// The ID of an object
		/// </summary>
		public NotNull<string> id { get; set; }
		/// <summary>
		/// The item's unique id.
		/// </summary>
		public NotNull<string> hnId { get; set; }
		/// <summary>
		/// The item's author.
		/// </summary>
		public HackerNewsV2User by { get; set; }
		/// <summary>
		/// The story's score, or the votes for a pollopt.
		/// </summary>
		public int? score { get; set; }
		/// <summary>
		/// The comment, story or poll text. HTML.
		/// </summary>
		public string text { get; set; }
		/// <summary>
		/// Creation date of the item, in Unix Time.
		/// </summary>
		public int time { get; set; }
		/// <summary>
		/// Creation date of the item, in ISO8601
		/// </summary>
		public NotNull<string> timeISO { get; set; }
		/// <summary>
		/// The title of the story, poll or job.
		/// </summary>
		public string title { get; set; }
		/// <summary>
		/// The URL of the story.
		/// </summary>
		public string url { get; set; }
		/// <summary>
		/// if the item is deleted
		/// </summary>
		public bool? deleted { get; set; }
		/// <summary>
		/// if the item is dead
		/// </summary>
		public bool? dead { get; set; }
	}
	public class HackerNewsV2Poll : AliasContainer, Node {
		/// <summary>
		/// The ID of an object
		/// </summary>
		public NotNull<string> id { get; set; }
		/// <summary>
		/// The item's unique id.
		/// </summary>
		public NotNull<string> hnId { get; set; }
		/// <summary>
		/// The item's author.
		/// </summary>
		public HackerNewsV2User by { get; set; }
		/// <summary>
		/// In the case of stories or polls, the total comment count.
		/// </summary>
		public int? descendants { get; set; }
		/// <summary>
		/// The story's score, or the votes for a pollopt.
		/// </summary>
		public int? score { get; set; }
		/// <summary>
		/// Creation date of the item, in Unix Time.
		/// </summary>
		public int time { get; set; }
		/// <summary>
		/// Creation date of the item, in ISO8601
		/// </summary>
		public NotNull<string> timeISO { get; set; }
		/// <summary>
		/// The title of the story, poll or job.
		/// </summary>
		public string title { get; set; }
		/// <summary>
		/// The comment, story or poll text. HTML.
		/// </summary>
		public string text { get; set; }
		/// <summary>
		/// The item's comments, in ranked display order.
		/// </summary>
		public HackerNewsV2CommentConnection kids { get; set; }
		/// <summary>
		/// if the item is deleted
		/// </summary>
		public bool? deleted { get; set; }
		/// <summary>
		/// if the item is dead
		/// </summary>
		public bool? dead { get; set; }
		/// <summary>
		/// A list of related pollopts, in display order.
		/// </summary>
		public List<HackerNewsV2PollPart> parts { get; set; }
	}
	public class HackerNewsV2PollPart : AliasContainer, Node {
		/// <summary>
		/// The ID of an object
		/// </summary>
		public NotNull<string> id { get; set; }
		/// <summary>
		/// The item's unique id.
		/// </summary>
		public NotNull<string> hnId { get; set; }
		/// <summary>
		/// The item's author.
		/// </summary>
		public HackerNewsV2User by { get; set; }
		/// <summary>
		/// The story's score, or the votes for a pollopt.
		/// </summary>
		public int? score { get; set; }
		/// <summary>
		/// Creation date of the item, in Unix Time.
		/// </summary>
		public int time { get; set; }
		/// <summary>
		/// Creation date of the item, in ISO8601
		/// </summary>
		public NotNull<string> timeISO { get; set; }
		/// <summary>
		/// The comment, story or poll text. HTML.
		/// </summary>
		public string text { get; set; }
		/// <summary>
		/// The item's parent. For comments, either another comment or the relevant story. For pollopts, the relevant poll.
		/// </summary>
		public Node parent { get; set; }
		/// <summary>
		/// if the item is deleted
		/// </summary>
		public bool? deleted { get; set; }
	}
	public class RedditAPI : AliasContainer {
		public RedditSubreddit subreddit { get; set; }
		public RedditUser user { get; set; }
	}
	public class RedditSubreddit : AliasContainer {
		/// <summary>
		/// Name of the subreddit
		/// </summary>
		public NotNull<string> name { get; set; }
		/// <summary>
		/// The Reddit API fullname of the subreddit
		/// </summary>
		public NotNull<string> fullnameId { get; set; }
		/// <summary>
		/// Title of the subreddit
		/// </summary>
		public NotNull<string> title { get; set; }
		/// <summary>
		/// Description of the subreddit
		/// </summary>
		public NotNull<string> publicDescription { get; set; }
		/// <summary>
		/// Accounts active right now on the subreddit
		/// </summary>
		public int accountsActive { get; set; }
		/// <summary>
		/// Number of subscribers to the subreddit
		/// </summary>
		public int subscribers { get; set; }
		/// <summary>
		/// Creation date of the subreddit, in Unix Time (UTC)
		/// </summary>
		public float created { get; set; }
		/// <summary>
		/// Creation date of the subreddit, in ISO8601
		/// </summary>
		public NotNull<string> createdISO { get; set; }
		/// <summary>
		/// Hot/"Front Page" listings of the subreddit
		/// </summary>
		public NotNull<List<RedditLink>> hotListings { get; set; }
		/// <summary>
		/// Newest listings of the subreddit
		/// </summary>
		public NotNull<List<RedditLink>> newListings { get; set; }
		/// <summary>
		/// Rising listings of the subreddit
		/// </summary>
		public NotNull<List<RedditLink>> risingListings { get; set; }
		/// <summary>
		/// Controversial listings of the subreddit
		/// </summary>
		public NotNull<List<RedditLink>> controversialListings { get; set; }
		/// <summary>
		/// Top listings of the subreddit
		/// </summary>
		public NotNull<List<RedditLink>> topListings { get; set; }
	}
	public class RedditLink : AliasContainer {
		/// <summary>
		/// Title of the link
		/// </summary>
		public NotNull<string> title { get; set; }
		/// <summary>
		/// The Reddit API fullname of the link
		/// </summary>
		public NotNull<string> fullnameId { get; set; }
		/// <summary>
		/// Score of the link
		/// </summary>
		public int score { get; set; }
		/// <summary>
		/// Number of comments
		/// </summary>
		public int numComments { get; set; }
		/// <summary>
		/// URL of the link
		/// </summary>
		public NotNull<string> url { get; set; }
		/// <summary>
		/// Author of the link
		/// </summary>
		public RedditUser author { get; set; }
		/// <summary>
		/// Comments on the link
		/// </summary>
		public NotNull<List<RedditComment>> comments { get; set; }
	}
	public class RedditUser : AliasContainer {
		/// <summary>
		/// The Reddit API fullname of the user
		/// </summary>
		public NotNull<string> fullnameId { get; set; }
		/// <summary>
		/// The user's unique username.
		/// </summary>
		public NotNull<string> username { get; set; }
		/// <summary>
		/// Creation date of the user, in Unix Time (UTC)
		/// </summary>
		public float created { get; set; }
		/// <summary>
		/// Creation date of the user, in ISO8601
		/// </summary>
		public NotNull<string> createdISO { get; set; }
		/// <summary>
		/// Karma by links of the user
		/// </summary>
		public int linkKarma { get; set; }
		/// <summary>
		/// Karma by comments of the user
		/// </summary>
		public int commentKarma { get; set; }
	}
	public class RedditComment : AliasContainer {
		/// <summary>
		/// Author of the comment
		/// </summary>
		public RedditUser author { get; set; }
		/// <summary>
		/// Body of the comment
		/// </summary>
		public NotNull<string> body { get; set; }
		/// <summary>
		/// Replies to the comment
		/// </summary>
		public NotNull<List<RedditComment>> replies { get; set; }
	}
	public enum TimeInterval {
		hour,
		day,
		week,
		month,
		year,
		all
	}
	public class KeyValueAPI : AliasContainer {
		public KeyValueItem getValue { get; set; }
	}
	public class KeyValueItem : AliasContainer {
		/// <summary>
		/// The item's unique id.
		/// </summary>
		public NotNull<string> id { get; set; }
		/// <summary>
		/// The item's value.
		/// </summary>
		public string value { get; set; }
	}
	public class GithubAPI : AliasContainer {
		public GithubUser user { get; set; }
		public GithubRepo repo { get; set; }
	}
	public class GithubUser : AliasContainer {
		public string login { get; set; }
		public int? id { get; set; }
		public string company { get; set; }
		public string avatar_url { get; set; }
		public List<GithubRepo> repos { get; set; }
	}
	public class GithubRepo : AliasContainer {
		public int? id { get; set; }
		public string name { get; set; }
		public List<GithubCommit> commits { get; set; }
		public List<GithubIssue> issues { get; set; }
		public List<GithubBranch> branches { get; set; }
		public GithubUser owner { get; set; }
	}
	public class GithubCommit : AliasContainer {
		public string sha { get; set; }
		public UserOrCommitAuthor author { get; set; }
		public string message { get; set; }
		public string date { get; set; }
		public List<GithubStatus> status { get; set; }
		public GithubTree tree { get; set; }
	}
	public interface UserOrCommitAuthor {
	}
	public class GithubCommitAuthor : AliasContainer {
		public string email { get; set; }
		public string name { get; set; }
	}
	public class GithubStatus : AliasContainer {
		public string state { get; set; }
		public string description { get; set; }
		public string target_url { get; set; }
		public string context { get; set; }
		public string updated_at { get; set; }
	}
	public class GithubTree : AliasContainer {
		public List<GithubTreeEntry> entries { get; set; }
	}
	public class GithubTreeEntry : AliasContainer {
		public string path { get; set; }
		public GithubCommit last_commit { get; set; }
	}
	public class GithubIssue : AliasContainer {
		public int? id { get; set; }
		public string state { get; set; }
		public string title { get; set; }
		public string body { get; set; }
		public GithubUser user { get; set; }
		public GithubUser assignee { get; set; }
		public GithubUser closed_by { get; set; }
		public List<GithubIssueLabelType> labels { get; set; }
		public int? commentCount { get; set; }
		public List<GithubIssueCommentType> comments { get; set; }
	}
	public class GithubIssueLabelType : AliasContainer {
		public string url { get; set; }
		public string name { get; set; }
		public string color { get; set; }
	}
	public class GithubIssueCommentType : AliasContainer {
		public int? id { get; set; }
		public string body { get; set; }
		public GithubUser user { get; set; }
	}
	public class GithubBranch : AliasContainer {
		public string name { get; set; }
		public GithubCommit lastCommit { get; set; }
	}
	public class TwitterAPI : AliasContainer {
		public TwitterUser user { get; set; }
		public Tweet tweet { get; set; }
		/// <summary>
		/// Returns a collection of relevant Tweets matching a specified query.
		/// </summary>
		public List<Tweet> search { get; set; }
	}
	public enum UserIdentifier {
		id,
		name
	}
	public struct UserIdentity : IScalar {
		public string Value { get; set; }
	}
	public class TwitterUser : AliasContainer {
		public string created_at { get; set; }
		public string description { get; set; }
		public string id { get; set; }
		public string screen_name { get; set; }
		public string name { get; set; }
		public string profile_image_url { get; set; }
		public string url { get; set; }
		public int? tweets_count { get; set; }
		public int? followers_count { get; set; }
		/// <summary>
		/// Get a list of tweets for current user
		/// </summary>
		public List<Tweet> tweets { get; set; }
	}
	public class Tweet : AliasContainer {
		public string id { get; set; }
		public string created_at { get; set; }
		public string text { get; set; }
		public int? retweet_count { get; set; }
		public TwitterUser user { get; set; }
		/// <summary>
		/// Get a list of retweets
		/// </summary>
		public List<Retweet> retweets { get; set; }
	}
	public class Retweet : AliasContainer {
		public string id { get; set; }
		public string created_at { get; set; }
		public string in_reply_to_tweet_id { get; set; }
		public int? in_reply_to_user_id { get; set; }
		public string in_reply_to_screen_name { get; set; }
		public Tweet retweeted_status { get; set; }
		public TwitterUser user { get; set; }
	}
	public enum SearchReponse {
		mixed,
		recent,
		popular
	}
	public class GiphyAPI : AliasContainer {
		public GiphyGIFData gif { get; set; }
		public List<GiphyGIFData> search { get; set; }
		public GiphyGIFData random { get; set; }
	}
	public class GiphyGIFData : AliasContainer {
		/// <summary>
		/// The item's unique id.
		/// </summary>
		public NotNull<string> id { get; set; }
		public NotNull<string> url { get; set; }
		public GiphyGIFImages images { get; set; }
	}
	public class GiphyGIFImages : AliasContainer {
		public GiphyGIFImageDataFixedHeight fixed_height { get; set; }
		public GiphyGIFImageDataFixedHeightStill fixed_height_still { get; set; }
		public GiphyGIFImageDataFixedHeightDownsample fixed_height_downsampled { get; set; }
		public GiphyGIFImageDataFixedWidth fixed_width { get; set; }
		public GiphyGIFImageDataFixedWidthStill fixed_width_still { get; set; }
		public GiphyGIFImageDataFixedWidthDownsample fixed_width_downsampled { get; set; }
		public GiphyGIFImageDataFixedHeightSmall fixed_height_small { get; set; }
		public GiphyGIFImageDataFixedHeightSmallStill fixed_height_small_still { get; set; }
		public GiphyGIFImageDataFixedWidthSmall fixed_width_small { get; set; }
		public GiphyGIFImageDataFixedWidthSmallStill fixed_width_small_still { get; set; }
		public GiphyGIFImageDataDownsized downsized { get; set; }
		public GiphyGIFImageDataDownsizedStill downsized_still { get; set; }
		public GiphyGIFImageDataDownsizedLarge downsized_large { get; set; }
		public GiphyGIFImageDataOriginal original { get; set; }
		public GiphyGIFImageDataOriginalStill original_still { get; set; }
		public GiphyGIFImageDataLooping looping { get; set; }
	}
	public class GiphyGIFImageDataFixedHeight : AliasContainer {
		public NotNull<string> url { get; set; }
		public NotNull<string> width { get; set; }
		public NotNull<string> height { get; set; }
		public NotNull<string> size { get; set; }
		public NotNull<string> mp4 { get; set; }
		public NotNull<string> mp4_size { get; set; }
		public NotNull<string> webp { get; set; }
		public NotNull<string> webp_size { get; set; }
	}
	public class GiphyGIFImageDataFixedHeightStill : AliasContainer {
		public NotNull<string> url { get; set; }
		public NotNull<string> width { get; set; }
		public NotNull<string> height { get; set; }
	}
	public class GiphyGIFImageDataFixedHeightDownsample : AliasContainer {
		public NotNull<string> url { get; set; }
		public NotNull<string> width { get; set; }
		public NotNull<string> height { get; set; }
		public NotNull<string> size { get; set; }
		public NotNull<string> webp { get; set; }
		public NotNull<string> webp_size { get; set; }
	}
	public class GiphyGIFImageDataFixedWidth : AliasContainer {
		public NotNull<string> url { get; set; }
		public NotNull<string> width { get; set; }
		public NotNull<string> height { get; set; }
		public NotNull<string> size { get; set; }
		public NotNull<string> mp4 { get; set; }
		public NotNull<string> mp4_size { get; set; }
		public NotNull<string> webp { get; set; }
		public NotNull<string> webp_size { get; set; }
	}
	public class GiphyGIFImageDataFixedWidthStill : AliasContainer {
		public NotNull<string> url { get; set; }
		public NotNull<string> width { get; set; }
		public NotNull<string> height { get; set; }
	}
	public class GiphyGIFImageDataFixedWidthDownsample : AliasContainer {
		public NotNull<string> url { get; set; }
		public NotNull<string> width { get; set; }
		public NotNull<string> height { get; set; }
		public NotNull<string> size { get; set; }
		public NotNull<string> webp { get; set; }
		public NotNull<string> webp_size { get; set; }
	}
	public class GiphyGIFImageDataFixedHeightSmall : AliasContainer {
		public NotNull<string> url { get; set; }
		public NotNull<string> width { get; set; }
		public NotNull<string> height { get; set; }
		public NotNull<string> size { get; set; }
		public NotNull<string> webp { get; set; }
		public NotNull<string> webp_size { get; set; }
	}
	public class GiphyGIFImageDataFixedHeightSmallStill : AliasContainer {
		public NotNull<string> url { get; set; }
		public NotNull<string> width { get; set; }
		public NotNull<string> height { get; set; }
	}
	public class GiphyGIFImageDataFixedWidthSmall : AliasContainer {
		public NotNull<string> url { get; set; }
		public NotNull<string> width { get; set; }
		public NotNull<string> height { get; set; }
		public NotNull<string> size { get; set; }
		public NotNull<string> webp { get; set; }
		public NotNull<string> webp_size { get; set; }
	}
	public class GiphyGIFImageDataFixedWidthSmallStill : AliasContainer {
		public NotNull<string> url { get; set; }
		public NotNull<string> width { get; set; }
		public NotNull<string> height { get; set; }
	}
	public class GiphyGIFImageDataDownsized : AliasContainer {
		public NotNull<string> url { get; set; }
		public NotNull<string> width { get; set; }
		public NotNull<string> height { get; set; }
		public NotNull<string> small { get; set; }
	}
	public class GiphyGIFImageDataDownsizedStill : AliasContainer {
		public NotNull<string> url { get; set; }
		public NotNull<string> width { get; set; }
		public NotNull<string> height { get; set; }
	}
	public class GiphyGIFImageDataDownsizedLarge : AliasContainer {
		public NotNull<string> url { get; set; }
		public NotNull<string> width { get; set; }
		public NotNull<string> height { get; set; }
		public NotNull<string> size { get; set; }
	}
	public class GiphyGIFImageDataOriginal : AliasContainer {
		public NotNull<string> url { get; set; }
		public NotNull<string> width { get; set; }
		public NotNull<string> height { get; set; }
		public NotNull<string> size { get; set; }
		public NotNull<string> mp4 { get; set; }
		public NotNull<string> mp4_size { get; set; }
		public NotNull<string> webp { get; set; }
		public NotNull<string> webp_size { get; set; }
		public NotNull<string> frames { get; set; }
	}
	public class GiphyGIFImageDataOriginalStill : AliasContainer {
		public NotNull<string> url { get; set; }
		public NotNull<string> width { get; set; }
		public NotNull<string> height { get; set; }
	}
	public class GiphyGIFImageDataLooping : AliasContainer {
		public NotNull<string> mp4 { get; set; }
	}
	public enum GiphyRatingType {
		y,
		g,
		pg,
		pg13,
		r
	}
	public class GraphQLHubMutationAPI : AliasContainer {
		public SetValueForKeyPayload keyValue_setValue { get; set; }
	}
	public class SetValueForKeyPayload : AliasContainer {
		public KeyValueItem item { get; set; }
		public NotNull<string> clientMutationId { get; set; }
	}
}
