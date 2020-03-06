using FaceitLib.Models.Shared;
using Newtonsoft.Json;

namespace FaceitLib.Models
{
    public class HubDetails
    {
        public string Avatar { get; set; }

        [JsonProperty(PropertyName = "background_image")]
        public string BackgroundImage { get; set; }

        [JsonProperty(PropertyName = "chat_room_id")]
        public string ChatRoomID { get; set; }

        [JsonProperty(PropertyName = "cover_image")]
        public string CoverImage { get; set; }
        public string Description { get; set; }

        [JsonProperty(PropertyName = "faceit_url")]
        public string FaceitURL { get; set; }

        [JsonProperty(PropertyName = "game_data")]
        public GameData GameData { get; set; }

        [JsonProperty(PropertyName = "game_id")]
        public string GameID { get; set; }

        [JsonProperty(PropertyName = "hub_id")]
        public string HubID { get; set; }

        [JsonProperty(PropertyName = "join_permission")]
        public string JoinPermission { get; set; }

        [JsonProperty(PropertyName = "max_skill_level")]
        public int MaxSkillLevel { get; set; }

        [JsonProperty(PropertyName = "min_skill_level")]
        public int MinSkillLevel { get; set; }
        public string Name { get; set; }

        [JsonProperty(PropertyName = "organizer_data")]
        public OrganizerData OrganizerData { get; set; }

        [JsonProperty(PropertyName = "organizer_id")]
        public string OrganizerID { get; set; }

        [JsonProperty(PropertyName = "players_joined")]
        public int PlayersJoined { get; set; }
        public string Region { get; set; }

        [JsonProperty(PropertyName = "rule_id")]
        public string RuleID { get; set; }
    }
}
