using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Domain.Entities;

public class Review
{
    [BsonId]
    public ObjectId Id { get; set; } 
    public required string Comment { get; set; }
}
