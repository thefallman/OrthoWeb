using System;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using com.orthofeet.Services.Interfaces;

namespace com.orthofeet.Services
{
    /// <summary>
    /// Private App Name: OrthoShopify API Gateway
    /// </summary>
    public class ShopifyService: ServiceBase, IShopifyService
    {
        private const string API_KEY = "55828496ba355581cf24ec534b6e8885";
        private const string API_PASS = "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";
        private const string API_SHARED_SECRET = "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";//authorize webhooks
        public ShopifyService(IAppSettingsService appSettingsService) : base(appSettingsService)
        {
        }

        public async Task<bool> Authorize()
        {
            using var webClient = new WebClient();
            var auth = $"Basic {Convert.ToBase64String(Encoding.UTF8.GetBytes($"{API_KEY}:{API_PASS}"))}";
            webClient.Headers.Add(HttpRequestHeader.Authorization, auth);
            var url = $"https://orthofeet.myshopify.com/admin/api/2021-04/shop.json";
            var result = await webClient.DownloadStringTaskAsync(new Uri(url));
            return false;
        }
    }
}
