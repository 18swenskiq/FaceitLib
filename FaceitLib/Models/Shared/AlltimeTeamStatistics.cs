using Newtonsoft.Json;
using System.Collections.Generic;

namespace FaceitLib.Models.Shared
{
    public class AlltimeTeamStatistics
    {
        [JsonProperty(PropertyName = "team_id")]
        public string TeamID { get; set; }

        [JsonProperty(PropertyName = "game_id")]
        public string GameID { get; set; }

        public LifetimeTeamStats Lifetime { get; set; }
        public List<TeamStatsMapSegments> Segments { get; set; }
    }

    public class TeamStatsMapSegments
    {
        public string Type { get; set; }
        public string Mode { get; set; }
        public string Label { get; set; }

        [JsonProperty(PropertyName = "img_small")]
        public string ImgSmall { get; set; }

        [JsonProperty(PropertyName = "img_regular")]
        public string ImgRegular { get; set; }
        public TeamStatsMapSegmentsStats Stats { get; set; }
    }

    public class TeamStatsMapSegmentsStats
    {
        [JsonProperty(PropertyName = "Win Rate %")]
        public string WinratePercentage { get; set; }

        public string Matches { get; set; }
        public string Wins { get; set; }
    }

    public class LifetimeTeamStats
    {
        [JsonProperty(PropertyName = "Total Headshots %")]
        public string TotalHeadshotPercentage { get; set; }

        [JsonProperty(PropertyName = "Total K/D Ratio")]
        public string TotalKDRatio { get; set; }

        [JsonProperty(PropertyName = "Team Average K/R Ratio")]
        public string TeamAvgKRRatio { get; set; }

        [JsonProperty(PropertyName = "Team Average K/D Ratio")]
        public string TeamAvgKDRatio { get; set; }

        [JsonProperty(PropertyName = "Win Rate %")]
        public string WinratePercentage { get; set; }

        [JsonProperty(PropertyName = "Total K/R Ratio")]
        public string TotalKRRatio { get; set; }

        [JsonProperty(PropertyName = "Team Average Headshots %")]
        public string TeamAvgHeadshotPercentage { get; set; }

        [JsonProperty(PropertyName = "Current Win Streak")]
        public string CurrentWinStreak { get; set; }

        [JsonProperty(PropertyName = "Recent Results")]
        public List<string> RecentResults { get; set; }

        [JsonProperty(PropertyName = "Longest Win Streak")]
        public string LongestWinStreak { get; set; }

        [JsonProperty(PropertyName = "Team Headshots per Match")]
        public string TeamHeadshotsPerMatch { get; set; }

        [JsonProperty(PropertyName = "Total Headshots per Match")]
        public string TotalHeadshotsPerMatch { get; set; }
        public string Wins { get; set; }
        public string Matches { get; set; }
    }
}
