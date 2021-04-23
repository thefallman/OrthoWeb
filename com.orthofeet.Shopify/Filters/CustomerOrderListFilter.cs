using System;
using com.orthofeet.Shopify.Infrastructure;
using Newtonsoft.Json;

namespace com.orthofeet.Shopify.Filters
{
    public class CustomerOrderListFilter : Parameterizable
    {
        /// <summary>
        /// Restricts results to those with the given status. Known values are "open", "closed", "cancelled" and "any".
        /// </summary>
        [JsonProperty("status"), Obsolete("This filter property is undocumented, and Shopify may remove support for it at any time. Use with caution.")]
        public string Status { get; set; }
    }
}