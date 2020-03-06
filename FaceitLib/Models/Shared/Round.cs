using FaceitLib.Models.ClassObjectLists;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace FaceitLib.Models.Shared
{
    public class Round
    {
        [JsonProperty(PropertyName = "best_of")]
        public int BestOf { get; set; }

        [JsonProperty(PropertyName = "competition_id")]
        public string CompetitionID { get; set; }

        [JsonProperty(PropertyName = "game_id")]
        public string GameID { get; set; }

        [JsonProperty(PropertyName = "game_mode")]
        public string GameMode { get; set; }

        [JsonProperty(PropertyName = "match_id")]
        public string MatchID { get; set; }

        [JsonProperty(PropertyName = "match_round")]
        public int MatchRound { get; set; }
        public int Played { get; set; }

        [JsonProperty(PropertyName = "round_stats")]
        public RoundStats RoundStats { get; set; }
        public List<MatchStatsTeamsListObject> Teams { get; set; }

    }
}
