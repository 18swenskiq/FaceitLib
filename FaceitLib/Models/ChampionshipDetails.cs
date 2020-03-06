using FaceitLib.Models.Shared;
using Newtonsoft.Json;
using System;

namespace FaceitLib.Models
{
    public class ChampionshipDetails
    {
        [JsonProperty(PropertyName = "anticheatrequired")]
        public bool IsAnticheatRequired { get; set; }
        public string Avatar { get; set; }

        [JsonProperty(PropertyName = "background_image")]
        public string BackgroundImage { get; set; }

        [JsonProperty(PropertyName = "championship_id")]
        public string ChampionshipID { get; set; }

        [JsonProperty(PropertyName = "championship_start")]
        public Int64 ChampionshipStart { get; set; }

        [JsonProperty(PropertyName = "checkin_clear")]
        public Int64 CheckinClear { get; set; }

        [JsonProperty(PropertyName = "checkin_enabled")]
        public bool IsCheckinEnabled { get; set; }

        [JsonProperty(PropertyName = "checkin_start")]
        public Int64 CheckinStart { get; set; }

        [JsonProperty(PropertyName = "cover_image")]
        public string CoverImage { get; set; }

        [JsonProperty(PropertyName = "current_subscriptions")]
        public int CurrentSubscriptions { get; set; }
        public string Description { get; set; }

        [JsonProperty(PropertyName = "faceit_url")]
        public string FaceitURL { get; set; }

        [JsonProperty(PropertyName = "featured")]
        public bool IsFeatured { get; set; }

        [JsonProperty(PropertyName = "full")]
        public bool IsFull { get; set; }

        [JsonProperty(PropertyName = "game_data")]
        public GameData GameData { get; set; }

        [JsonProperty(PropertyName = "game_id")]
        public string GameID { get; set; }
        public string ID { get; set; }

        [JsonProperty(PropertyName = "join_checks")]
        public JoinChecks JoinChecks { get; set; }
        public string Name { get; set; }

        [JsonProperty(PropertyName = "organizer_data")]
        public OrganizerData OrganizerData { get; set; }

        [JsonProperty(PropertyName = "organizer_id")]
        public string OrganizerID { get; set; }
        public string Region { get; set; }

        [JsonProperty(PropertyName = "rules_id")]
        public string RulesID { get; set; }
        public Schedule Schedule { get; set; }

        [JsonProperty(PropertyName = "seeding_strategy")]
        public string SeedingStrategy { get; set; }
        public int Slots { get; set; }
        public string Status { get; set; }

        [JsonProperty(PropertyName = "subscription_end")]
        public Int64 SubscriptionEnd { get; set; }

        [JsonProperty(PropertyName = "subscription_start")]
        public Int64 SubscriptionStart { get; set; }

        [JsonProperty(PropertyName = "subscriptions_locked")]
        public bool IsSubscriptionsLocked { get; set; }

        [JsonProperty(PropertyName = "substitutions_configuration")]
        public SustitutionConfiguration SubstitutionsConfiguration { get; set; }

        [JsonProperty(PropertyName = "total_groups")]
        public int TotalGroups { get; set; }

        [JsonProperty(PropertyName = "total_rounds")]
        public int TotalRounds { get; set; }
        public string Type { get; set; }
    }
}
