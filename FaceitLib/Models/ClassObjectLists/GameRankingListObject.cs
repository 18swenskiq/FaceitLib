using Newtonsoft.Json;

namespace FaceitLib.Models.ClassObjectLists
{
    public class GameRankingListObject
    {
        public string Country { get; set; }

        [JsonProperty(PropertyName = "faceit_elo")]
        public int FaceitELO { get; set; }

        [JsonProperty(PropertyName = "game_skill_level")]
        public int GameSkillLevel { get; set; }

        public string Nickname { get; set; }

        [JsonProperty(PropertyName = "player_id")]
        public string PlayerID { get; set; }
        public int Position { get; set; }
    }
}
