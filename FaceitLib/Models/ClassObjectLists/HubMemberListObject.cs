using Newtonsoft.Json;
using System.Collections.Generic;

namespace FaceitLib.Models.ClassObjectLists
{
    public class HubMemberListObject
    {
        public string Avatar { get; set; }

        [JsonProperty(PropertyName = "faceit_url")]
        public string FaceitURL { get; set; }
        public string Nickname { get; set; }
        public List<string> Roles { get; set; }

        [JsonProperty(PropertyName = "user_id")]
        public string UserID { get; set; }
    }
}
