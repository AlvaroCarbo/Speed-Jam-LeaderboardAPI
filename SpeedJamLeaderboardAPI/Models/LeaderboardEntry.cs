using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SpeedJamLeaderboardAPI.Models;

public class LeaderboardEntry
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    [BsonElement("name")]
    public string Name { get; set; }

    [BsonElement("score")]
    public string Score { get; set; }
}