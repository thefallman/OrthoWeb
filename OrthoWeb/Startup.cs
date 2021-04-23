using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using com.orthofeet.Mappings;
using com.orthofeet.Repositories;
using com.orthofeet.Repositories.Interfaces;
using AutoMapper;
using com.orthofeet.EntityFramework;
using com.orthofeet.Services;
using com.orthofeet.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using NLog;
using NLog.Web;

namespace OrthoWeb
{
    public class Startup
    {
	    private readonly Logger _logger;
	    public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
	        _logger = NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();
            Configuration = configuration;
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
	        InjectDependencies(services);
	        InitEf(services);
            services.AddControllers();
            services.AddCors(options =>
            {
	            options.AddPolicy("CorsPolicy", builder => builder
		            .WithOrigins("*")
		            .AllowAnyHeader()
		            .AllowAnyMethod()
		            .AllowCredentials());
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
	        
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

           // app.ConfigureExceptionHandler(_logger);
            app.UseRouting();

            //app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }


        private void InitEf(IServiceCollection services)
        {
	        services.AddDbContext<X3SageDbContext>(builder =>
	        {
		        builder.UseSqlServer(Configuration.GetConnectionString("SageX3"), opt =>
		        {
			        opt.EnableRetryOnFailure();
			        opt.CommandTimeout(15);
		        });
	        }, ServiceLifetime.Transient);

	        services.AddDbContext<OfApiDbContext>(builder =>
	        {
		        builder.UseSqlServer(Configuration.GetConnectionString("ofapi"), opt =>
		        {
			        opt.EnableRetryOnFailure();
			        opt.CommandTimeout(15);
		        });
	        }, ServiceLifetime.Transient);
        }


        private void InjectDependencies(IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetAssembly(typeof(GlobalMapper)));
            services.AddSingleton(Configuration);
            services.AddTransient<ISystemRepository, SystemRepository>();
            services.AddTransient<IShipStationService, ShipStationService>();
        }
    }
}
