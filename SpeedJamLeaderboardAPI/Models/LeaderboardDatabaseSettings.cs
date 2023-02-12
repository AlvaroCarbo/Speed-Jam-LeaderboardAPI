namespace SpeedJamLeaderboardAPI.Models;

public class LeaderboardDatabaseSettings
{
    public string ConnectionString { get; set; } = null!;
    public string DatabaseName { get; set; } = null!;
    public string ScoresCollectionName { get; set; } = null!;
}