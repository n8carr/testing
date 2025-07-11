using IronGitHubModern;

var client = new GitHubClient();

var repos = await client.GetOrganizationRepositoriesAsync("github");
if (repos.Count > 0)
{
    var repo = repos[0];
    Console.WriteLine($"First repo in github org: {repo.FullName}");
}
