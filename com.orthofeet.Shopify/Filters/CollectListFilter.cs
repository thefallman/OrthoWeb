using com.orthofeet.Shopify.Entities;
using Newtonsoft.Json;

namespace com.orthofeet.Shopify.Filters
{
    public class CollectListFilter : ListFilter<Collect>
    {
        /// <summary>
        /// Restrict results to after the specified ID.
        /// </summary>
        [JsonProperty("since_id")]
        public long? SinceId { get; set; }

        /// <summary>
        /// Restrict results to after the specified ID.
        /// </summary>
        [JsonProperty("collection_id")]
        public long? CollectionId { get; set; }

        /// <summary>
        /// Restrict results to after the specified ID.
        /// </summary>
        [JsonProperty("product_id")]
        public long? ProductId { get; set; }
    }
}