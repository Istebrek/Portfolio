using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Shared.Lists;

namespace Domain.Entities;

public class Experience
{
    [BsonId]
    public ObjectId Id { get; set; }
    public required string CompanyName { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly? EndDate { get; set; }
    public List<Skill>? Skills { get; set; }
    public List<ExperienceTranslation>? Translations { get; set; }
}

public class ExperienceTranslation
{
    public required Language Language { get; set; }
    public required string Role { get; set; }
    public string? Description { get; set; }
    public string? Location { get; set; }
}
