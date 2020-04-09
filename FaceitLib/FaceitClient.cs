using FaceitLib.Models;
using FaceitLib.Models.ClassObjectLists;
using FaceitLib.Models.SearchResults;
using FaceitLib.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace FaceitLib
{
    public class FaceitClient
    {

        private const string BASEFACEITURL = "https://open.faceit.com/data/v4";
        private string _APIkey { get; set; }
        private HttpStatusCode _statuscode { get; set; }
        public FaceitClient(string apikey)
        {
            _APIkey = apikey;
        }

        public HttpStatusCode GetStatusCode()
        {
            return _statuscode;
        }

        private async Task<T> MakeGETRequest<T>(string builtURL)
        {
            var FaceitWebRequest = new FaceitWebRequests<T>();
            T Response = await FaceitWebRequest.GetRequest(builtURL, _APIkey);
            _statuscode = FaceitWebRequests<T>.statuscode;
            return Response;
        }

        /// <summary>
        /// Get the details of a FACEIT championship
        /// </summary>
        /// <param name="championship_id">ID of the championship</param>
        /// <param name="expandorganizer">If the full information about the organizer should be returned (Optional)</param>
        /// <param name="expandgame">If the full information about the game should be returned (Optional)</param>
        /// <returns></returns>
        public async Task<ChampionshipDetails> GetChampionshipDetails(string championship_id, bool expandorganizer = false, bool expandgame = false)
        {
            string builtURL = $"{BASEFACEITURL}/championships/{championship_id}?expanded=";
            if (expandorganizer && expandgame)
            {
                builtURL += "organizer,game";
            }
            else if (expandorganizer)
            {
                builtURL += "organizer";
            }
            else if (expandgame)
            {
                builtURL += "game";
            }
            var ChampionshipDetails = await MakeGETRequest<ChampionshipDetails>(builtURL);
            return ChampionshipDetails;
        }

        /// <summary>
        /// Get the matches of a championship
        /// </summary>
        /// <param name="championship_id">ID of the championship</param>
        /// <param name="type">Type of matches to retrieve. Options are "upcoming", "ongoing", "past" or "all". By default, this parameter is "all" and will default to "all" if an invalid parameter is passed (Optional)</param>
        /// <param name="offset">Offset into the list of matches (Optional)</param>
        /// <param name="limit">Limit of matches to retrieve info on (Optional)</param>
        /// <returns></returns>
        public async Task<GenericContainer<MatchesListObject>> GetChampionshipMatches(string championship_id, string type = "all", int offset = 0, int limit = 20)
        {
            string builtURL = $"{BASEFACEITURL}/championships/{championship_id}/matches?type=";
            if (type.ToLower() == "upcoming")
            {
                builtURL += "upcoming";
            }
            else if (type.ToLower() == "ongoing")
            {
                builtURL += "ongoing";
            }
            else if (type.ToLower() == "past")
            {
                builtURL += "past";
            }
            else builtURL += "all";
            builtURL += $"&offset={offset}&limit={limit}";
            var ChampionshipMatches = await MakeGETRequest<GenericContainer<MatchesListObject>>(builtURL);
            return ChampionshipMatches;
        }

        /// <summary>
        /// Get the subscriptions of a championship
        /// </summary>
        /// <param name="championship_id">ID of the championship</param>
        /// <param name="offset">Offset into the list of subscriptions (Optional)</param>
        /// <param name="limit">Limit of subscriptions to retrieve info on (Optional)</param>
        /// <returns></returns>
        public async Task<GenericContainer<ChampionshipSubscriptionsListObject>> GetChampionshipSubscriptions(string championship_id, int offset = 0, int limit = 10)
        {
            string builtURL = $"{BASEFACEITURL}/championships/{championship_id}/subscriptions?offset={offset}&limit={limit}";
            var ChampionshipSubs = await MakeGETRequest<GenericContainer<ChampionshipSubscriptionsListObject>>(builtURL);
            return ChampionshipSubs;
        }

        /// <summary>
        /// Get a list of all games supported on FACEIT
        /// </summary>
        /// <param name="offset">Offset into the list of games (Optional)</param>
        /// <param name="limit">Limit of games to retrieve info on (Optional)</param>
        /// <returns>Games Object</returns>
        public async Task<GenericContainer<GameDetails>> GetAllGames(int offset = 0, int limit = 20)
        {
            string builtURL = $"{BASEFACEITURL}/games?offset={offset}&limit={limit}";
            var AllGames = await MakeGETRequest<GenericContainer<GameDetails>>(builtURL);
            return AllGames;
        }

        /// <summary>
        /// Get the details of a game on FACEIT
        /// </summary>
        /// <param name="game_id">ID of a game</param>
        /// <returns></returns>
        public async Task<GameDetails> GetGameDetails(string game_id)
        {
            string builtURL = $"{BASEFACEITURL}/games/{game_id}";
            var GameDetails = await MakeGETRequest<GameDetails>(builtURL);
            return GameDetails;
        }

        /// <summary>
        /// Get the details of the parent game, if the game is region-specific
        /// </summary>
        /// <param name="game_id">ID of the game to get the parent of</param>
        /// <returns></returns>
        public async Task<GameDetails> GetParentGameDetails(string game_id)
        {
            string builtURL = $"{BASEFACEITURL}/games/{game_id}/parent";
            var GameParentDetails = await MakeGETRequest<GameDetails>(builtURL);
            return GameParentDetails;
        }

        /// <summary>
        /// Get the details of a FACEIT hub
        /// </summary>
        /// <param name="hub_id">ID of the hub</param>
        /// <param name="expandorganizer">If the full information about the organizer should be returned (Optional)</param>
        /// <param name="expandgame">If the full information about the game should be returned (Optional)</param>
        /// <returns></returns>
        public async Task<HubDetails> GetHubDetails(string hub_id, bool expandorganizer = false, bool expandgame = false)
        {
            var builtURL = $"{BASEFACEITURL}/hubs/{hub_id}?expanded=";
            if (expandorganizer && expandgame)
            {
                builtURL += "organizer, game";
            }
            else if (expandorganizer)
            {
                builtURL += "organizer";
            }
            else if (expandgame)
            {
                builtURL += "game";
            }
            var HubDetails = await MakeGETRequest<HubDetails>(builtURL);
            return HubDetails;
        }

        /// <summary>
        /// Get the matches of a hub
        /// </summary>
        /// <param name="hub_id">ID of the hub</param>
        /// <param name="type">Type of matches to retrieve. Options are "upcoming", "ongoing", "past" or "all". By default, this parameter is "all" and will default to "all" if an invalid parameter is passed (Optional)</param>
        /// <param name="offset">Offset into the list of matches (Optional)</param>
        /// <param name="limit">Limit of matches to retrieve info on (Optional)</param>
        /// <returns></returns>
        public async Task<GenericContainer<MatchesListObject>> GetHubMatches(string hub_id, string type = "all", int offset = 0, int limit = 20)
        {
            string builtURL = $"{BASEFACEITURL}/hubs/{hub_id}/matches?type=";
            if (type.ToLower() == "upcoming")
            {
                builtURL += "upcoming";
            }
            else if (type.ToLower() == "ongoing")
            {
                builtURL += "ongoing";
            }
            else if (type.ToLower() == "past")
            {
                builtURL += "past";
            }
            else builtURL += "all";
            builtURL += $"&offset={offset}&limit={limit}";
            var HubMatches = await MakeGETRequest<GenericContainer<MatchesListObject>>(builtURL);
            return HubMatches;
        }


        /// <summary>
        /// Get the members of a hub
        /// </summary>
        /// <param name="hub_id">ID of the hub</param>
        /// <param name="offset">Offset into the list of members (Optional)</param>
        /// <param name="limit">Limit of members to retrieve info on (Optional)</param>
        /// <returns></returns>
        public async Task<GenericContainer<HubMemberListObject>> GetHubMembers(string hub_id, int offset = 0, int limit = 20)
        {
            string builtURL = $"{BASEFACEITURL}/hubs/{hub_id}/members?offset={offset}&limit={limit}";
            var hubmembers = await MakeGETRequest<GenericContainer<HubMemberListObject>>(builtURL);
            return hubmembers;
        }

        /// <summary>
        /// Get the roles of a hub
        /// </summary>
        /// <param name="hub_id">ID of the hub</param>
        /// <param name="offset">Offset into the list of roles (Optional)</param>
        /// <param name="limit">Limit of roles to retrieve (Optional)</param>
        /// <returns></returns>
        public async Task<GenericContainer<RoleListObject>> GetHubRoles(string hub_id, int offset = 0, int limit = 20)
        {
            string builtURL = $"{BASEFACEITURL}/hubs/{hub_id}/roles?offset={offset}&limit={limit}";
            var hubroles = await MakeGETRequest<GenericContainer<RoleListObject>>(builtURL);
            return hubroles;
        }

        /// <summary>
        /// Get the rules of a hub
        /// </summary>
        /// <param name="hub_id">ID of the hub</param>
        /// <returns></returns>
        public async Task<HubRules> GetHubRules(string hub_id)
        {
            string builtURL = $"{BASEFACEITURL}/hubs/{hub_id}/rules";
            var hubrules = await MakeGETRequest<HubRules>(builtURL);
            return hubrules;
        }

        /// <summary>
        /// Get the stats of a hub
        /// </summary>
        /// <param name="hub_id">ID of the hub</param>
        /// <param name="offset">Offset into the list of players (Optional)</param>
        /// <param name="limit">Limit of players to retrieve (Optional)</param>
        /// <returns></returns>
        public async Task<HubStats> GetHubStats(string hub_id, int offset = 0, int limit = 20)
        {
            string builtURL = $"{BASEFACEITURL}/hubs/{hub_id}/stats?offset={offset}&limit={limit}";
            var hubstats = await MakeGETRequest<HubStats>(builtURL);
            return hubstats;
        }

        /// <summary>
        /// Get the leaderboards of a championship
        /// </summary>
        /// <param name="championship_id">ID of the championship</param>
        /// <param name="offset">Offset into the list of leaderboards (Optional)</param>
        /// <param name="limit">Limit of leaderboards to retrieve (Optional)</param>
        /// <returns></returns>
        public async Task<GenericContainer<LeaderboardListObject>> GetChampionshipLeaderboards(string championship_id, int offset = 0, int limit = 20)
        {
            string builtURL = $"{BASEFACEITURL}/leaderboards/championships/{championship_id}?offset={offset}&limit={limit}";
            var leaderboards = await MakeGETRequest<GenericContainer<LeaderboardListObject>>(builtURL);
            return leaderboards;
        }

        /// <summary>
        /// Get the ranking of a group in a championship
        /// </summary>
        /// <param name="championship_id">ID of the championship</param>
        /// <param name="group">Group number</param>
        /// <param name="offset">Offset into the ranking list (Optional)</param>
        /// <param name="limit">Limit of rankings to retrieve (Optional)</param>
        /// <returns></returns>
        public async Task<GenericRanking> GetChampionshipGroupRanking(string championship_id, int group, int offset = 0, int limit = 20)
        {
            string builtURL = $"{BASEFACEITURL}/leaderboards/championships/{championship_id}/groups/{group}?offset={offset}&limit={limit}";
            var champgroupranking = await MakeGETRequest<GenericRanking>(builtURL);
            return champgroupranking;
        }

        /// <summary>
        /// Get the leaderboards of a hub
        /// </summary>
        /// <param name="hub_id">ID of the hub</param>
        /// <param name="offset">Offset into the list of leaderboards</param>
        /// <param name="limit">Limit of leaderboards to retrieve (Optional)</param>
        /// <returns></returns>
        public async Task<GenericContainer<LeaderboardListObject>> GetHubLeaderboards(string hub_id, int offset = 0, int limit = 20)
        {
            string builtURL = $"{BASEFACEITURL}/leaderboards/hubs/{hub_id}?offset={offset}&limit={limit}";
            var hubleaderboards = await MakeGETRequest<GenericContainer<LeaderboardListObject>>(builtURL);
            return hubleaderboards;
        }

        /// <summary>
        /// Get the all-time ranking of a hub
        /// </summary>
        /// <param name="hub_id">ID of the hub</param>
        /// <param name="offset">Offset into the rankings list (Optional)</param>
        /// <param name="limit">Limit of rankings to retrieve (Optional)</param>
        /// <returns></returns>
        public async Task<GenericRanking> GetHubRankingAlltime(string hub_id, int offset = 0, int limit = 20)
        {
            string builtURL = $"{BASEFACEITURL}/leaderboards/hubs/{hub_id}/general?offset={offset}&limit={limit}";
            var hubrankings = await MakeGETRequest<GenericRanking>(builtURL);
            return hubrankings;
        }

        /// <summary>
        /// Get the rankings of a hub's season
        /// </summary>
        /// <param name="hub_id">ID of the hub</param>
        /// <param name="season">Season number</param>
        /// <param name="offset">Offset into the rankings list (Optional)</param>
        /// <param name="limit">Limit of rankings to retrieve (Optional)</param>
        /// <returns></returns>
        public async Task<GenericRanking> GetHubRankingSeasonal(string hub_id, int season, int offset = 0, int limit = 20)
        {
            string builtURL = $"{BASEFACEITURL}/leaderboards/hubs/{hub_id}/seasons/{season}?offset={offset}&limit={limit}";
            var hubrankingseasonal = await MakeGETRequest<GenericRanking>(builtURL);
            return hubrankingseasonal;
        }

        /// <summary>
        /// Get the rankings of a specific leaderboard from it's ID
        /// </summary>
        /// <param name="leaderboard_id">ID of the leaderboard</param>
        /// <param name="offset">Offset into the rankings list</param>
        /// <param name="limit">Limit of rankings to retrieve</param>
        /// <returns></returns>
        public async Task<GenericRanking> GetRankingFromLeaderboardID(string leaderboard_id, int offset = 0, int limit = 20)
        {
            string builtURL = $"{BASEFACEITURL}/leaderboards/{leaderboard_id}?offset={offset}&limit={limit}";
            var rankfromleaderboard = await MakeGETRequest<GenericRanking>(builtURL);
            return rankfromleaderboard;
        }

        /// <summary>
        /// Get the details of a match
        /// </summary>
        /// <param name="match_id">ID of the match</param>
        /// <returns></returns>
        public async Task<MatchDetails> GetMatchDetails(string match_id)
        {
            string builtURL = $"{BASEFACEITURL}/matches/{match_id}";
            var matchdetails = await MakeGETRequest<MatchDetails>(builtURL);
            return matchdetails;
        }

        /// <summary>
        /// Get the statistics of a match
        /// </summary>
        /// <param name="match_id">ID of a match</param>
        /// <returns></returns>
        public async Task<MatchStats> GetMatchStats(string match_id)
        {
            string builtURL = $"{BASEFACEITURL}/matches/{match_id}/stats";
            var matchstats = await MakeGETRequest<MatchStats>(builtURL);
            return matchstats;
        }

        /// <summary>
        /// Get the details of an organizer from their name on FACEIT (Case-sensitive)
        /// </summary>
        /// <param name="organizer_name">Name of the organizer (Case-sensitive)</param>
        /// <returns></returns>
        public async Task<OrganizerData> GetOrganizerDetailsFromName(string organizer_name)
        {
            string builtURL = $"{BASEFACEITURL}/organizers?name={organizer_name}";
            var organizerdetails = await MakeGETRequest<OrganizerData>(builtURL);
            return organizerdetails;
        }

        /// <summary>
        /// Get the details of an organizer from their ID
        /// </summary>
        /// <param name="organizer_id">ID of the organizer</param>
        /// <returns></returns>
        public async Task<OrganizerData> GetOrganizerDetailsFromID(string organizer_id)
        {
            string builtURL = $"{BASEFACEITURL}/organizers/{organizer_id}";
            var organizerdetails = await MakeGETRequest<OrganizerData>(builtURL);
            return organizerdetails;
        }

        /// <summary>
        /// Get the championships of an organizer
        /// </summary>
        /// <param name="organizer_id">ID of the organizer</param>
        /// <param name="offset">Offset into the championships list (Optional)</param>
        /// <param name="limit">Limit of championships to retrieve (Optional)</param>
        /// <returns></returns>
        public async Task<GenericContainer<ChampionshipDetails>> GetOrganizerChampionships(string organizer_id, int offset = 0, int limit = 20)
        {
            string builtURL = $"{BASEFACEITURL}/organizers/{organizer_id}/championships?offset={offset}&limit={limit}";
            var championships = await MakeGETRequest<GenericContainer<ChampionshipDetails>>(builtURL);
            return championships;
        }

        /// <summary>
        /// Get the associated games of an organizer
        /// </summary>
        /// <param name="organizer_id">ID of the organizer</param>
        /// <returns></returns>
        public async Task<GenericContainer<GameDetails>> GetOrganizerGames(string organizer_id)
        {
            string builtURL = $"{BASEFACEITURL}/organizers/{organizer_id}/games";
            var games = await MakeGETRequest<GenericContainer<GameDetails>>(builtURL);
            return games;
        }

        /// <summary>
        /// Get the hubs associated with an organizer
        /// </summary>
        /// <param name="organizer_id">ID of the organizer</param>
        /// <returns></returns>
        public async Task<GenericContainer<HubDetails>> GetOrganizerHubs(string organizer_id)
        {
            string builtURL = $"{BASEFACEITURL}/organizers/{organizer_id}/hubs";
            var hubs = await MakeGETRequest<GenericContainer<HubDetails>>(builtURL);
            return hubs;
        }

        /// <summary>
        /// Get the list of tournaments of an organizer
        /// </summary>
        /// <param name="organizer_id">ID of the organizer</param>
        /// <param name="type">Type of tournaments to retrieve. Options are "upcoming" or "past". By default, this parameter is "upcoming" and will default to "upcoming" if an invalid parameter is passed (Optional)</param>
        /// <param name="offset">Offset into the list of tournaments</param>
        /// <param name="limit">Limit of number of tournaments to retrieve</param>
        /// <returns></returns>
        public async Task<GenericContainer<TournamentListObject>> GetOrganizerTournaments(string organizer_id, string type = "upcoming", int offset = 0, int limit = 1)
        {
            string builtURL = $"{BASEFACEITURL}/organizers/{organizer_id}/tournaments?type=";
            if (type.ToLower() == "past")
            {
                builtURL += "past";
            }
            else builtURL += "upcoming";
            builtURL += $"&offset={offset}&limit={limit}";
            var tournaments = await MakeGETRequest<GenericContainer<TournamentListObject>>(builtURL);
            return tournaments;
        }

        /// <summary>
        /// Get the details of a player by their nickname (Case-Sensitive)
        /// </summary>
        /// <param name="nickname">The nickname of the player (Case-Sensitive)</param>
        /// <returns></returns>
        public async Task<PlayerDetails> GetPlayerDetailsFromNickname(string nickname)
        {
            string builtURL = $"{BASEFACEITURL}/players?nickname={nickname}";
            var details = await MakeGETRequest<PlayerDetails>(builtURL);
            return details;
        }

        /// <summary>
        /// Get the details of a player by their ID
        /// </summary>
        /// <param name="player_id">ID of the player</param>
        /// <returns></returns>
        public async Task<PlayerDetails> GetPlayerDetailsFromID(string player_id)
        {
            string builtURL = $"{BASEFACEITURL}/players/{player_id}";
            var details = await MakeGETRequest<PlayerDetails>(builtURL);
            return details;
        }

        /// <summary>
        /// Get the match history of a player by their ID
        /// </summary>
        /// <param name="player_id">ID of the player</param>
        /// <param name="game_id">ID of the game</param>
        /// <param name="time_from">The timestamp (Unix time) as lower bound of the query. 1 month ago if not specified (Optional)</param>
        /// <param name="time_to">The timestamp (Unix time) as higher bound of the query. Current timestamp if not specified (Optional</param>
        /// <param name="offset">Offset into the match history list (Optional)</param>
        /// <param name="limit">Limit of matches to retrieve (Optional)</param>
        /// <returns></returns>
        public async Task<PlayerMatches> GetPlayerMatchHistory(string player_id, string game_id, Int64 time_from = 0, Int64 time_to = 0, int offset = 0, int limit = 20)
        {
            string builtURL = $"{BASEFACEITURL}/players/{player_id}/history?game={game_id}";
            if (time_from != 0) builtURL += $"&from={time_from}";
            if (time_to != 0) builtURL += $"&to={time_to}";
            builtURL += $"&offset={offset}&limit={limit}";
            var matches = await MakeGETRequest<PlayerMatches>(builtURL);
            return matches;
        }

        /// <summary>
        /// Get the hubs that a player is in
        /// </summary>
        /// <param name="player_id">ID of the player</param>
        /// <param name="offset">Offset into the hub list (Optional)</param>
        /// <param name="limit">Limit of hubs to retrieve (Optional)</param>
        /// <returns></returns>
        public async Task<GenericContainer<OrganizerData>> GetPlayerHubs(string player_id, int offset = 0, int limit = 20)
        {
            string builtURL = $"{BASEFACEITURL}/players/{player_id}/hubs?offset={offset}&limit={limit}";
            var hubs = await MakeGETRequest<GenericContainer<OrganizerData>>(builtURL);
            return hubs;
        }

        /// <summary>
        /// Get the stats of a player in a given game
        /// </summary>
        /// <param name="player_id">ID of the player</param>
        /// <param name="game_id">ID of the game</param>
        /// <returns></returns>
        public async Task<PlayerStatsPerGame> GetPlayerStats(string player_id, string game_id)
        {
            string builtURL = $"{BASEFACEITURL}/players/{player_id}/stats/{game_id}";
            var stats = await MakeGETRequest<PlayerStatsPerGame>(builtURL);
            return stats;
        }

        /// <summary>
        /// Get the tournaments that a player has been involved in
        /// </summary>
        /// <param name="player_id">ID of the player</param>
        /// <param name="offset">Offset into the list of tournaments</param>
        /// <param name="limit">Limit of tournaments to retrieve</param>
        /// <returns></returns>
        public async Task<GenericContainer<TournamentListObjectExtended>> GetPlayerTournaments(string player_id, int offset = 0, int limit = 20)
        {
            string builtURL = $"{BASEFACEITURL}/players/{player_id}/tournaments?offset={offset}&limit={limit}";
            var tournaments = await MakeGETRequest<GenericContainer<TournamentListObjectExtended>>(builtURL);
            return tournaments;
        }

        /// <summary>
        /// Get the global rankings of a game
        /// </summary>
        /// <param name="game_id">ID of the game</param>
        /// <param name="region">Region statistics to retrieve (Regions are defined in FaceitLib.Constants.Regions)</param>
        /// <param name="country">Country statistics to retrieve (Countries are defined in FaceitLib.Constants.Countries) (Optional)</param>
        /// <param name="offset">Offset into the list of rankings (Optional)</param>
        /// <param name="limit">Limit of rankings to retrieve (Optional)</param>
        /// <returns></returns>
        public async Task<GenericContainer<GameRankingListObject>> GetGameRanking(string game_id, string region, string country = null, int offset = 0, int limit = 20)
        {
            string builtURL = $"{BASEFACEITURL}/rankings/games/{game_id}/regions/{region}?";
            if (country != null) builtURL += $"country={country}";
            builtURL += $"&offset={offset}&limit={limit}";
            var ranking = await MakeGETRequest<GenericContainer<GameRankingListObject>>(builtURL);
            return ranking;
        }

        /// <summary>
        /// Get the ranking of a player in a given game
        /// </summary>
        /// <param name="game_id">ID of the game</param>
        /// <param name="region">Region to look at for ranking (Regions are defined in FaceitLib.Constants.Regions)</param>
        /// <param name="player_id">ID of the player</param>
        /// <param name="country">Country statistics to retrieve (Countries are defined in FaceitLib.Constants.Countries) (Optional)</param>
        /// <param name="limit">Limit of player statistics to retrieve (Optional)</param>
        /// <returns></returns>
        public async Task<PlayerRankingContainer<GameRankingListObject>> GetPlayerRankingInGame(string game_id, string region, string player_id, string country = null, int limit = 20)
        {
            string builtURL = $"{BASEFACEITURL}/rankings/games/{game_id}/regions/{region}/players/{player_id}";
            if(country != null)
            {
                builtURL += $"?country={country}&limit={limit}";
            }
            else
            {
                builtURL += $"?limit={limit}";
            }
            var ranking = await MakeGETRequest<PlayerRankingContainer<GameRankingListObject>>(builtURL);
            return ranking;
        }

        /// <summary>
        /// Search for championships
        /// </summary>
        /// <param name="name">Name of the championship</param>
        /// <param name="game">Game to search for (Optional)</param>
        /// <param name="region">Region to look inside (Regions are defined in FaceitLib.Constants.Regions) (Optional)</param>
        /// <param name="type">Type of championships to retrieve. Options are all, upcoming, ongoing, or past. If a parameter is not defined, all will be used (Optional)</param>
        /// <param name="offset">Offset into the list of championships (Optional)</param>
        /// <param name="limit">Limit of championships to retrieve</param>
        /// <returns></returns>
        public async Task<GenericContainer<ChampionshipHubTournamentSearch>> SearchChampionships(string name, string game = null, string region = null, string type = "all", int offset = 0, int limit = 20)
        {
            string builtURL = $"{BASEFACEITURL}/search/championships?name={name}";
            if (game != null) builtURL += $"&game={game}";
            if (type == null)
            {
                builtURL += "&type=all";
            }
            else if (type.ToLower() == "upcoming")
            {
                builtURL += "&type=upcoming";
            }
            else if (type.ToLower() == "ongoing")
            {
                builtURL += "&type=ongoing";
            }
            else if (type.ToLower() == "past")
            {
                builtURL += "&type=past";
            }
            else builtURL += "&type=all";
            if (type != null) builtURL += $"&type={type}";
            builtURL += $"&offset={offset}&limit={limit}";
            var champs = await MakeGETRequest<GenericContainer<ChampionshipHubTournamentSearch>>(builtURL);
            return champs;
        }

        /// <summary>
        /// Search for hubs
        /// </summary>
        /// <param name="name">Name of the hub</param>
        /// <param name="game">Game to search for hubs under (Optional)</param>
        /// <param name="region">Region to search for hubs in (Regions are defined in FaceitLib.Constants.Regions) (Optional)</param>
        /// <param name="offset">Offset into the list of hubs (Optional)</param>
        /// <param name="limit">Limit of hubs to retrieve (Optional)</param>
        /// <returns></returns>
        public async Task<GenericContainer<ChampionshipHubTournamentSearch>> SearchHubs(string name, string game = null, string region = null, int offset = 0, int limit = 20)
        {
            string builtURL = $"{BASEFACEITURL}/search/hubs?name={name}";
            if (game != null) builtURL += $"&game={game}";
            if (region != null) builtURL += $"&region={region}";
            builtURL += $"&offset={offset}&limit={limit}";
            var hubs = await MakeGETRequest<GenericContainer<ChampionshipHubTournamentSearch>>(builtURL);
            return hubs;
        }

        /// <summary>
        /// Search for organizers
        /// </summary>
        /// <param name="name">Name of the organizer</param>
        /// <param name="offset">Offset into the list of organizers (Optional)</param>
        /// <param name="limit">Limit of organizers to retrieve (Optional)</param>
        /// <returns></returns>
        public async Task<GenericContainer<OrganizerSearch>> SearchOrganizers(string name, int offset = 0, int limit = 20)
        {
            string builtURL = $"{BASEFACEITURL}/search/organizers?name={name}&offset={offset}&limit={limit}";
            var organizers = await MakeGETRequest<GenericContainer<OrganizerSearch>>(builtURL);
            return organizers;
        }

        /// <summary>
        /// Search for players
        /// </summary>
        /// <param name="nickname">Nickname of the player</param>
        /// <param name="game">Game to search for players under (Optional)</param>
        /// <param name="country">Country to search for players under (Countries are defined in FaceitLib.Constants.Countries) (Optional)</param>
        /// <param name="offset">Offset into the list of players (Optional)</param>
        /// <param name="limit">Limit of players to retrieve (Optional)</param>
        /// <returns></returns>
        public async Task<GenericContainer<PlayerSearch>> SearchPlayers(string nickname, string game = null, string country = null, int offset = 0, int limit = 20)
        {
            string builtURL = $"{BASEFACEITURL}/search/players?nickname={nickname}";
            if (game != null) builtURL += $"&game={game}";
            if (country != null) builtURL += $"&country={country}";
            builtURL += $"&offset={offset}&limit={limit}";
            var players = await MakeGETRequest<GenericContainer<PlayerSearch>>(builtURL);
            return players;
        }

        /// <summary>
        /// Search for a team
        /// </summary>
        /// <param name="nickname">Nickname of the team</param>
        /// <param name="game">Game to search for team under (Optional)</param>
        /// <param name="offset">Offset into the list of teams (Optional)</param>
        /// <param name="limit">Limit of teams to retrieve (Optional)</param>
        /// <returns></returns>
        public async Task<GenericContainer<TeamSearch>> SearchTeams(string nickname, string game = null, int offset = 0, int limit = 20)
        {
            string builtURL = $"{BASEFACEITURL}/search/teams?nickname={nickname}";
            if (game != null) builtURL += $"&game={game}";
            builtURL += $"&offset={offset}&limit={limit}";
            var teams = await MakeGETRequest<GenericContainer<TeamSearch>>(builtURL);
            return teams;
        }

        /// <summary>
        /// Search for tournaments
        /// </summary>
        /// <param name="name">Name of the tournament</param>
        /// <param name="game">Game to search for (Optional)</param>
        /// <param name="region">Region to look inside (Regions are defined in FaceitLib.Constants.Regions) (Optional)</param>
        /// <param name="type">Type of tournaments to retrieve. Options are all, upcoming, ongoing, or past. If a parameter is not defined, all will be used (Optional)</param>
        /// <param name="offset">Offset into the list of tournaments (Optional)</param>
        /// <param name="limit">Limit of tournaments to retrieve</param>
        /// <returns></returns>
        public async Task<GenericContainer<ChampionshipHubTournamentSearch>> SearchTournaments(string name, string game = null, string region = null, string type = "all", int offset = 0, int limit = 20)
        {
            string builtURL = $"{BASEFACEITURL}/search/tournaments?name={name}";
            if (game != null) builtURL += $"&game={game}";
            if (type == null)
            {
                builtURL += "&type=all";
            }
            else if (type.ToLower() == "upcoming")
            {
                builtURL += "&type=upcoming";
            }
            else if (type.ToLower() == "ongoing")
            {
                builtURL += "&type=ongoing";
            }
            else if (type.ToLower() == "past")
            {
                builtURL += "&type=past";
            }
            else builtURL += "&type=all";
            if (type != null) builtURL += $"&type={type}";
            builtURL += $"&offset={offset}&limit={limit}";
            var tourneys = await MakeGETRequest<GenericContainer<ChampionshipHubTournamentSearch>>(builtURL);
            return tourneys;
        }

        /// <summary>
        /// Get the details of a team
        /// </summary>
        /// <param name="team_id">ID of the team</param>
        /// <returns></returns>
        public async Task<Team> GetTeamDetails(string team_id)
        {
            string builtURL = $"{BASEFACEITURL}/teams/{team_id}";
            var team = await MakeGETRequest<Team>(builtURL);
            return team;
        }

        /// <summary>
        /// Get the statistics of a team
        /// </summary>
        /// <param name="team_id">ID of the team</param>
        /// <param name="game_id">ID of the game the team is associated with</param>
        /// <returns></returns>
        public async Task<AlltimeTeamStatistics> GetTeamStats(string team_id, string game_id)
        {
            string builtURL = $"{BASEFACEITURL}/teams/{team_id}/stats/{game_id}";
            var stats = await MakeGETRequest<AlltimeTeamStatistics>(builtURL);
            return stats;
        }

        /// <summary>
        /// Get the tournaments a team has participated in
        /// </summary>
        /// <param name="team_id">ID of the team</param>
        /// <param name="offset">Offset into the list of tournaments (Optional)</param>
        /// <param name="limit">Limit of tournaments to retrieve (Optional)</param>
        /// <returns></returns>
        public async Task<GenericContainer<TournamentListObjectExtended>> GetTeamTournaments(string team_id, int offset = 0, int limit = 20)
        {
            string builtURL = $"{BASEFACEITURL}/teams/{team_id}/tournaments?offset={offset}&limit={limit}";
            var tourneys = await MakeGETRequest<GenericContainer<TournamentListObjectExtended>>(builtURL);
            return tourneys;
        }

        /// <summary>
        /// Get the details of a tournament
        /// </summary>
        /// <param name="tournament_id">ID of the tournament</param>
        /// <param name="isOrganizerExpanded">Should the organizer be expanded (Optional)</param>
        /// <param name="isGameExpanded">Should the game data be expanded (Optional)</param>
        /// <returns></returns>
        public async Task<TournamentDetails> GetTournamentDetails(string tournament_id, bool isOrganizerExpanded = false, bool isGameExpanded = false)
        {
            string builtURL = $"{BASEFACEITURL}/tournaments/{tournament_id}";
            if (isGameExpanded && isOrganizerExpanded) builtURL += "?expanded=organizer,game";
            else if (isGameExpanded) builtURL += "?expanded=game";
            else if (isOrganizerExpanded) builtURL += "?expanded=organizer";
            var details = await MakeGETRequest<TournamentDetails>(builtURL);
            return details;
        }

        /// <summary>
        /// Get the brackets of a tournament
        /// </summary>
        /// <param name="tournament_id">ID of the tournament</param>
        /// <returns></returns>
        public async Task<TournamentBrackets> GetTournamentBrackets(string tournament_id)
        {
            string builtURL = $"{BASEFACEITURL}/tournaments/{tournament_id}/brackets";
            var brackets = await MakeGETRequest<TournamentBrackets>(builtURL);
            return brackets;
        }

        /// <summary>
        /// Get the matches of a tournament
        /// </summary>
        /// <param name="tournament_id">ID of the tournament</param>
        /// <param name="offset">Offset into the list of matches (Optional)</param>
        /// <param name="limit">Limit of matches to retrieve (Optional)</param>
        /// <returns></returns>
        public async Task<GenericContainer<MatchesListObjectTournament>> GetTournamentMatches(string tournament_id, int offset = 0, int limit = 20)
        {
            string builtURL = $"{BASEFACEITURL}/tournaments/{tournament_id}/matches?offset={offset}&limit={limit}";
            var matches = await MakeGETRequest<GenericContainer<MatchesListObjectTournament>>(builtURL);
            return matches;
        }

        /// <summary>
        /// Get the teams of a tournament
        /// </summary>
        /// <param name="tournament_id">ID of the tournament</param>
        /// <param name="offset">Offset into the list of teams (Optional)</param>
        /// <param name="limit">Limit of teams to retreieve (Optional)</param>
        /// <returns></returns>
        public async Task<TournamentTeams> GetTournamentTeams(string tournament_id, int offset = 0, int limit = 20)
        {
            string builtURL = $"{BASEFACEITURL}/tournaments/{tournament_id}/teams?offset={offset}&limit={limit}";
            var teams = await MakeGETRequest<TournamentTeams>(builtURL);
            return teams;
        }


        /// <summary>
        /// Get all the matches in a hub between two dates (inclusive)
        /// </summary>
        /// <param name="hub_id">Id of the hub</param>
        /// <param name="FromDate">DateTime to get matches from (first date)</param>
        /// <param name="ToDate">DateTime to get matches to (second date)</param>
        /// <param name="OptionalLimit">Define your own limit for the API call (higher numbers may cause more frequent 503 issues)</param>
        /// <returns></returns>
        public async Task<List<MatchesListObject>> GetMatchesFromHubBetweenDates(string hub_id, DateTime FromDate, DateTime ToDate, int OptionalLimit = 20)
        {
            int currentoffset = 0;

            List<MatchesListObject> ReturnMatches = new List<MatchesListObject>();

            bool KeepLoop = true;

            while (KeepLoop)
            {
                var Matches = await GetHubMatches(hub_id, "past", currentoffset, OptionalLimit);

                if (_statuscode == HttpStatusCode.ServiceUnavailable)
                {
                    Thread.Sleep(5000); 
                    continue; // If we get a bad response from Faceit let's just retry after waiting 5 seconds
                }
                if (_statuscode != HttpStatusCode.OK)
                {
                    return null;
                }

                List<MatchesListObject> MatchesFromAPICall = Matches.Items;

                // Reverse the list to give us the *correct* order
                MatchesFromAPICall = Enumerable.Reverse(MatchesFromAPICall).ToList();


                foreach(var item in MatchesFromAPICall)
                {

                    if(item.Status.ToLower() == "CANCELLED".ToLower())
                    {
                        // This match was cancelled so skip it
                        continue;
                    }

                    // Get current DateTime
                    DateTime CurrentMatchDateTime = new DateTime(1970, 1, 1).AddSeconds(item.ScheduledAt);

                    if(CurrentMatchDateTime > ToDate)
                    {
                        // If this match takes place after we want then skip it
                        continue;
                    }

                    if(FromDate > CurrentMatchDateTime)
                    {
                        // If we've gotten to the point where we're getting matches before 
                        KeepLoop = false;
                        continue;
                    }

                    // Put matches in our object
                    ReturnMatches.Add(item);
                }
            }

            return ReturnMatches;
        }

        /// <summary>
        /// Get all the matches in a championship between two dates (inclusive)
        /// </summary>
        /// <param name="championship_id">ID of the championship</param>
        /// <param name="FromDate">DateTime to get matches from (first date)</param>
        /// <param name="ToDate">DateTime to get matches to (second date)</param>
        /// <param name="OptionalLimit">Define your own limit for the API call (higher numbers may cause more frequent 503 issues)</param>
        /// <returns></returns>
        public async Task<List<MatchesListObject>> GetMatchesFromChampionshipBetweenDates(string championship_id, DateTime FromDate, DateTime ToDate, int OptionalLimit = 20)
        {
            int currentoffset = 0;

            List<MatchesListObject> ReturnMatches = new List<MatchesListObject>();

            bool KeepLoop = true;

            while (KeepLoop)
            {
                var Matches = await GetChampionshipMatches(championship_id, "past", currentoffset, OptionalLimit);

                if (_statuscode == HttpStatusCode.ServiceUnavailable)
                {
                    Thread.Sleep(5000);
                    continue; // If we get a bad response from Faceit let's just retry after waiting 5 seconds
                }
                if (_statuscode != HttpStatusCode.OK)
                {
                    // If we get a bad code like Unauthorized or something just yeet out
                    return null;
                }

                List<MatchesListObject> MatchesFromAPICall = Matches.Items;

                // Reverse the list to give us the *correct* order
                MatchesFromAPICall = Enumerable.Reverse(MatchesFromAPICall).ToList();


                foreach (var item in MatchesFromAPICall)
                {

                    if (item.Status.ToLower() == "CANCELLED".ToLower())
                    {
                        // This match was cancelled so skip it
                        continue;
                    }

                    // Get current DateTime
                    DateTime CurrentMatchDateTime = new DateTime(1970, 1, 1).AddSeconds(item.ScheduledAt);

                    if (CurrentMatchDateTime > ToDate)
                    {
                        // If this match takes place after we want then skip it
                        continue;
                    }

                    if (FromDate > CurrentMatchDateTime)
                    {
                        // If we've gotten to the point where we're getting matches before 
                        KeepLoop = false;
                        continue;
                    }

                    // Put matches in our object
                    ReturnMatches.Add(item);
                }
            }

            return ReturnMatches;
        }

    }
}
