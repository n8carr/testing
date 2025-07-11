# IronGitHubModern

This repository contains a rewrite of the [IronGitHub](https://github.com/in2bits/IronGitHub) library targeting modern .NET.  The `IronGitHubModern` project exposes a lightweight `GitHubClient` built with `HttpClient` and `System.Text.Json`.

Currently supported operations:

- Get information about a user
- Fetch repository details
- Retrieve a gist
- List organizations for a user
- List repositories for an organization

Run the sample console app:

```bash
dotnet run --project Demo/Demo.csproj
```

Parse Terraform files for repository names:

```bash
dotnet run --project TerraformRepoParser/TerraformRepoParser.csproj <dir> prefix1 [prefix2]
```
