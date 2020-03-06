using Newtonsoft.Json;

namespace FaceitLib.Models.Shared
{
    public class OrganizerData
    {
        public string Avatar { get; set; }
        public string Cover { get; set; }
        public string Description { get; set; }
        public string Facebook { get; set; }

        [JsonProperty(PropertyName = "faceit_url")]
        public string FaceitURL { get; set; }

        [JsonProperty(PropertyName = "followers_count")]
        public int FollowersCount { get; set; }
        public string Name { get; set; }

        [JsonProperty(PropertyName = "organizer_id")]
        public string OrganizerID { get; set; }
        public string Twitch { get; set; }
        public string Twitter { get; set; }
        public string Type { get; set; }
        public string Vk { get; set; }
        public string Website { get; set; }
        public string Youtube { get; set; }
    }
}
