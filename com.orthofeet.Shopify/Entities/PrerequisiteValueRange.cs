using Newtonsoft.Json;

namespace com.orthofeet.Shopify.Entities
{
    public class PrerequisiteValueRange
    {
        [JsonProperty("less_than_or_equal_to")]
        public decimal? LessThanOrEqualTo { get; set; }

        [JsonProperty("greater_than_or_equal_to")]
        public decimal? GreaterThanOrEqualTo { get; set; }
    }
}