using FaceitLib.Models.Shared;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace FaceitLib.Models.ClassObjectLists
{
    public class MatchStatsTeamsListObject
    {
        [JsonProperty(PropertyName = "team_id")]
        public string TeamID { get; set; }

        [JsonProperty(PropertyName = "premade")]
        public bool IsPremade { get; set; }

        [JsonProperty(PropertyName = "team_stats")]
        public TeamStats TeamStats { get; set; }
        public List<Players> Players { get; set; }
    }
}
