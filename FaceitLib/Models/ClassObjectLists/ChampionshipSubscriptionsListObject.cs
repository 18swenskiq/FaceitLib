using System.Collections.Generic;

namespace FaceitLib.Models.ClassObjectLists
{
    public class ChampionshipSubscriptionsListObject
    {
        public string Coach { get; set; }
        public string Coleader { get; set; }
        public int Group { get; set; }
        public string Leader { get; set; }
        public List<string> Roster { get; set; }
        public string Status { get; set; }
        public List<string> Substitutes { get; set; }
    }
}
