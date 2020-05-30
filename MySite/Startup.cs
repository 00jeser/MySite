using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NuGet.Frameworks;

namespace MySite
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews().SetCompatibilityVersion(CompatibilityVersion.Version_3_0).AddSessionStateTempDataProvider();
            services.AddDetection();
            services.AddDetectionCore().AddBrowser();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (true | env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/hw", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}");
                endpoints.MapControllerRoute("qualification", "Qualification/{action=Index}/{Id?}");
                endpoints.MapControllerRoute("social", "Social/{action=Index}/{Id?}");
            });
        }
    }
    public static class singlton 
    {
        private static int id;
        public static int Id 
        {
            get
            {
                return id++;
            }
            set 
            {
                id = value;
            }
        }
    }
}
