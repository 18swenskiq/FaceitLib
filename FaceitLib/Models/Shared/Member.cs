using Newtonsoft.Json;
using System.Collections.Generic;

namespace FaceitLib.Models.Shared
{
    public class Member
    {
        public string Avatar { get; set; }
        public string Country { get; set; }

        [JsonProperty(PropertyName = "faceit_url")]
        public string FaceitURL { get; set; }

        [JsonProperty(PropertyName = "membership_type")]
        public string MembershipType { get; set; }
        public List<string> Memberships { get; set; }
        public string Nickname { get; set; }

        [JsonProperty(PropertyName = "skill_level")]
        public int SkillLevel { get; set; }

        [JsonProperty(PropertyName = "user_id")]
        public string UserID { get; set; }
    }
}
