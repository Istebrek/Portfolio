namespace Shared.Models;

public record ExperienceSummaryDto(
    string Id,
    string CompanyName,
    string Role,
    DateOnly StartDate,
    DateOnly EndDate
);
