using FaceitLib.Models.Shared;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace FaceitLib.Models
{
    public class HubStats
    {
        [JsonProperty(PropertyName = "game_id")]
        public string GameID { get; set; }
        public List<Players> Players { get; set; }
    }
}
