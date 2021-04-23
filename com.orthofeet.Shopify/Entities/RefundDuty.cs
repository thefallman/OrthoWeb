using Newtonsoft.Json;

namespace com.orthofeet.Shopify.Entities
{
    public class RefundDuty
    {
        [JsonProperty("duty_id")]
        public long? DutyId { get; set; }

        [JsonProperty("amount_set")]
        public PriceSet AmountSet { get; set; }
    }
}
