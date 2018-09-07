using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Kendo.Mvc.Examples.Extensions;
using Kendo.Mvc.Examples.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Serialization;

namespace Kendo.Mvc.Examples
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            Configuration = configuration;
            WebRootPath = env.WebRootPath;
        }

        public IConfiguration Configuration { get; }

        public static string WebRootPath { get; private set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // // Add Entity Framework services to the services container.
            services.AddDbContext<SampleEntitiesDataContext>();

            // Add MVC services to the services container.
            services
                .AddMvc()
                .AddJsonOptions(options => options.SerializerSettings.ContractResolver = new DefaultContractResolver());

            services
                .AddDistributedMemoryCache()
                .AddSession();

            // Add Kendo UI services to the services container
            services.AddKendo();

            // Add Demo database services to the services container
            services.AddKendoDemo();
        }

        // Configure is called after ConfigureServices is called.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                //app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            // Add static files to the request pipeline.
            app.UseStaticFiles();

            app.UseSession();

            // Add MVC to the request pipeline.
            app.UseMvc(routes =>
            {
                routes.AddHyphenatedRoute();

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
