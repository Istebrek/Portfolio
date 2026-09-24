using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Shared.Lists;

namespace Domain.Entities;

public class Project
{
    [BsonId]
    public ObjectId Id { get; set; }
    public string? GitHubUrl { get; set; }
    public string? DemoUrl { get; set; }
    public List<string>? Collaborators { get; set; }
    public List<string>? ImagePaths { get; set; }
    public List<Skill>? Skills { get; set; }
    public List<ProjectTranslation> Translations { get; set; } = [];
}

public class ProjectTranslation
{
    public required Language Language { get; set; }
    public required string Title { get; set; }
    public string? Description { get; set; }
}
