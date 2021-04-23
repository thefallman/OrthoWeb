using com.orthofeet.Shopify.Infrastructure;
using Newtonsoft.Json;

namespace com.orthofeet.Shopify.Filters
{
    public class RedirectCountFilter : Parameterizable
    {
        /// <summary>
        /// An optional parameter that filters the result to redirects with the given path.
        /// </summary>
        [JsonProperty("path")]
        public string Path { get; set; }

        /// <summary>
        /// An optional parameter that filters the result to redirects with the given target.
        /// </summary>
        [JsonProperty("target")]
        public string Target { get; set; }
    }
}