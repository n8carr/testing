using System.Text.Json.Serialization;

namespace IronGitHubModern;

public class User
{
    [JsonPropertyName("login")]
    public string? Login { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("public_repos")]
    public int PublicRepos { get; set; }
}
