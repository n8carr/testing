using System.Text.Json.Serialization;

namespace IronGitHubModern;

public class Repository
{
    [JsonPropertyName("full_name")]
    public string? FullName { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("html_url")]
    public string? HtmlUrl { get; set; }

    [JsonPropertyName("stargazers_count")]
    public int Stars { get; set; }

    [JsonPropertyName("forks_count")]
    public int Forks { get; set; }
}
