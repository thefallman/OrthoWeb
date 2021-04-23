using System.Reflection;
using com.orthofeet.Entities;
using com.orthofeet.EntityFramework;
using com.orthofeet.Mappings;
using com.orthofeet.Repositories;
using com.orthofeet.Repositories.Interfaces;
using com.orthofeet.Services;
using com.orthofeet.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestPlatform.Common.Interfaces;
using NUnit.Framework;
using OrthoWeb;

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
            
            
            services.AddDbContext<OfApiDbContext>(builder =>
            {
	            builder.UseSqlServer(config.OfApiConnectionString, opt =>
	            {
		            opt.EnableRetryOnFailure();
		            opt.CommandTimeout(15);
	            });
            }, ServiceLifetime.Transient);

            DiRegistrar.InjectDependencies(services, iConfig);
            ServiceProvider = services.BuildServiceProvider();
        }
    }
}