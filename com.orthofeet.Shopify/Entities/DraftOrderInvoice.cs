using System.Collections.Generic;
using com.orthofeet.Shopify.Infrastructure;
using Newtonsoft.Json;

namespace com.orthofeet.Shopify.Entities 
{
    public class DraftOrderInvoice : Parameterizable
    {
        [JsonProperty("to")]            
        public string To { get; set; }

        [JsonProperty("from")]    
        public string From { get; set; }

        [JsonProperty("bcc")]    
        public IEnumerable<string> BCC { get; set; }

        [JsonProperty("subject")]    
        public string Subject { get; set; }

        [JsonProperty("custom_message")]    
        public string CustomMessage { get; set; }
    }
}