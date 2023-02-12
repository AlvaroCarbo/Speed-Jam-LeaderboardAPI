using Microsoft.Extensions.Options;
using MongoDB.Driver;
using SpeedJamLeaderboardAPI.Models;

namespace SpeedJamLeaderboardAPI.Services;

public class LeaderboardServices
{
    private readonly IMongoCollection<LeaderboardEntry> _leaderboardCollection;

    public LeaderboardServices(IOptions<LeaderboardDatabaseSettings> settings)
    {
        var mongoClient = new MongoClient(settings.Value.ConnectionString);
        var mongoDatabase = mongoClient.GetDatabase(settings.Value.DatabaseName);
        _leaderboardCollection = mongoDatabase.GetCollection<LeaderboardEntry>(settings.Value.ScoresCollectionName);
    }

    public async Task<List<LeaderboardEntry>> GetAsync() =>
        await _leaderboardCollection.Find(_ => true).ToListAsync();

    public async Task<LeaderboardEntry?> GetAsync(string id) =>
        await _leaderboardCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

    public async Task CreateAsync(LeaderboardEntry newLeaderboardEntry) =>
        await _leaderboardCollection.InsertOneAsync(newLeaderboardEntry);

    public async Task UpdateAsync(string id, LeaderboardEntry updatedLeaderboardEntry) =>
        await _leaderboardCollection.ReplaceOneAsync(x => x.Id == id, updatedLeaderboardEntry);

    public async Task RemoveAsync(string id) =>
        await _leaderboardCollection.DeleteOneAsync(x => x.Id == id);
}