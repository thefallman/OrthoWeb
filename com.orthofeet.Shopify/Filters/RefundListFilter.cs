using com.orthofeet.Shopify.Entities;
using Newtonsoft.Json;

namespace com.orthofeet.Shopify.Filters
{
    public class RefundListFilter : ListFilter<Refund>
    {
        /// <summary>
        /// Show amounts in the shop currency for the underlying transaction. Default: false.
        /// </summary>
        [JsonProperty("in_shop_currency")]
        public bool? InShopCurrency { get; set; }
    }
}