namespace GameLibrary;

public class GameWorld
{
    private readonly FileBasedPlayerStatisticsService playerStatisticsService;

    public GameWorld()
    {
        playerStatisticsService = new("statistics.json");
    }

    public PlayerReportDto GetPlayerReport(Player player)
    {
        var stats = playerStatisticsService.GetPlayerStatistics(player.Name);
        double averageScore = stats.GamesPlayed == 0 ? 0 : (double)stats.TotalScore / stats.GamesPlayed;

        return new PlayerReportDto(
            player.Name,
            player.Level,
            player.JoinDate,
            stats.GamesPlayed,
            stats.TotalScore,
            averageScore
        );
    }
}
