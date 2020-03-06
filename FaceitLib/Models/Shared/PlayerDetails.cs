using Newtonsoft.Json;
using System.Collections.Generic;

namespace FaceitLib.Models.Shared
{
    public class PlayerDetails
    {

        [JsonProperty(PropertyName = "player_id")]
        public string PlayerID { get; set; }

        public string Nickname { get; set; }
        public string Avatar { get; set; }
        public string Country { get; set; }

        [JsonProperty(PropertyName = "cover_image")]
        public string CoverImage { get; set; }

        [JsonProperty(PropertyName = "cover_featured_image")]
        public string CoverFeaturedImage { get; set; }
        public Infractions Infractions { get; set; }
        public Platforms Platforms { get; set; }
        public PlayerGameData Games { get; set; }
        public PlayerSettings Settings { get; set; }

        [JsonProperty(PropertyName = "friends_ids")]
        public List<string> FriendsIDs { get; set; }
        public object Bans { get; set; }    // I think this is supposed to be a list of strings but the API isn't very useful

        [JsonProperty(PropertyName = "new_steam_id")]
        public string NewSteamID { get; set; }

        [JsonProperty(PropertyName = "steam_id_64")]
        public string SteamID64 { get; set; }

        [JsonProperty(PropertyName = "steam_nickname")]
        public string SteamNickname { get; set; }

        [JsonProperty(PropertyName = "membership_type")]
        public string MembershipType { get; set; }
        public List<string> Memberships { get; set; }

        [JsonProperty(PropertyName = "faceit_url")]
        public string FaceitURL { get; set; }
    }

    public class PlayerSettings
    {
        public string Language { get; set; }
    }


    public class PlayerGameData
    {
        public PlayerGameDataDetails CSGO { get; set; }
        public PlayerGameDataDetails TF2 { get; set; }
        public PlayerGameDataDetails DOTA2 { get; set; }

        [JsonProperty(PropertyName = "rl_XBOX_PC")]
        public PlayerGameDataDetails RLXBOXPC { get; set; }
        public PlayerGameDataDetails CSCO { get; set; }

        [JsonProperty(PropertyName = "lol")]
        public PlayerGameDataDetails LeagueOfLegends { get; set; }

        [JsonProperty(PropertyName = "lol_EUW")]
        public PlayerGameDataDetails LeagueOfLegendsEUWest { get; set; }

        [JsonProperty(PropertyName = "lol_EUN")]
        public PlayerGameDataDetails LeagueOfLegendsEUNorth { get; set; }

        [JsonProperty(PropertyName = "lol_NA")]
        public PlayerGameDataDetails LeagueOfLegendsNA { get; set; }

        [JsonProperty(PropertyName = "halo_3")]
        public PlayerGameDataDetails Halo3 { get; set; }
        public PlayerGameDataDetails QuakeLive { get; set; }

        [JsonProperty(PropertyName = "quake_champions")]
        public PlayerGameDataDetails QuakeChampions { get; set; }

        [JsonProperty(PropertyName = "gs_csgo")]
        public PlayerGameDataDetails GSCSGO { get; set; }
        public PlayerGameDataDetails FIFA20 { get; set; }

        [JsonProperty(PropertyName = "minion_masters")]
        public PlayerGameDataDetails MinionMasters { get; set; }

        [JsonProperty(PropertyName = "starcraft2_EU")]
        public PlayerGameDataDetails Starcraft2EU { get; set; }

        [JsonProperty(PropertyName = "wot")]
        public PlayerGameDataDetails WorldOfTanks { get; set; }

        [JsonProperty(PropertyName = "wot_EU")]
        public PlayerGameDataDetails WorldOfTanksEU { get; set; }

        [JsonProperty(PropertyName = "wot_NA")]
        public PlayerGameDataDetails WorldOfTanksNA { get; set; }

        [JsonProperty(PropertyName = "wot_RU")]
        public PlayerGameDataDetails WorldOfTanksRussia { get; set; }
        public PlayerGameDataDetails Smite { get; set; }

        [JsonProperty(PropertyName = "smite_xbox")]
        public PlayerGameDataDetails SmiteXbox { get; set; }

        [JsonProperty(PropertyName = "rainbow_6")]
        public PlayerGameDataDetails RainbowSixSiege { get; set; }
        public PlayerGameDataDetails DirtyBomb { get; set; }

        [JsonProperty(PropertyName = "nhl_19")]
        public PlayerGameDataDetails NHL19 { get; set; }

        [JsonProperty(PropertyName = "nhl_20_parent")]
        public PlayerGameDataDetails NHL20Parent { get; set; }

        [JsonProperty(PropertyName = "nhl_18_XBOX")]
        public PlayerGameDataDetails NHL18XBOX { get; set; }

        [JsonProperty(PropertyName = "nhl_19_XBOX")]
        public PlayerGameDataDetails NHL19XBOX { get; set; }

        [JsonProperty(PropertyName = "nhl_20_xbox")]
        public PlayerGameDataDetails NHL20XBOX { get; set; }

        [JsonProperty(PropertyName = "nhl_18_PS4")]
        public PlayerGameDataDetails NHL18PS4 { get; set; }

        [JsonProperty(PropertyName = "nhl_19_PS4")]
        public PlayerGameDataDetails NHL19PS4 { get; set; }

        [JsonProperty(PropertyName = "nhl_20_ps4")]
        public PlayerGameDataDetails NHL20PS4 { get; set; }

        [JsonProperty(PropertyName = "apex")]
        public PlayerGameDataDetails ApexLegends { get; set; }

        [JsonProperty(PropertyName = "rocket_league")]
        public PlayerGameDataDetails RocketLeague { get; set; }

        [JsonProperty(PropertyName = "magic_arena")]
        public PlayerGameDataDetails MagicArena { get; set; }

        [JsonProperty(PropertyName = "clash_royale")]
        public PlayerGameDataDetails ClashRoyale { get; set; }

        [JsonProperty(PropertyName = "brawl_stars")]
        public PlayerGameDataDetails BrawlStars { get; set; }
        public PlayerGameDataDetails Hearthstone { get; set; }

        [JsonProperty(PropertyName = "gs_pubg")]
        public PlayerGameDataDetails GSPUBG { get; set; }

        [JsonProperty(PropertyName = "wot_xbox")]
        public PlayerGameDataDetails WorldOfTanksXBOX { get; set; }

        [JsonProperty(PropertyName = "starcraft2_US")]
        public PlayerGameDataDetails Starcraft2US { get; set; }
        public PlayerGameDataDetails Overwatch { get; set; }

        [JsonProperty(PropertyName = "overwatch_US")]
        public PlayerGameDataDetails OverwatchUS { get; set; }

        [JsonProperty(PropertyName = "overwatch_EU")]
        public PlayerGameDataDetails OverwatchEU { get; set; }

        [JsonProperty(PropertyName = "overwatch_KR")]
        public PlayerGameDataDetails OverwatchKR { get; set; }

        [JsonProperty(PropertyName = "ring_of_elysium")]
        public PlayerGameDataDetails RingOfElysium { get; set; }
        public PlayerGameDataDetails Destiny2 { get; set; }

        [JsonProperty(PropertyName = "destiny2_parent")]
        public PlayerGameDataDetails Destiny2Parent { get; set; }

        [JsonProperty(PropertyName = "destiny2_xbox")]
        public PlayerGameDataDetails Destiny2XBOX { get; set; }

        [JsonProperty(PropertyName = "destiny2_ps4")]
        public PlayerGameDataDetails Destiny2PS4 { get; set; }
        public PlayerGameDataDetails CSDZ { get; set; }
        public PlayerGameDataDetails PUBG { get; set; }
        public PlayerGameDataDetails Battalion { get; set; }
        public PlayerGameDataDetails Warface { get; set; }

        [JsonProperty(PropertyName = "warface_parent")]
        public PlayerGameDataDetails WarfaceParent { get; set; }

    }

    public class PlayerGameDataDetails
    {

        [JsonProperty(PropertyName = "game_profile_id")]
        public string GameProfileID { get; set; }
        public string Region { get; set; }
        public Regions Regions { get; set; }

        [JsonProperty(PropertyName = "skill_level_label")]
        public string SkillLevelLabel { get; set; }

        [JsonProperty(PropertyName = "game_player_id")]
        public string GamePlayerID { get; set; }

        [JsonProperty(PropertyName = "skill_level")]
        public int SkillLevel { get; set; }

        [JsonProperty(PropertyName = "faceit_elo")]
        public int FaceitELO { get; set; }

        [JsonProperty(PropertyName = "game_player_name")]
        public string GamePlayerName { get; set; }
    }
}
