using FaceitLib.Models.Shared;
using Newtonsoft.Json;
namespace FaceitLib.Models.ClassObjectLists
{
    public class GenericRankingListObject
    {
        [JsonProperty(PropertyName = "current_streak")]
        public int CurrentWinStreak { get; set; }
        public int Draw { get; set; }
        public int Lost { get; set; }
        public int Played { get; set; }
        public Player Player { get; set; }
        public int Points { get; set; }
        public int Position { get; set; }

        [JsonProperty(PropertyName = "win_rate")]
        public float WinRate { get; set; }
        public int Won { get; set; }
    }
}
