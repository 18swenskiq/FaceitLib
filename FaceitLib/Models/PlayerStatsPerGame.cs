using Newtonsoft.Json;
using System.Collections.Generic;

namespace FaceitLib.Models
{
    public class PlayerStatsPerGame
    {

        [JsonProperty(PropertyName = "player_id")]
        public string PlayerID { get; set; }

        [JsonProperty(PropertyName = "game_id")]
        public string GameID { get; set; }
        public LifetimeStats Lifetime { get; set; }
        public List<Segment> Segments { get; set; }
    }

    public class Segment
    {
        public SegmentStats Stats { get; set; }
        public string Type { get; set; }
        public string Mode { get; set; }
        public string Label { get; set; }

        [JsonProperty(PropertyName = "img_small")]
        public string ImageSmall { get; set; }

        [JsonProperty(PropertyName = "img_regular")]
        public string ImageRegular { get; set; }
    }

    public class SegmentStats
    {
        public string Deaths { get; set; }
        public string Headshots { get; set; }
        public string Kills { get; set; }
        public string Rounds { get; set; }

        [JsonProperty(PropertyName = "Quadro Kills")]
        public string QuadroKills { get; set; }

        [JsonProperty(PropertyName = "Average Deaths")]
        public string AvgDeaths { get; set; }


        [JsonProperty(PropertyName = "Average Headshots %")]
        public string AvgHeadshotPercentage { get; set; }

        [JsonProperty(PropertyName = "Penta Kills")]
        public string PentaKills { get; set; }

        [JsonProperty(PropertyName = "Average Penta Kills")]
        public string AvgPentaKills { get; set; }

        [JsonProperty(PropertyName = "K/R Ratio")]
        public string KRRatio { get; set; }
        public string Matches { get; set; }
        public string Assists { get; set; }

        [JsonProperty(PropertyName = "Average Kills")]
        public string AvgKills { get; set; }

        [JsonProperty(PropertyName = "Total Headshots %")]
        public string TotalHeadshotPercentage { get; set; }

        [JsonProperty(PropertyName = "Average Assists")]
        public string AvgAssists { get; set; }

        [JsonProperty(PropertyName = "Triple Kills")]
        public string TripleKills { get; set; }

        [JsonProperty(PropertyName = "Win Rate %")]
        public string WinratePercentage { get; set; }

        [JsonProperty(PropertyName = "Average K/D Ratio")]
        public string AvgKDRatio { get; set; }

        public string Wins { get; set; }

        [JsonProperty(PropertyName = "Average MVPs")]
        public string AvgMVPs { get; set; }

        [JsonProperty(PropertyName = "Headshots per Match")]
        public string HeadshotsPerMatch { get; set; }
        public string MVPs { get; set; }
    }

    public class LifetimeStats
    {
        [JsonProperty(PropertyName = "K/D Ratio")]
        public string KDRatio { get; set; }

        [JsonProperty(PropertyName = "Win Rate %")]
        public string WinratePercentage { get; set; }

        public string Wins { get; set; }

        [JsonProperty(PropertyName = "Average Headshots %")]
        public string AvgHeadshotPercentage { get; set; }

        [JsonProperty(PropertyName = "Longest Win Streak")]
        public string LongestWinstreak { get; set; }

        public string Matches { get; set; }

        [JsonProperty(PropertyName = "Current Win Streak")]
        public string CurrentWinstreak { get; set; }

        [JsonProperty(PropertyName = "Recent Results")]
        public List<string> RecentResults { get; set; }

        [JsonProperty(PropertyName = "Average K/D Ratio")]
        public string AvgKDRatio { get; set; }

        [JsonProperty(PropertyName = "Total Headshots %")]
        public string TotalHeadshotPercentage { get; set; }
    }
}
