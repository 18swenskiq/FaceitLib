using Newtonsoft.Json;
using System.Collections.Generic;

namespace FaceitLib.Models
{
    public class TournamentTeams
    {
        [JsonProperty(PropertyName = "checked_in")]
        public List<TournamentTeamDetails> CheckedIn { get; set; }
        public List<TournamentTeamDetails> Finished { get; set; }
        public List<TournamentTeamDetails> Joined { get; set; }
        public List<TournamentTeamDetails> Started { get; set; }
    }

    public class TournamentTeamDetails
    {
        public string Nickname { get; set; }

        [JsonProperty(PropertyName = "skill_level")]
        public int SkillLevel { get; set; }

        [JsonProperty(PropertyName = "subs_done")]
        public int SubsDone { get; set; }

        [JsonProperty(PropertyName = "team_id")]
        public string TeamID { get; set; }

        [JsonProperty(PropertyName = "team_leader")]
        public string TeamLeader { get; set; }

        [JsonProperty(PropertyName = "team_type")]
        public string TeamType { get; set; }
    }
}
