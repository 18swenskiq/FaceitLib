using Newtonsoft.Json;
using System.Collections.Generic;

namespace FaceitLib.Models.SearchResults
{
    public class PlayerSearch
    {
        public string Avatar { get; set; }
        public string Country { get; set; }
        public List<PlayerSearchGames> Games { get; set; }
        public string Nickname { get; set; }

        [JsonProperty(PropertyName = "player_id")]
        public string PlayerID { get; set; }
        public string Status { get; set; }

        [JsonProperty(PropertyName = "verified")]
        public bool IsVerified { get; set; }
    }

    public class PlayerSearchGames
    {
        public string Name { get; set; }

        [JsonProperty(PropertyName = "skill_level")]
        public string SkillLevel { get; set; }
    }
}
