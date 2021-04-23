using System.Reflection;
using com.orthofeet.Entities;
using com.orthofeet.EntityFramework;
using com.orthofeet.Mappings;
using com.orthofeet.Repositories;
using com.orthofeet.Repositories.Interfaces;
using com.orthofeet.Services;
using com.orthofeet.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;

namespace Orthoweb.Tests
{
    public class TestBase
    {
        protected ServiceProvider ServiceProvider;

        [SetUp]
        public void Setup()
        {
            var iConfig = TestsHelpers.GetConfigurationRoot(TestContext.CurrentContext.TestDirectory);
            var config = TestsHelpers.GetApplicationConfiguration(TestContext.CurrentContext.TestDirectory);
            var services = new ServiceCollection();
            services.AddSingleton(iConfig);
            services.AddSingleton(config);
            services.AddDbContext<SageX3Context>(builder =>
            {
                builder.UseSqlServer(config.SageX3ConnectionString, opt =>
                {
                    opt.EnableRetryOnFailure();
                    opt.CommandTimeout(15);
                });
            }, ServiceLifetime.Transient);

            services.AddDbContext<X3SageDbContext>(builder =>
            {
	            builder.UseSqlServer(config.SageX3ConnectionString, opt =>
	            {
		            opt.EnableRetryOnFailure();
		            opt.CommandTimeout(15);
	            });
            }, ServiceLifetime.Transient);
            



            var amAssembly = Assembly.GetAssembly(typeof(X3SageMappingProfile));
            services.AddAutoMapper(amAssembly);
            services.AddTransient<IOrderingRepository, OrderingRepository>();
            services.AddTransient<IInventoryRepository, InventoryRepository>();
            services.AddTransient<IReferenceRepository, ReferenceRepository>();
            services.AddTransient<IShopifyService, ShopifyService>();

            ServiceProvider = services.BuildServiceProvider();
        }
    }
}