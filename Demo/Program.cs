using IronGitHubModern;

var client = new GitHubClient();
var repo = await client.GetRepositoryAsync("octocat", "Hello-World");
Console.WriteLine($"Repo {repo.FullName} has {repo.Stars} stars");
