using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace IronGitHubModern;

    public class GitHubClient
    {
        private readonly HttpClient _http;

    public GitHubClient(HttpClient? httpClient = null)
    {
        _http = httpClient ?? new HttpClient();
        _http.BaseAddress = new Uri("https://api.github.com");
        _http.DefaultRequestHeaders.UserAgent.ParseAdd("IronGitHubModern");
    }

    public async Task<User> GetAuthenticatedUserAsync(string token)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, "/user");
        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
        var response = await _http.SendAsync(request);
        response.EnsureSuccessStatusCode();
        return (await response.Content.ReadFromJsonAsync<User>())!;
    }

    public async Task<User> GetUserAsync(string username)
    {
        var response = await _http.GetAsync($"/users/{username}");
        response.EnsureSuccessStatusCode();
        return (await response.Content.ReadFromJsonAsync<User>())!;
    }

    public async Task<Repository> GetRepositoryAsync(string owner, string repo)
    {
        var response = await _http.GetAsync($"/repos/{owner}/{repo}");
        response.EnsureSuccessStatusCode();
        return (await response.Content.ReadFromJsonAsync<Repository>())!;
    }

    public async Task<Gist> GetGistAsync(string id)
    {
        var response = await _http.GetAsync($"/gists/{id}");
        response.EnsureSuccessStatusCode();
        return (await response.Content.ReadFromJsonAsync<Gist>())!;
    }
    }
