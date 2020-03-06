using Newtonsoft.Json;
using System.Collections.Generic;

namespace FaceitLib.Models.Shared
{
    public class Faction
    {
        [JsonProperty(PropertyName = "faction_id")]
        public string FactionID { get; set; }
        public string Leader { get; set; }
        public string Avatar { get; set; }
        public List<Roster> Roster { get; set; }
        public List<Rosterv1> Rosterv1 { get; set; }

        [JsonProperty(PropertyName = "substituted")]
        public bool IsSubstituted { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }

    public class Rosterv1
    {
        [JsonProperty(PropertyName = "csgo_id")]
        public string CSGOID { get; set; }

        [JsonProperty(PropertyName = "team_id")]
        public string TeamID { get; set; }

        [JsonProperty(PropertyName = "csgo_skill_level_label")]
        public string CSGOSkillLevelLabel { get; set; }
        [JsonProperty(PropertyName = "csgo_skill_level")]
        public int CSGOSkillLevel { get; set; }

        public string Nickname { get; set; }

        public string Guid { get; set; }

        [JsonProperty(PropertyName = "csgo_name")]
        public string CSGOName { get; set; }

        public string Avatar { get; set; }

        [JsonProperty(PropertyName = "league_icon_url")]
        public string LeagueIconURL { get; set; }
    }
}
