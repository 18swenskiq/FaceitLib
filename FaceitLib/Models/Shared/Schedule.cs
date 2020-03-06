using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FaceitLib.Models.Shared
{
    public class Schedule
    {
        [JsonProperty(PropertyName = "1")]
        public ScheduleNum numberone { get; set; }

        [JsonProperty(PropertyName = "2")]
        public ScheduleNum numbertwo { get; set; }

        [JsonProperty(PropertyName = "3")]
        public ScheduleNum numberthree { get; set; }

        [JsonProperty(PropertyName = "4")]
        public ScheduleNum numberfour { get; set; }

        [JsonProperty(PropertyName = "5")]
        public ScheduleNum numberfive { get; set; }

    }

    public class ScheduleNum
    {
        public Int64 date { get; set; }
        public string status { get; set; }
    }
}
