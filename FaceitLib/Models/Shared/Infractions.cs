using Newtonsoft.Json;

namespace FaceitLib.Models.Shared
{
    public class Infractions
    {

        [JsonProperty(PropertyName = "last_infraction_date")]
        public string LastInfractionDate { get; set; }
        public int AFK { get; set; }
        public int Leaver { get; set; }

        [JsonProperty(PropertyName = "qm_not_checkedin")]
        public int QMNotCheckedin { get; set; }

        [JsonProperty(PropertyName = "qm_not_voted")]
        public int QMNotVoted { get; set; }
    }
}
