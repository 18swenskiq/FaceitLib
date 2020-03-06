using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FaceitLib.Models.Shared
{
    public class Entity
    {
        [JsonProperty(PropertyName = "class_name")]
        public string ClassName { get; set; }

        [JsonProperty(PropertyName = "className")]
        public string ClassName2 { set { ClassName = value; } }

        [JsonProperty(PropertyName = "get_map_id")]
        public string MapID { get; set; }

        [JsonProperty(PropertyName = "image_sm")]
        public string ImageSmall {get; set;}
        public string Name { get; set; }

        public string Country { get; set; }

        [JsonProperty(PropertyName = "game_location_id")]
        public string GameLocationID { get; set; }

        public string Guid { get; set; }

        [JsonProperty(PropertyName = "image_lg")]
        public string ImageLarge { get; set; }
    }
}
