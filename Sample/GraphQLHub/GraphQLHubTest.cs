using GraphQL2Net.Support.Json;
using Sample.GraphQLHub.Q;
using Sample.GraphQLHub.R;

namespace Sample.GraphQLHub {
	public static class GraphQLHubTest {
		public static void Run() {
				var q0 = QL.Compile(new Q.GraphQLHubAPI {
					new twitter {
						new TwitterAPI_user(identifier: UserIdentifier.name, identity: "clayallsopp") {
							new created_at(),
							new description(),
							new TwitterUser_id(),
							new screen_name(),
							new TwitterUser_name(),
							new profile_image_url(),
							new url(),
							new tweets_count(),
							new followers_count(),
							new tweets(limit: 1) {
								new text()
							}
						},
						new tweet(id: "687433440774459392") {
							new text(),
							new retweets(limit: 2) {
								new Retweet_id(),
								new retweeted_status() {
									new Tweet_id()
								},
								new Retweet_user() {
									new screen_name()
								}
							}
						},
						new search(q: "Javascript", count: 1, result_type: SearchReponse.mixed) {
							new Tweet_user() {
								new screen_name()
							},
							new Tweet_id(),
							new text()
						}
					}
				});
				var output = q0.Run("https://www.graphqlhub.com/graphql");
		}
	}
}
