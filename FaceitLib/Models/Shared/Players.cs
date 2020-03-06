using Newtonsoft.Json;

namespace FaceitLib.Models.Shared
{
    public class Players
    {
        public string Nickname { get; set; }

        [JsonProperty(PropertyName = "player_id")]
        public string PlayerID { get; set; }

        [JsonProperty(PropertyName = "player_stats")]
        public PlayerStats PlayerStats { get; set; }
    }

    public class PlayerStats
    {
        [JsonProperty(PropertyName ="Headshots %")]
        public string HeadshotPercentage { get; set; }
        public string Headshot { get; set; }
        public string Deaths { get; set; }
        
        [JsonProperty(PropertyName ="Quadro Kills")]
        public string QuadroKills { get; set; }
        public string Kills { get; set; }
        public string Assists { get; set; }
        public string MVPs { get; set; }
        public string Result { get; set; }
        
        [JsonProperty(PropertyName ="Penta Kills")]
        public string PentaKills { get; set; }
        
        [JsonProperty(PropertyName ="K/D Ratio")]
        public string KD_Ratio { get; set; }

        [JsonProperty(PropertyName ="Triple Kills")]
        public string TripleKills { get; set; }

        [JsonProperty(PropertyName ="K/R Ratio")]
        public string KR_Ratio { get; set; }
    }
}
