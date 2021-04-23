using com.orthofeet.Shopify.Infrastructure;
using Newtonsoft.Json;

namespace com.orthofeet.Shopify.Filters
{
    public class ScriptTagCountFilter : Parameterizable
    {
        /// <summary>
        /// Restricts results to those with the given src value.
        /// </summary>
        [JsonProperty("src")]
        public string Src { get; set; }
    }
}