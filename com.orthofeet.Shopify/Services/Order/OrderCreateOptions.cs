using com.orthofeet.Shopify.Infrastructure;
using Newtonsoft.Json;

namespace com.orthofeet.Shopify.Services.Order
{
    public class OrderCreateOptions : Parameterizable
    {
        [JsonProperty("send_webhooks")]
        public bool? SendWebhooks { get; set; }

        [JsonProperty("send_receipt")]
        public bool? SendReceipt { get; set; }

        [JsonProperty("send_fulfillment_receipt")]
        public bool? SendFulfillmentReceipt { get; set; }

        /// <summary>
        /// The inventory behavior for the order. Known values are 'bypass', 'decrement_ignoring_policy' and 'decrement_obeying_policy'.
        /// </summary>
        [JsonProperty("inventory_behaviour")]
        public string InventoryBehavior { get; set; }
    }
}
