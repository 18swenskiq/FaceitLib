using Newtonsoft.Json;

namespace FaceitLib.Models.Shared
{
    public class Assets
    {
        public string Cover { get; set; }

        [JsonProperty(PropertyName = "featured_image_l")]
        public string FeaturedImageLarge { get; set; }

        [JsonProperty(PropertyName = "featured_image_m")]
        public string FeaturedImageMedium { get; set; }

        [JsonProperty(PropertyName = "featured_image_s")]
        public string FeaturedImageSmall { get; set; }

        [JsonProperty(PropertyName = "flag_img_icon")]
        public string FlagImageIcon { get; set; }

        [JsonProperty(PropertyName = "flag_img_l")]
        public string FlagImageLarge { get; set; }

        [JsonProperty(PropertyName = "flag_img_m")]
        public string FlagImageMedium { get; set; }

        [JsonProperty(PropertyName = "flag_img_s")]
        public string FlagImageSmall { get; set; }

        [JsonProperty(PropertyName = "landing_page")]
        public string LandingPage { get; set; }
    }
}
