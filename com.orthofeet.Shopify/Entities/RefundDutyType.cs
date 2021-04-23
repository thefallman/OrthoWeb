using Newtonsoft.Json;

namespace com.orthofeet.Shopify.Entities
{
    public class RefundDutyType
    {
        [JsonProperty("duty_id")]
        public long? DutyId { get; set; }

        [JsonProperty("refund_type")]
        public string RefundType { get; set; }
    }
}
