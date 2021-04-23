using System;
using System.Collections.Generic;
using com.orthofeet.Shopify.Entities;
using Newtonsoft.Json;

namespace com.orthofeet.Shopify.Filters
{
    /// <summary>
    /// You **must** include InventoryItemIds, LocationIds, or both as filter parameters.
    /// </summary>
    public class InventoryLevelListFilter : ListFilter<InventoryLevel>
    {
        [JsonProperty("inventory_item_ids")]
        public IEnumerable<long> InventoryItemIds { get; set; }

        [JsonProperty("location_ids")]
        public IEnumerable<long> LocationIds { get; set; }
        
        [JsonProperty("updated_at_min")]
        public DateTimeOffset? UpdatedAtMin { get; set; }
    }
}
