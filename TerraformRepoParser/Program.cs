using System.Text.Json;
using System.Text.RegularExpressions;

if (args.Length < 2)
{
    Console.Error.WriteLine("Usage: TerraformRepoParser <directory> <prefix1> [prefix2 ...]");
    return;
}

var directory = args[0];
var prefixes = args.Skip(1).ToArray();
var repos = new List<string>();

foreach (var file in Directory.EnumerateFiles(directory, "*.tf", SearchOption.AllDirectories))
{
    foreach (var line in File.ReadLines(file))
    {
        var match = Regex.Match(line, @"^\s*name\s*=\s*""([^""]+)""");
        if (match.Success)
        {
            var name = match.Groups[1].Value;
            if (prefixes.Any(p => name.StartsWith(p, StringComparison.OrdinalIgnoreCase)))
                repos.Add(name);
        }
    }
}

var json = JsonSerializer.Serialize(repos.Distinct().OrderBy(x => x), new JsonSerializerOptions { WriteIndented = true });
Console.WriteLine(json);
