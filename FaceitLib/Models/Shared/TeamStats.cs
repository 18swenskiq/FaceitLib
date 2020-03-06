using Newtonsoft.Json;

namespace FaceitLib.Models.Shared
{
    public class TeamStats
    {
        [JsonProperty(PropertyName="Second Half Score")]
        public string SecondHalfScore { get; set; }

        public string Team { get; set; }

        [JsonProperty(PropertyName ="Team Win")]
        public string TeamWin { get; set; }

        [JsonProperty(PropertyName ="Final Score")]
        public string FinalScore { get; set; }

        [JsonProperty(PropertyName ="Team Headshot")]
        public string TeamHeadshot { get; set; }
        
        [JsonProperty(PropertyName ="Overtime score")]
        public string OvertimeScore { get; set; }

        [JsonProperty(PropertyName ="First Half Score")]
        public string FirstHalfScore { get; set; }
    }
}
