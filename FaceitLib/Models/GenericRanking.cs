using FaceitLib.Models.ClassObjectLists;
using System.Collections.Generic;

namespace FaceitLib.Models
{
    public class GenericRanking
    {
        public int End { get; set; }
        public List<GenericRankingListObject> Items { get; set; }
        public LeaderboardListObject Leaderboard { get; set; }
        public int Start { get; set; }
    }
}
