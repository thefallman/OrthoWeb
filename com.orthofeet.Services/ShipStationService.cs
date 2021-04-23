using System;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using com.orthofeet.Services.Interfaces;
using NLog;

namespace com.orthofeet.Services
{
	public class ShipStationService: ServiceBase, IShipStationService
	{
		/*private const string API_KEY =    "0e39579348a347ea924105d88f6f2bec";
		private const string API_SECRET = "41f96b05877d4c26af4e89034ded0631";*/
		
		public ShipStationService(IAppSettingsService appSettingsService) : base(appSettingsService)
		{
		}

		public async Task GetOrder(string url)
		{
			if (string.IsNullOrEmpty(url)) return;
			try
			{
				Logger.Info($"About to call ship station API: {url}");

				var appSettings = await AppSettingsService.GetAppSettings("ShipStation", "API");
				var key = appSettings.FirstOrDefault(s => s.Name == "API_KEY")?.Value;
				var password = appSettings.FirstOrDefault(s => s.Name == "API_PASSWORD")?.Value;
				using var webClient = new WebClient();
				var authenticationString = $"{key}:{password}";
				webClient.Headers.Add(HttpRequestHeader.Authorization,  "Basic " + Convert.ToBase64String(Encoding.UTF8.GetBytes(authenticationString)));

				webClient.Headers.Add(HttpRequestHeader.ContentType, "application/json");
				var result = await webClient.DownloadStringTaskAsync(url);
				Logger.Info(result);
			}
			catch (Exception e)
			{
				Logger.Fatal(e);
			}
		}
	}
}