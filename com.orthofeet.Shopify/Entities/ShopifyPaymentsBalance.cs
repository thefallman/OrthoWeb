using Newtonsoft.Json;

namespace com.orthofeet.Shopify.Entities
{
    /// <summary>
    /// An object representing a Shopify payments balance.
    /// </summary>
    public class ShopifyPaymentsBalance
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("amount")]
        public decimal? Amount { get; set; }
    }
}
