using System;
using Newtonsoft.Json;

namespace com.orthofeet.Shopify.Entities
{
    public class MerchantRequestOptions
    {
        [JsonProperty("shipping_method")]
        public string ShippingMethod { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("date")]
        public DateTimeOffset? Date { get; set; }
    }
}