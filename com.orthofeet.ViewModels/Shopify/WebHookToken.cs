using System.Text.Json.Serialization;

namespace com.orthofeet.ViewModels.Shopify
{
	public class WebHookToken
	{
		[JsonPropertyName("resource_url")] 
		public string ResourceUrl { get; set; }
		[JsonPropertyName("resource_type")] 
		public string ResourceType { get; set; }
	}
}
