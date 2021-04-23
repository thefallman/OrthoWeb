using System.Threading.Tasks;
using com.orthofeet.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;

namespace Orthoweb.Tests
{
    public class X3ConnectivityTests: TestBase
    {
        [Test]
        public void GetInvoice()
        {
            var repo = ServiceProvider.GetRequiredService<IOrderingRepository>();
            var result = Task.Run(async () => await repo.GetInvoiceHeader("SCM088495")).GetAwaiter().GetResult();
            Assert.IsNotNull(result);
        }
        
        [Test]
        public void GetOrderHeader()
        {
            var repo = ServiceProvider.GetRequiredService<IOrderingRepository>();
            var result = Task.Run(async () => await repo.GetOrderHeader("SO1107675")).GetAwaiter().GetResult();
            Assert.IsNotNull(result);
        }
        [Test]
        public void GetOrderDetails()
        {
            var repo = ServiceProvider.GetRequiredService<IOrderingRepository>();
            var result = Task.Run(async () => await repo.GetOrderDetail("SO1107675")).GetAwaiter().GetResult();
            Assert.IsNotNull(result);
        }
        [Test]
        public void CreateOrderHeader()
        {
	        var repo = ServiceProvider.GetRequiredService<IOrderingRepository>();
	        var result = repo.CreateOrder("ZPO0000001");
	        Assert.IsNotNull(result);
        }
    }
}