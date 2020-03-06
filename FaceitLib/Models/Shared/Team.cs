using Newtonsoft.Json;
using System.Collections.Generic;

namespace FaceitLib.Models.Shared
{
    public class Team
    {
        public string Avatar { get; set; }

        [JsonProperty(PropertyName = "ChatRoomID")]
        public string ChatRoomID { get; set; }

        [JsonProperty(PropertyName = "cover_image")]
        public string CoverImage { get; set; }
        public string Description { get; set; }
        public string Facebook { get; set; }

        [JsonProperty(PropertyName = "faceit_url")]
        public string FaceitURL { get; set; }
        public string Game { get; set; }
        public string Leader { get; set; }
        public List<Member> Members { get; set; }
        public string Name { get; set; }
        public string Nickname { get; set; }

        [JsonProperty(PropertyName = "team_id")]
        public string TeamID { get; set; }

        [JsonProperty(PropertyName = "team_type")]
        public string TeamType { get; set; }
        public string Twitter { get; set; }
        public string Website { get; set; }
        public string Youtube { get; set; }
    }
}
