using Newtonsoft.Json;
using System.Collections.Generic;

namespace FaceitLib.Models.Shared
{
    public class JoinChecks
    {

        [JsonProperty(PropertyName = "allowed_team_types")]
        public List<string> AllowedTeamTypes { get; set; }

        [JsonProperty(PropertyName = "blacklist_geo_countries")]
        public List<string> BlacklistGeoCountries { get; set; }

        [JsonProperty(PropertyName = "join_policy")]
        public string JoinPolicy { get; set; }

        [JsonProperty(PropertyName = "max_skill_level")]
        public int MaxSkillLevel { get; set; }

        [JsonProperty(PropertyName = "membership_type")]
        public string MembershipType { get; set; }

        [JsonProperty(PropertyName = "min_skill_level")]
        public int MinSkillLevel { get; set; }

        [JsonProperty(PropertyName = "whitelist_geo_countries")]
        public List<string> WhitelistGeoCountries { get; set; }

        [JsonProperty(PropertyName = "whitelist_geo_countries_min_players")]
        public int WhitelistGeoCountriesMinPlayers { get; set; }
    }
}
