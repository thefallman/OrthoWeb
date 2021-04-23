using com.orthofeet.Shopify.Infrastructure;
using Newtonsoft.Json;

namespace com.orthofeet.Shopify.Filters
{
    public class AssetListFilter : Parameterizable
    {
        /// <summary>
        /// Retrieve only certain fields, specified by a comma-separated list of field names. 
        /// </summary>
        [JsonProperty("fields")]
        public string Fields { get; set; }
    }
}