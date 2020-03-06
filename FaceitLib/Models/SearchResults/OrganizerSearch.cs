using Newtonsoft.Json;
using System.Collections.Generic;

namespace FaceitLib.Models.SearchResults
{
    public class OrganizerSearch
    {
        [JsonProperty(PropertyName = "active")]
        public bool IsActive { get; set; }

        public string Avatar { get; set; }
        public List<string> Countries { get; set; }
        public List<string> Games { get; set; }
        public string Name { get; set; }

        [JsonProperty(PropertyName = "organizer_id")]
        public string OrganizerID { get; set; }

        [JsonProperty(PropertyName = "partner")]
        public bool IsPartner { get; set; }

        public List<string> Regions { get; set; }
    }
}
