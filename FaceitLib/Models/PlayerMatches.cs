using FaceitLib.Models.ClassObjectLists;

namespace FaceitLib.Models
{
    public class PlayerMatches : GenericContainer<PlayerMatchListObject>
    {
        public int From { get; set; }
    }
}
