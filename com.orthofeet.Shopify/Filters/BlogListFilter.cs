using com.orthofeet.Shopify.Entities;
using Newtonsoft.Json;

namespace com.orthofeet.Shopify.Filters
{
    public class BlogListFilter : ListFilter<Blog>
    {
        [JsonProperty("handle")]
        public string Handle { get; set; }
    }
}