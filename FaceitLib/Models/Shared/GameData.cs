using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FaceitLib.Models.Shared
{
    public class GameData
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
