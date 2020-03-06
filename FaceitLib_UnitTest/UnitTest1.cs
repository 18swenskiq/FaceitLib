using Microsoft.VisualStudio.TestTools.UnitTesting;
using FaceitLib;
using System;
using System.Threading.Tasks;

namespace FaceitLib_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task GetChampionshipDetails()
        {
            var faceit = new FaceitClient("7ee029c0-53bf-495a-a8f5-f4017c979341");
            var champdetails = await faceit.GetChampionshipDetails("b4daff3e-6a71-4636-a78c-8e9aa66b2df8");
            Console.WriteLine(champdetails.Region);
            Assert.IsNotNull(champdetails.Region);
        }

        [TestMethod]
        public async Task GetChampionshipMatches()
        {
            var faceit = new FaceitClient("7ee029c0-53bf-495a-a8f5-f4017c979341");
            var champmatches = await faceit.GetChampionshipMatches("b4daff3e-6a71-4636-a78c-8e9aa66b2df8", "all");
            Assert.IsNotNull(champmatches.Items[0].Results.Score.Faction1);
        }

        [TestMethod]
        public async Task GetChampionshipSubscriptions()
        {
            var faceit = new FaceitClient("7ee029c0-53bf-495a-a8f5-f4017c979341");
            var champsubs = await faceit.GetChampionshipSubscriptions("b4daff3e-6a71-4636-a78c-8e9aa66b2df8");
            Assert.IsNotNull(champsubs.Items[0].Group);
        }
        
        [TestMethod]
        public async Task GetAllGames()
        {
            var faceit = new FaceitClient("7ee029c0-53bf-495a-a8f5-f4017c979341");
            var games = await faceit.GetAllGames(0, 1);
            Assert.IsNotNull(games);
        }

        [TestMethod]
        public async Task GetGameDetails()
        {
            var faceit = new FaceitClient("7ee029c0-53bf-495a-a8f5-f4017c979341");
            var gamedetails = await faceit.GetGameDetails("tf2");
            Assert.IsNotNull(gamedetails.LongLabel);
        }

        [TestMethod]
        public async Task GetParentGameDetails()
        {
            var faceit = new FaceitClient("7ee029c0-53bf-495a-a8f5-f4017c979341");
            var gameparentdetails = await faceit.GetParentGameDetails("tf2");
            Assert.IsNotNull(gameparentdetails.GameID);
        }

        [TestMethod]
        public async Task GetHubDetails()
        {
            var faceit = new FaceitClient("7ee029c0-53bf-495a-a8f5-f4017c979341");
            var hubdetails = await faceit.GetHubDetails("8f2c8a7c-8702-4955-bd06-6caf9b670276");
            Assert.IsNotNull(hubdetails.FaceitURL);
        }

        [TestMethod]
        public async Task GetHubMatches()
        {
            var faceit = new FaceitClient("7ee029c0-53bf-495a-a8f5-f4017c979341");
            var hubmatches = await faceit.GetHubMatches("dd5c0ffd-3472-4383-963f-e357a124832c", "past");
            Assert.IsNotNull(hubmatches);
        }

        [TestMethod]
        public async Task GetHubMembers()
        {
            var faceit = new FaceitClient("7ee029c0-53bf-495a-a8f5-f4017c979341");
            var hubmatches = await faceit.GetHubMembers("dd5c0ffd-3472-4383-963f-e357a124832c");
            Assert.IsNotNull(hubmatches.Items[0].FaceitURL);
        }

        [TestMethod]
        public async Task GetHubRoles()
        {
            var faceit = new FaceitClient("7ee029c0-53bf-495a-a8f5-f4017c979341");
            var hubroles = await faceit.GetHubRoles("dd5c0ffd-3472-4383-963f-e357a124832c");
            Assert.IsNotNull(hubroles.Items[0].Color);
        }

        [TestMethod]
        public async Task GetHubRules()
        {
            var faceit = new FaceitClient("7ee029c0-53bf-495a-a8f5-f4017c979341");
            var hubrules = await faceit.GetHubRules("dd5c0ffd-3472-4383-963f-e357a124832c");
            Assert.IsNotNull(hubrules.Body);
        }

        [TestMethod]
        public async Task GetHubStats()
        {
            var faceit = new FaceitClient("7ee029c0-53bf-495a-a8f5-f4017c979341");
            var hubstats = await faceit.GetHubStats("dd5c0ffd-3472-4383-963f-e357a124832c");
            Assert.IsNotNull(hubstats.Players[0].PlayerID);
        }

        [TestMethod]
        public async Task GetChampionshipLeaderboards()
        {
            var faceit = new FaceitClient("7ee029c0-53bf-495a-a8f5-f4017c979341");
            var cleaderboards = await faceit.GetChampionshipLeaderboards("b4daff3e-6a71-4636-a78c-8e9aa66b2df8");
            Assert.IsNotNull(cleaderboards.Items[0].LeaderboardID);
        }

        [TestMethod]
        public async Task GetChampionshipGroupRanking()
        {
            var faceit = new FaceitClient("7ee029c0-53bf-495a-a8f5-f4017c979341");
            var ranking = await faceit.GetChampionshipGroupRanking("b4daff3e-6a71-4636-a78c-8e9aa66b2df8", 1);
            Assert.IsNotNull(ranking.Leaderboard.LeaderboardName);
        }

        [TestMethod]
        public async Task GetHubLeaderboards()
        {
            var faceit = new FaceitClient("7ee029c0-53bf-495a-a8f5-f4017c979341");
            var leaderboards = await faceit.GetHubLeaderboards("dd5c0ffd-3472-4383-963f-e357a124832c");
            Assert.IsNotNull(leaderboards.Items[0].MinMatches);
        }

        [TestMethod]
        public async Task GetHubRankingAlltime()
        {
            var faceit = new FaceitClient("7ee029c0-53bf-495a-a8f5-f4017c979341");
            var ranking = await faceit.GetHubRankingAlltime("dd5c0ffd-3472-4383-963f-e357a124832c");
            Assert.IsNotNull(ranking.Items[0].Player.Nickname);
        }

        [TestMethod]
        public async Task GetHubRankingSeasonal()
        {
            var faceit = new FaceitClient("7ee029c0-53bf-495a-a8f5-f4017c979341");
            var ranking = await faceit.GetHubRankingSeasonal("dd5c0ffd-3472-4383-963f-e357a124832c", 1);
            Assert.IsNotNull(ranking.Leaderboard.CompetitionID);
        }

        [TestMethod]
        public async Task GetRankingFromLeaderboardID()
        {
            var faceit = new FaceitClient("7ee029c0-53bf-495a-a8f5-f4017c979341");
            var ranking = await faceit.GetRankingFromLeaderboardID("5de58bfc70f728000fa56e0a");
            Assert.IsNotNull(ranking.Items[0].CurrentWinStreak);
        }

        [TestMethod]
        public async Task GetMatchDetails()
        {
            var faceit = new FaceitClient("7ee029c0-53bf-495a-a8f5-f4017c979341");
            var details = await faceit.GetMatchDetails("1-535ba6b5-ef38-4bfa-b37e-47a2af70e39a");
            Assert.IsNotNull(details.Game);
        }

        [TestMethod]
        public async Task GetMatchStats()
        {
            var faceit = new FaceitClient("7ee029c0-53bf-495a-a8f5-f4017c979341");
            var stats = await faceit.GetMatchStats("1-0adad55f-a297-4292-ad8d-83f3c6180215");
            Assert.IsNotNull(stats.Rounds[0].GameID);
        }

        [TestMethod]
        public async Task GetOrganizerDetailsFromName()
        {
            var faceit = new FaceitClient("7ee029c0-53bf-495a-a8f5-f4017c979341");
            var details = await faceit.GetOrganizerDetailsFromName("MapCore");
            Assert.IsNotNull(details.FaceitURL);
        }

        [TestMethod]
        public async Task GetOrganizerDetailsFromID()
        {
            var faceit = new FaceitClient("7ee029c0-53bf-495a-a8f5-f4017c979341");
            var details = await faceit.GetOrganizerDetailsFromID("36261b68-5e5f-4a88-8c98-b1f4514f6783");
            Assert.IsNotNull(details.FaceitURL);
        }

        [TestMethod]
        public async Task GetOrganizerChampionships()
        {
            var faceit = new FaceitClient("7ee029c0-53bf-495a-a8f5-f4017c979341");
            var champs = await faceit.GetOrganizerChampionships("36261b68-5e5f-4a88-8c98-b1f4514f6783");
            Assert.IsNotNull(champs.Items[0].IsAnticheatRequired);
        }

        [TestMethod]
        public async Task GetOrganizerGames()
        {
            var faceit = new FaceitClient("7ee029c0-53bf-495a-a8f5-f4017c979341");
            var games = await faceit.GetOrganizerGames("36261b68-5e5f-4a88-8c98-b1f4514f6783");
            Assert.IsNotNull(games.Items[0].GameID);
        }

        [TestMethod]
        public async Task GetOrganizerHubs()
        {
            var faceit = new FaceitClient("7ee029c0-53bf-495a-a8f5-f4017c979341");
            var hubs = await faceit.GetOrganizerHubs("36261b68-5e5f-4a88-8c98-b1f4514f6783");
            Assert.IsNotNull(hubs.Items[0].Name);
        }

        [TestMethod]
        public async Task GerOrganizerTournaments()
        {
            var faceit = new FaceitClient("7ee029c0-53bf-495a-a8f5-f4017c979341");
            var tourneys = await faceit.GetOrganizerTournaments("36261b68-5e5f-4a88-8c98-b1f4514f6783", "past");
            Assert.IsNotNull(tourneys);
        }

        [TestMethod]
        public async Task GetPlayerDetailsFromNickname()
        {
            var faceit = new FaceitClient("7ee029c0-53bf-495a-a8f5-f4017c979341");
            var player = await faceit.GetPlayerDetailsFromNickname("Squidski");
            Assert.IsNotNull(player.Games.CSGO.GamePlayerID);
        }

        [TestMethod]
        public async Task GetPlayerDetailsFromID()
        {
            var faceit = new FaceitClient("7ee029c0-53bf-495a-a8f5-f4017c979341");
            var player = await faceit.GetPlayerDetailsFromID("91fbfa1d-09bd-407a-b663-7250d6379d6a");
            Assert.IsNotNull(player.Country);
        }

        [TestMethod]
        public async Task GetPlayerMatchHistory()
        {
            var faceit = new FaceitClient("7ee029c0-53bf-495a-a8f5-f4017c979341");
            var matches = await faceit.GetPlayerMatchHistory("91fbfa1d-09bd-407a-b663-7250d6379d6a", "csgo", 0, 0, 0, 1);
            Assert.IsNotNull(matches.Items[0].GameID);
        }

        [TestMethod]
        public async Task GetPlayerHubs()
        {
            var faceit = new FaceitClient("7ee029c0-53bf-495a-a8f5-f4017c979341");
            var hubs = await faceit.GetPlayerHubs("91fbfa1d-09bd-407a-b663-7250d6379d6a");
            Assert.IsNotNull(hubs.Items[0].OrganizerID);
        }

        [TestMethod]
        public async Task GetPlayerStats()
        {
            var faceit = new FaceitClient("7ee029c0-53bf-495a-a8f5-f4017c979341");
            var stats = await faceit.GetPlayerStats("91fbfa1d-09bd-407a-b663-7250d6379d6a", "csgo");
            Assert.IsNotNull(stats.Lifetime.CurrentWinstreak);
        }

        [TestMethod]
        public async Task GetPlayerTournaments()
        {
            var faceit = new FaceitClient("7ee029c0-53bf-495a-a8f5-f4017c979341");
            var tourneys = await faceit.GetPlayerTournaments("91fbfa1d-09bd-407a-b663-7250d6379d6a");
            Assert.IsNotNull(tourneys.Items[0].PrizeType);
        }

        [TestMethod]
        public async Task GetGameRanking()
        {
            var faceit = new FaceitClient("7ee029c0-53bf-495a-a8f5-f4017c979341");
            var ranking = await faceit.GetGameRanking("csgo", FaceitLib.Constants.Regions.Europe, FaceitLib.Constants.Countries.France);
            Assert.IsNotNull(ranking);
        }

        [TestMethod]
        public async Task GetPlayerRankingInGame()
        {
            var faceit = new FaceitClient("7ee029c0-53bf-495a-a8f5-f4017c979341");
            var ranking = await faceit.GetPlayerRankingInGame("csgo", FaceitLib.Constants.Regions.NorthAmerica, "91fbfa1d-09bd-407a-b663-7250d6379d6a");
            Assert.IsNotNull(ranking.Position);
        }

        [TestMethod]
        public async Task SearchChampionships()
        {
            var faceit = new FaceitClient("7ee029c0-53bf-495a-a8f5-f4017c979341");
            var champs = await faceit.SearchChampionships("Mythic");
            Assert.IsNotNull(champs);
        }

        [TestMethod]
        public async Task SearchHubs()
        {
            var faceit = new FaceitClient("7ee029c0-53bf-495a-a8f5-f4017c979341");
            var hubs = await faceit.SearchHubs("MapCore");
            Assert.IsNotNull(hubs);
        }

        [TestMethod]
        public async Task SearchOrganizers()
        {
            var faceit = new FaceitClient("7ee029c0-53bf-495a-a8f5-f4017c979341");
            var organizers = await faceit.SearchOrganizers("MapCore");
            Assert.IsNotNull(organizers);
        }

        [TestMethod]
        public async Task SearchPlayers()
        {
            var faceit = new FaceitClient("7ee029c0-53bf-495a-a8f5-f4017c979341");
            var players = await faceit.SearchPlayers("Squidski");
            Assert.IsNotNull(players);
        }

        [TestMethod]
        public async Task SearchTeams()
        {
            var faceit = new FaceitClient("7ee029c0-53bf-495a-a8f5-f4017c979341");
            var teams = await faceit.SearchTeams("brian");
            Assert.IsNotNull(teams);
        }

        [TestMethod]
        public async Task SearchTournaments()
        {
            var faceit = new FaceitClient("7ee029c0-53bf-495a-a8f5-f4017c979341");
            var champs = await faceit.SearchTournaments("Mythic");
            Assert.IsNotNull(champs);
        }

        [TestMethod]
        public async Task GetTeamDetails()
        {
            var faceit = new FaceitClient("7ee029c0-53bf-495a-a8f5-f4017c979341");
            var team = await faceit.GetTeamDetails("1b6d3244-80ea-4adc-a6bf-2c430038dc14");
            Assert.IsNotNull(team);
        }

        [TestMethod]
        public async Task GetTeamStats()
        {
            var faceit = new FaceitClient("7ee029c0-53bf-495a-a8f5-f4017c979341");
            var team = await faceit.GetTeamStats("1b6d3244-80ea-4adc-a6bf-2c430038dc14", "csgo");
            Assert.IsNotNull(team);
        }

        [TestMethod]
        public async Task GetTeamTournaments()
        {
            var faceit = new FaceitClient("7ee029c0-53bf-495a-a8f5-f4017c979341");
            var team = await faceit.GetTeamTournaments("1b6d3244-80ea-4adc-a6bf-2c430038dc14");
            Assert.IsNotNull(team);
        }

        [TestMethod]
        public async Task GetTournamentDetails()
        {
            var faceit = new FaceitClient("7ee029c0-53bf-495a-a8f5-f4017c979341");
            var team = await faceit.GetTournamentDetails("79faccdc-8807-4f32-9428-e79bf9166f00", true, true);
            Assert.IsNotNull(team);
        }

        [TestMethod]
        public async Task GetTournamentBrackets()
        {
            var faceit = new FaceitClient("7ee029c0-53bf-495a-a8f5-f4017c979341");
            var team = await faceit.GetTournamentBrackets("79faccdc-8807-4f32-9428-e79bf9166f00");
            Assert.IsNotNull(team);
        }

        [TestMethod]
        public async Task GetTournamentMatches()
        {
            var faceit = new FaceitClient("7ee029c0-53bf-495a-a8f5-f4017c979341");
            var matches = await faceit.GetTournamentMatches("79faccdc-8807-4f32-9428-e79bf9166f00");
            Assert.IsNotNull(matches);
        }

        [TestMethod]
        public async Task GetTournamentTeams()
        {
            var faceit = new FaceitClient("7ee029c0-53bf-495a-a8f5-f4017c979341");
            var matches = await faceit.GetTournamentTeams("79faccdc-8807-4f32-9428-e79bf9166f00");
            Assert.IsNotNull(matches);
        }


    }
}
