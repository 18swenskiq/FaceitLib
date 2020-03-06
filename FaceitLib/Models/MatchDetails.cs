using FaceitLib.Models.Shared;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace FaceitLib.Models
{
    public class MatchDetails
    {
        [JsonProperty(PropertyName = "team_id")]
        public int BestOf { get; set; }

        [JsonProperty(PropertyName = "broadcast_start_time")]
        public int BroadcastStartTime { get; set; }

        [JsonProperty(PropertyName = "broadcast_start_time_label")]
        public string BroadcastStartTimeLabel { get; set; }

        [JsonProperty(PropertyName = "calculate_elo")]
        public bool IsCalculateELO { get; set; }

        [JsonProperty(PropertyName = "chat_room_id")]
        public string ChatRoomID { get; set; }

        [JsonProperty(PropertyName = "competition_id")]
        public string CompetitionID { get; set; }

        [JsonProperty(PropertyName = "competition_name")]
        public string CompetitionName { get; set; }

        [JsonProperty(PropertyName = "competition_type")]
        public string CompetitionType { get; set; }

        [JsonProperty(PropertyName = "configured_at")]
        public int ConfiguredAt { get; set; }

        [JsonProperty(PropertyName = "demo_url")]
        public List<string> DemoURL { get; set; }

        [JsonProperty(PropertyName = "faceit_url")]
        public string FaceitURL { get; set; }

        [JsonProperty(PropertyName = "finished_at")]
        public int FinishedAt { get; set; }
        public string Game { get; set; }
        public int Group { get; set; }

        [JsonProperty(PropertyName = "match_id")]
        public string MatchID { get; set; }

        [JsonProperty(PropertyName = "organizer_id")]
        public string OrganizerID { get; set; }
        public string Region { get; set; }
        public Results Results { get; set; }
        public int Round { get; set; }

        [JsonProperty(PropertyName = "scheduled_at")]
        public int ScheduledAt { get; set; }

        [JsonProperty(PropertyName = "started_at")]
        public int StartedAt { get; set; }
        public string Status { get; set; }
        public Teams Teams { get; set; }
        public int Version { get; set; }
        public Voting Voting { get; set; }
    }
}
