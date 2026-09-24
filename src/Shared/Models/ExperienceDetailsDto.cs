using Shared.Lists;

namespace Shared.Models;

public record ExperienceDetailsDto (
    string Id,
    string CompanyName,
    string Role,
    string Description,
    string Location,
    DateOnly StartDate,
    DateOnly EndDate,
    List<Skill> Skills
);