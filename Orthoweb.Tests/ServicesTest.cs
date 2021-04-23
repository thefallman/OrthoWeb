using System.Threading.Tasks;
using com.orthofeet.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;

namespace Orthoweb.Tests
{
	public class ServicesTest: TestBase
	{
		[Test]
		public void GetAppSettings_Test()
		{
			var svc = ServiceProvider.GetRequiredService<IAppSettingsService>();
			var result = Task.Run(async () => await svc.GetAppSettings("ShipStation", "API")).GetAwaiter().GetResult();
			Assert.IsNotEmpty(result);
		}
	}
}