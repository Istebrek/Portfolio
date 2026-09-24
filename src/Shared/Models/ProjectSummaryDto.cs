using Shared.Lists;

namespace Shared.Models;

public record ProjectSummaryDto(
    string Id,
    string Title,
    string? Description,
    List<Skill>? Skills,
    string? ThumbnailPath
);
