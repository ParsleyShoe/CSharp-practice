using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using WebEducationService.Data;

/* create project with ASP.NET Core 3.1, select API, uncheck HTTPS
 * install packages => microsoft.entityframeworkcore.(tools, proxies, sqlserver(, system.configuration.configurationmanager))
 * create Models folder, create model(s) with proper properties
 * add controller(s) to Controllers, select API Controller with EF, select Model class and context, ensure Context is created/generated
 * modify connection string in appsettings.json => (server=localhost\\sqlexpress;database=[DATABASE];trusted_connection=true;)
 * modify ConfigureServices (add UseLazyLoadingProxies() to AddDbContext() body, and add AddCors())
 * add properties AllowOrigins, AllowMethods, and DefaultCorsPolicy
 * (bootcamp optional) add scope variable for foreign(?) migrations */

namespace WebEducationService {
    public class Startup {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public readonly string DefaultCorsPolicy = "_defaultCorsPolicy";
        public string[] AllowOrigins = { "http://localhost:4200" };
        public string[] AllowMethods = { "GET", "POST", "PUT", "DELETE" };

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {
            services.AddControllers();
            services.AddDbContext<EdDbContext>(options => {
                options.UseLazyLoadingProxies();
                options.UseSqlServer(Configuration.GetConnectionString("EdDbContext"));
            });
            services.AddCors(option =>
                option.AddPolicy(DefaultCorsPolicy, x =>
                    x.WithOrigins(AllowOrigins).WithMethods(AllowMethods).AllowAnyHeader()
                )
            );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors(DefaultCorsPolicy);
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });

            using var scope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope();
            scope.ServiceProvider.GetService<EdDbContext>().Database.Migrate();
        }
    }
}
