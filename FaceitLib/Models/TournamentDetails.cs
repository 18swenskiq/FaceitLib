using FaceitLib.Models.Shared;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace FaceitLib.Models
{
    public class TournamentDetails
    {
        [JsonProperty(PropertyName = "competition_id")]
        public string CompetitionID { get; set; }

        [JsonProperty(PropertyName = "tournament_id")]
        public string TournamentID { get; set; }

        public string Description { get; set; }

        [JsonProperty(PropertyName = "cover_image")]
        public string CoverImage { get; set; }

        [JsonProperty(PropertyName = "featured_image")]
        public string FeaturedImage { get; set; }

        [JsonProperty(PropertyName = "game_id")]
        public string GameID { get; set; }

        [JsonProperty(PropertyName = "custom")]
        public bool IsCustom { get; set; }

        public TournamentVoting Voting { get; set; }

        [JsonProperty(PropertyName = "invite_type")]
        public string InviteType { get; set; }

        [JsonProperty(PropertyName = "membership_type")]
        public string MembershipType { get; set; }

        [JsonProperty(PropertyName = "match_type")]
        public string MatchType { get; set; }

        [JsonProperty(PropertyName = "best_of")]
        public BestOf BestOf { get; set; }

        [JsonProperty(PropertyName = "max_skill")]
        public int MaxSkill { get; set; }

        [JsonProperty(PropertyName = "min_skill")]
        public int MinSkill { get; set; }

        public string Name { get; set; }

        [JsonProperty(PropertyName = "number_of_players")]
        public int NumberOfPlayers { get; set; }

        [JsonProperty(PropertyName = "number_of_players_joined")]
        public int NumberOfPlayersJoined { get; set; }

        [JsonProperty(PropertyName = "number_of_players_checkedin")]
        public int NumberOfPlayersCheckedin { get; set; }

        [JsonProperty(PropertyName = "number_of_players_participants")]
        public int NumberOfPlayersParticipants { get; set; }

        [JsonProperty(PropertyName = "organizer_id")]
        public string OrgnaizerID { get; set; }

        public string Rule { get; set; }

        [JsonProperty(PropertyName = "started_at")]
        public Int64 StartedAt { get; set; }
        public string Status { get; set; }

        [JsonProperty(PropertyName = "team_size")]
        public int TeamSize { get; set; }

        [JsonProperty(PropertyName = "prize_type")]
        public string PrizeType { get; set; }

        [JsonProperty(PropertyName = "total_prize")]
        public string TotalPrize { get; set; }

        [JsonProperty(PropertyName = "whitelist_countries")]
        public List<string> WhitelistCountries { get; set; }

        [JsonProperty(PropertyName = "anticheat_required")]
        public bool IsAnticheatRequired { get; set; }

        [JsonProperty(PropertyName = "calculated_elo")]
        public bool IsCalculatedElo { get; set; }

        [JsonProperty(PropertyName = "substitutions_allowed")]
        public int SubstitutionsAllowed { get; set; }

        [JsonProperty(PropertyName = "substitutes_allowed")]
        public int SubstitutesAllowed { get; set; }

        public List<TournamentDetailRounds> Rounds { get; set; }

        [JsonProperty(PropertyName = "faceit_url")]
        public string FaceitURL { get; set; }

        [JsonProperty(PropertyName = "organizer_data")]
        public OrganizerData OrganizerData { get; set; }

        [JsonProperty(PropertyName = "game_data")]
        public GameData GameData { get; set; }
        public List<Platforms> Platforms { get; set; }
        public List<string> Regions { get; set; }

        [JsonProperty(PropertyName = "parent_game_id")]
        public string ParentGameID { get; set; }

        public int Order { get; set; }

    }

    public class TournamentDetailRounds
    {
        [JsonProperty(PropertyName = "substitution_time")]
        public int SubstitutionTime { get; set; }

        public int Round { get; set; }

        [JsonProperty(PropertyName = "best_of")]
        public int BestOf { get; set; }
        public string Label { get; set; }

        [JsonProperty(PropertyName = "substitutions_allowed")]
        public bool IsSubstitutionsAllowed { get; set; }

        public int Matches { get; set; }

        [JsonProperty(PropertyName = "starts_asap")]
        public bool IsStartsASAP { get; set; }
    }

    public class BestOf
    {
        [JsonProperty(PropertyName = "1")]
        public int One { get; set; }

        [JsonProperty(PropertyName = "2")]
        public int Two { get; set; }

        [JsonProperty(PropertyName = "3")]
        public int Three { get; set; }
    }

    public class TournamentVoting
    {
        [JsonProperty(PropertyName = "entity_types")]
        public List<string> EntityTypes { get; set; }
        public TournamentVotingDetails<TournamentVotingDetailsServer> Location { get; set; }

        [JsonProperty(PropertyName = "expire_seconds")]
        public int ExpireSeconds { get; set; }
        public TournamentVotingDetails<TournamentVotingDetailsMap> Map { get; set; }
    }

    public class TournamentVotingDetails<T>
    {
        public List<string> Drop { get; set; }

        [JsonProperty(PropertyName = "required_pick")]
        public int RequiredPick { get; set; }
        public List<T> Entities { get; set; }
        public List<string> Pick { get; set; }
        public List<string> Config { get; set; }
    }

    public class TournamentVotingDetailsServer
    {
        public string Country { get; set; }

        [JsonProperty(PropertyName = "game_location_id")]
        public string GameLocationID { get; set; }

        public string Name { get; set; }
        public string Guid { get; set; }
    }

    public class TournamentVotingDetailsMap
    {
        [JsonProperty(PropertyName = "game_map_id")]
        public string GameMapID { get; set; }

        public string Name { get; set; }
        public string Guid { get; set; }

        [JsonProperty(PropertyName = "class_name")]
        public string ClassName { get; set; }
    }

}
