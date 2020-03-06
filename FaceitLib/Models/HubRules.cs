using Newtonsoft.Json;

namespace FaceitLib.Models
{
    public class HubRules
    {
        public string Body { get; set; }
        public string Game { get; set; }
        public string Name { get; set; }
        public string Organizer { get; set; }

        [JsonProperty(PropertyName = "rule_id")]
        public string RuleID { get; set; }
    }
}
