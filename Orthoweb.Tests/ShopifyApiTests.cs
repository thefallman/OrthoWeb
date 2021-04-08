using System.Threading.Tasks;
using com.orthofeet.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;

namespace Orthoweb.Tests
{
    public class ShopifyApiTests: TestBase
    {
        [Test]
        public void AuthenticationTest()
        {
            var service = ServiceProvider.GetRequiredService<IShopifyService>();
            var result = Task.Run(async () => await service.Authorize()).GetAwaiter().GetResult();
            Assert.IsTrue(result);
        }

    }
}