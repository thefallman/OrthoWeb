using System.Threading.Tasks;
using com.orthofeet.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;

namespace Orthoweb.Tests
{
    public class ReferenceTests: TestBase
    {
        [Test]
        public void GetFacility()
        {
            var repo = ServiceProvider.GetRequiredService<IReferenceRepository>();
            var result = Task.Run(async () => await repo.GetFacilities()).GetAwaiter().GetResult();
            Assert.IsNotNull(result);
        }
    }
}