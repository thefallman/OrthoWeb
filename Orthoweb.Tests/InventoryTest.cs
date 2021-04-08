using System.Threading.Tasks;
using com.orthofeet.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;

namespace Orthoweb.Tests
{
    public class InventoryTest: TestBase
    {
           
        [Test]
        public void GetOrderHeader()
        {
            var repo = ServiceProvider.GetRequiredService<IInventoryRepository>();
            var result = Task.Run(async () => await repo.GetInventory("517W115")).GetAwaiter().GetResult();
            Assert.IsNotNull(result);
        }
    }
}