using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FaceitLib.Models.Shared
{
    public class Roster
    {
        [JsonProperty(PropertyName = "anticheat_required")]
        public bool IsAnticheatRequired { get; set; }
        public string Avatar { get; set; }

        [JsonProperty(PropertyName = "game_player_id")]
        public string GamePlayerID { get; set; }

        [JsonProperty(PropertyName = "game_player_name")]
        public string GamePlayerName { get; set; }

        [JsonProperty(PropertyName = "game_skill_level")]
        public int GameSkillLevel { get; set; }
        public string Membership { get; set; }
        public string Nickname { get; set; }

        [JsonProperty(PropertyName = "player_id")]
        public string PlayerID { get; set; }
    }
}
