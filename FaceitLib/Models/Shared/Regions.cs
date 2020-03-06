using Newtonsoft.Json;

namespace FaceitLib.Models.Shared
{
    public class Regions
    {
        public RegionData US { get; set; }
        public RegionData EU { get; set; }
        public RegionData SA { get; set; }
        public RegionData SEA { get; set; }
        public RegionData OCE { get; set; }
    }

    public class RegionData
    {
        [JsonProperty(PropertyName = "selected_ladder_id")]
        public string SelectedLadderID { get; set; }
    }
}
