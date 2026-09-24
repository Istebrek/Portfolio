namespace Shared.Models;

public record EducationSummaryDto(
    string Id,
    string Institution,
    string Degree,
    DateOnly StartDate,
    DateOnly EndDate
);