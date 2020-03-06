using Newtonsoft.Json;

namespace FaceitLib.Models.SearchResults
{
    public class TeamSearch
    {
        public string Avatar { get; set; }

        [JsonProperty(PropertyName = "chat_room_id")]
        public string ChatRoomID { get; set; }

        [JsonProperty(PropertyName = "faceit_url")]
        public string FaceitURL { get; set; }

        public string Game { get; set; }
        public string Name { get; set; }

        [JsonProperty(PropertyName = "team_id")]
        public string TeamID { get; set; }

        [JsonProperty(PropertyName = "verified")]
        public bool IsVerified { get; set; }
    }
}
