using com.orthofeet.Shopify.Infrastructure;
using Newtonsoft.Json;

namespace com.orthofeet.Shopify.Filters
{
    public class GiftCardCountFilter : Parameterizable
    {
        /// <summary>
        /// Restricts results to those with the given status. Known values are "enabled", "disabled".
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}