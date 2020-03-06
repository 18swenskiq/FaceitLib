using Newtonsoft.Json;

namespace FaceitLib.Models.SearchResults
{
    public class ChampionshipHubTournamentSearch
    {
        [JsonProperty(PropertyName = "competition_id")]
        public string CompetitionID { get; set; }

        [JsonProperty(PropertyName = "competition_type")]
        public string CompetitionType { get; set; }

        public string Game { get; set; }
        public string Name { get; set; }

        [JsonProperty(PropertyName = "number_of_members")]
        public int NumberOfMembers { get; set; }

        [JsonProperty(PropertyName = "organizer_id")]
        public string OrganizerID { get; set; }

        [JsonProperty(PropertyName = "organizer_name")]
        public string OrganizerName { get; set; }

        [JsonProperty(PropertyName = "organizer_type")]
        public string OrganizerType { get; set; }

        [JsonProperty(PropertyName = "players_checkin")]
        public int PlayersCheckedin { get; set; }

        [JsonProperty(PropertyName = "players_joined")]
        public int PlayersJoined { get; set; }

        [JsonProperty(PropertyName = "prize_type")]
        public string PrizeType { get; set; }

        public string Region { get; set; }
        public int Slots { get; set; }

        [JsonProperty(PropertyName = "started_at")]
        public int StartedAt { get; set; }
        public string Status { get; set; }

        [JsonProperty(PropertyName = "total_prize")]
        public string TotalPrize { get; set; }
    }
}
