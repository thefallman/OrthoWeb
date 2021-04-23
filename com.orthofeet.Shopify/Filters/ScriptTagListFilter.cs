using com.orthofeet.Shopify.Entities;
using Newtonsoft.Json;

namespace com.orthofeet.Shopify.Filters
{
    /// <summary>
    /// Options for filtering lists of Script Tags.
    /// </summary>
    public class ScriptTagListFilter : ListFilter<ScriptTag>
    {
        /// <summary>
        /// Restricts results to those with the given src value.
        /// </summary>
        [JsonProperty("src")]
        public string Src { get; set; }
    }
}
