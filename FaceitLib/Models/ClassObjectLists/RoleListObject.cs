using Newtonsoft.Json;

namespace FaceitLib.Models.ClassObjectLists
{
    public class RoleListObject
    {
        public string Color { get; set; }
        public string Name { get; set; }
        public int Ranking { get; set; }

        [JsonProperty(PropertyName = "role_id")]
        public string RoleID { get; set; }

        [JsonProperty(PropertyName = "visible_on_chat")]
        public bool IsVisibleOnChat { get; set; }
    }
}
