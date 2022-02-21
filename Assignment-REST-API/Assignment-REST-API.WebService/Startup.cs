using Assignment_REST_API.Data.Data;
using Assignment_REST_API.WebService.ApplicationInfrstucture;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_REST_API.WebService
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("AppDbConn")));
            //services.AddDbContext(Configuration);
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Assignment_REST_API.WebService", Version = "v1" });
            });

            var container = new ContainerBuilder();
            container.Populate(services);

            container.RegisterModule(new ApplicationModule());

            return new AutofacServiceProvider(container.Build());
        }

        public static class CustomExtenstionMethods
        {
            //public static IServiceCollection AddCustomDbContext(this IServiceCollection services, IConfiguration configuration)
            //{
            //    var connectionString = configuration["ConnectionString"];

            //    services.AddDbContext<ApplicationDbContext>(options =>
            //    {

            //        options.UseLazyLoadingProxies();
            //        options.UseSqlServer(configuration["ConnectionString"],
            //            sqlServerOptionsAction: sqlOptions =>
            //            {
            //                sqlOptions.EnableRetryOnFailure(maxRetryCount: 10, maxRetryDelay: TimeSpan.FromSeconds(30), errorNumbersToAdd: null);
            //            });
            //    });

            //    return services;
                 
           // }
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Assignment_REST_API.WebService v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
