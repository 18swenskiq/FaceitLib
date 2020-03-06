using FaceitLib.Models.Shared;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace FaceitLib.Models.ClassObjectLists
{
    public class PlayerMatchListObject
    {
        [JsonProperty(PropertyName = "competition_id")]
        public string CompetitionID { get; set; }

        [JsonProperty(PropertyName = "competition_name")]
        public string CompetitionName { get; set; }

        [JsonProperty(PropertyName = "competition_type")]
        public string CompetitionType { get; set; }

        [JsonProperty(PropertyName = "faceit_url")]
        public string FaceitURL { get; set; }

        [JsonProperty(PropertyName = "finished_at")]
        public int FinishedAt { get; set; }

        [JsonProperty(PropertyName = "game_id")]
        public string GameID { get; set; }

        [JsonProperty(PropertyName = "game_mode")]
        public string GameMode { get; set; }

        [JsonProperty(PropertyName = "match_id")]
        public string MatchID { get; set; }

        [JsonProperty(PropertyName = "match_type")]
        public string MatchType { get; set; }

        [JsonProperty(PropertyName = "max_players")]
        public int MaxPlayers { get; set; }

        [JsonProperty(PropertyName = "organizer_id")]
        public string OrganizerID { get; set; }

        [JsonProperty(PropertyName = "playing_players")]
        public List<string> PlayingPlayers { get; set; }


        public string Region { get; set; }
        public Results Results { get; set; }

        [JsonProperty(PropertyName = "started_at")]
        public int StartedAt { get; set; }
        public string Status { get; set; }
        public PlayerMatchListTeams Teams { get; set; }
    }

    public class PlayerMatchListTeams
    {
        public PlayerMatchListFactions Faction1 { get; set; }
        public PlayerMatchListFactions Faction2 { get; set; }

    }

    public class PlayerMatchListFactions
    {
        [JsonProperty(PropertyName = "team_id")]
        public string TeamID { get; set; }
        public string Nickname { get; set; }
        public string Avatar { get; set; }
        public string Type { get; set; }
        public List<PlayerMatchListPlayer> Players { get; set; }
    }

    public class PlayerMatchListPlayer
    {

        [JsonProperty(PropertyName = "player_id")]
        public string PlayerID { get; set; }
        public string Nickname { get; set; }
        public string Avatar { get; set; }

        [JsonProperty(PropertyName = "skill_level")]
        public int SkillLevel { get; set; }

        [JsonProperty(PropertyName = "game_player_id")]
        public string GamePlayerID { get; set; }

        [JsonProperty(PropertyName = "game_player_name")]
        public string GamePlayerName { get; set; }

        [JsonProperty(PropertyName = "faceit_url")]
        public string FaceitURL { get; set; }
    }
}
