using Octokit;

namespace UmbracoProject.Code
{
    public class GithubHelper
    {
public static IReadOnlyList<Repository> GetRepositories(string organisation)
        {
            var client = new GitHubClient(new ProductHeaderValue("my-cool-app"));
            return client.Repository.GetAllForOrg(organisation).Result;
        }
    }
}
