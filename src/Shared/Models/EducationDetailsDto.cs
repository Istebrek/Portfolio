using Shared.Lists;

namespace Shared.Models;

public record EducationDetailsDto(
    string Id,
    string Institution,
    string Degree,
    string Description,
    string Location,
    DateOnly StartDate,
    DateOnly EndDate,
    List<Skill> Skills
);