using Newtonsoft.Json;
using System;

namespace FaceitLib.Models.ClassObjectLists
{
    public class LeaderboardListObject
    {
        [JsonProperty(PropertyName = "competition_id")]
        public string CompetitionID { get; set; }

        [JsonProperty(PropertyName = "competition_type")]
        public string CompetitionType { get; set; }

        [JsonProperty(PropertyName = "end_date")]
        public Int64 EndDate { get; set; }

        [JsonProperty(PropertyName = "game_id")]
        public string GameID { get; set; }
        public int Group { get; set; }

        [JsonProperty(PropertyName = "leaderboard_id")]
        public string LeaderboardID { get; set; }

        [JsonProperty(PropertyName = "leaderboard_mode")]
        public string LeaderboardMode { get; set; }

        [JsonProperty(PropertyName = "leaderboard_name")]
        public string LeaderboardName { get; set; }

        [JsonProperty(PropertyName = "leaderboard_type")]
        public string LeaderboardType { get; set; }

        [JsonProperty(PropertyName = "min_matches")]
        public int MinMatches { get; set; }

        [JsonProperty(PropertyName="points_per_draw")]
        public int PointsPerDraw { get; set; }

        [JsonProperty(PropertyName = "points_per_loss")]
        public int PointsPerLoss { get; set; }

        [JsonProperty(PropertyName = "points_per_win")]
        public int PointsPerWin { get; set; }

        [JsonProperty(PropertyName = "ranking_boost")]
        public int RankingBoost { get; set; }

        [JsonProperty(PropertyName = "ranking_type")]
        public string RankingType { get; set; }

        public string Region { get; set; }
        public int Round { get; set; }
        public int Season { get; set; }

        [JsonProperty(PropertyName = "start_date")]
        public int StartDate { get; set; }

        [JsonProperty(PropertyName = "starting_points")]
        public int StartingPoints { get; set; }

        public string Status { get; set; }
    }
}
