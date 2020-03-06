using Newtonsoft.Json;

namespace FaceitLib.Models.Shared
{
    public class SustitutionConfiguration
    {
        [JsonProperty(PropertyName = "max_substitutes")]
        public int MaxSubstitutes { get; set; }

        [JsonProperty(PropertyName = "max_substitutions")]
        public int MaxSubstitutions { get; set; }
    }
}
