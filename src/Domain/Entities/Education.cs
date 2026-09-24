using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Shared.Lists;

namespace Domain.Entities;

public class Education
{
    [BsonId]
    public ObjectId Id { get; set; }
    public required string Institution { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
    public List<EducationTranslation>? Translations { get; set; }
    public List<Skill>? Skills { get; set; }
}

public class EducationTranslation
{
    public required Language Language { get; set; }
    public required string Degree { get; set; }
    public string? Description { get; set; }
    public string? Location { get; set; }
}