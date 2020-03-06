using FaceitLib.Models.Shared;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FaceitLib.Models
{
    public class TournamentBrackets
    {
        public string Game { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public List<TournamentBracketMatch> Matches { get; set; }
        public List<TournamentDetailRounds> Rounds { get; set; }
    }

    public class TournamentBracketRound
    {
        [JsonProperty(PropertyName = "substitution_time")]
        public int SubstitutionTime { get; set; }
        public int Round { get; set; }

        [JsonProperty(PropertyName = "best_of")]
        public int BestOf { get; set; }

        public string Label { get; set; }

        [JsonProperty(PropertyName = "substitutions_allowed")]
        public bool IsSubstitutionsAllowed { get; set; }
        public int Matches { get; set; }

        [JsonProperty(PropertyName = "starts_asap")]
        public bool IsStartsASAP { get; set; }
    }

    public class TournamentBracketMatch
    {
        [JsonProperty(PropertyName = "match_id")]
        public string MatchID { get; set; }

        public int Round { get; set; }
        public string State { get; set; }
        public int Position { get; set; }
        public TournamentBracketTeams Teams { get; set; }
        public Results Results { get; set; }

        [JsonProperty(PropertyName = "faceit_url")]
        public string FaceitURL { get; set; }

    }


    public class TournamentBracketTeams
    {
        public TournamentBracketFaction Faction1 { get; set; }
        public TournamentBracketFaction Faction2 { get; set; }
    }

    public class TournamentBracketFaction
    {
        [JsonProperty(PropertyName = "team_id")]
        public string TeamID { get; set; }
        public string Nickname { get; set; }
        public string Avatar { get; set; }
    }
}
