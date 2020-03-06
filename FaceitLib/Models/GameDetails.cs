using FaceitLib.Models.Shared;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace FaceitLib.Models
{
    public class GameDetails
    {
        public Assets Assets { get; set; }

        [JsonProperty(PropertyName = "game_id")]
        public string GameID { get; set; }

        [JsonProperty(PropertyName = "long_label")]
        public string LongLabel { get; set; }
        public int Order { get; set; }

        [JsonProperty(PropertyName = "parent_game_id")]
        public string ParentGameID { get; set; }
        public List<string> Platforms { get; set; }
        public List<string> Regions { get; set; }

        [JsonProperty(PropertyName = "short_label")]
        public string ShortLabel { get; set; }
    }
}
