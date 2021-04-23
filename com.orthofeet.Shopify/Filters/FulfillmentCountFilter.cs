using System;
using com.orthofeet.Shopify.Infrastructure;
using Newtonsoft.Json;

namespace com.orthofeet.Shopify.Filters
{
    public class FulfillmentCountFilter : Parameterizable
    {
        /// <summary>
        /// Restricts results to those last updated after date and time.
        /// </summary>
        [JsonProperty("updated_at_min")]
        public DateTimeOffset? UpdatedAtMin { get; set; }

        /// <summary>
        /// Restricts results to those last updated before date and time.
        /// </summary>
        [JsonProperty("updated_at_max")]
        public DateTimeOffset? UpdatedAtMax { get; set; }
        
        /// <summary>
        /// Restricts results to those created at or after date and time.
        /// </summary>
        [JsonProperty("created_at_min")]
        public DateTimeOffset? CreatedAtMin { get; set; }

        /// <summary>
        /// Restricts results to those created at or before date and time.
        /// </summary>
        [JsonProperty("created_at_max")]
        public DateTimeOffset? CreatedAtMax { get; set; }
    }
}