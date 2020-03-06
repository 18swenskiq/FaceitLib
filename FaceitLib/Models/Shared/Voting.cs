using Newtonsoft.Json;
using System.Collections.Generic;

namespace FaceitLib.Models.Shared
{
    public class Voting
    {
        [JsonProperty(PropertyName = "voted_entity_types")]
        public List<string> VotedEntityTypes { get; set; }
        public VotingInfo Location { get; set; }
        public VotingInfo Map { get; set; }
    }

    public class VotingInfo
    {
        public List<Entity> Entities { get; set; }
        public List<string> Pick { get; set; }
    }
}
