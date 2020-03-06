using Newtonsoft.Json;
using System.Collections.Generic;

namespace FaceitLib.Models.ClassObjectLists
{
    public class TournamentListObject
    {
        [JsonProperty(PropertyName = "anticheat_required")]
        public bool IsAnticheatRequired { get; set; }

        [JsonProperty(PropertyName = "custom")]
        public bool IsCustom { get; set; }

        [JsonProperty(PropertyName = "faceit_url")]
        public string FaceitURL { get; set; }

        [JsonProperty(PropertyName = "featured_image")]
        public string FeaturedImage { get; set; }

        [JsonProperty(PropertyName = "invite_type")]
        public string InviteType { get; set; }

        [JsonProperty(PropertyName = "match_type")]
        public string MatchType { get; set; }

        [JsonProperty(PropertyName = "max_skill")]
        public int MaxSkill { get; set; }

        public string Name { get; set; }

        [JsonProperty(PropertyName = "number_of_players")]
        public int NumberOfPlayers { get; set; }

        [JsonProperty(PropertyName = "number_of_players_checkedin")]
        public int NumberOfPlayersCheckedIn { get; set; }

        [JsonProperty(PropertyName = "number_of_players_joined")]
        public int NumberOfPlayersJoined { get; set; }

        [JsonProperty(PropertyName = "number_of_players_participants")]
        public int NumberOfPlayersParticipants { get; set; }

        [JsonProperty(PropertyName = "organizer_id")]
        public string OrganizerID { get; set; }

        [JsonProperty(PropertyName = "subscriptions_count")]
        public int SubscriptionsCount { get; set; }

        [JsonProperty(PropertyName = "team_size")]
        public int TeamSize { get; set; }

        [JsonProperty(PropertyName = "total_prize")]
        public float TotalPrize { get; set; } // Not sure what this will return as since I can't get it to. Put a float here just to be safe

        [JsonProperty(PropertyName = "tournament_id")]
        public string TournamentID { get; set; }

        [JsonProperty(PropertyName = "whitelist_countries")]
        public List<string> WhitelistCountries { get; set; }
    }

    public class TournamentListObjectExtended : TournamentListObject
    {

        [JsonProperty(PropertyName = "game_id")]
        public string GameID { get; set; }

        [JsonProperty(PropertyName = "membership_type")]
        public string MembershipType { get; set; }

        [JsonProperty(PropertyName = "min_skill")]
        public int MinSkill { get; set; }

        [JsonProperty(PropertyName = "prize_type")]
        public string PrizeType { get; set; }
        public string Region { get; set; }

        [JsonProperty(PropertyName = "started_at")]
        public int StartedAt { get; set; }
        public string Status { get; set; }
    }
}
