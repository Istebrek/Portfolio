using Shared.Lists;

namespace Shared.Models;

public record ProjectDetailsDto(
    string Id,
    string Title,
    string? Description,
    string? GitHubUrl,
    string? DemoUrl,
    List<string>? Collaborators,
    List<Skill>? Skills,
    List<string>? ImagePaths
);