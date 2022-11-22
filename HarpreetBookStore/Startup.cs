using HarpreetsBooks.DataAccess.Data; // added the reference 
using HarpreetsBooks.DataAccess.Repository;
using HarpreetsBooks.DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarpreetBookStore
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<IdentityUser>() //options => options.SignIn.RequireConfirmedAccount = true    removed this 
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddScoped<IUnitOfWork, UnitOfWork>(); // added this // dupd the iuow to res
            services.AddControllersWithViews();
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {

                endpoints.MapAreaControllerRoute(
                    name: "Area",   //created a new endpoint for area
                    areaName:"Customer",
                    pattern: "{area=Customer}/{controller=Home}/{action=Index}/{id?}");// modified the pattern with the {area=Customer}
            endpoints.MapAreaControllerRoute(
                name: "Area",
                areaName: "Admin",
                pattern: "{area=Admin}/{controller=Home}/{action=Index}/{id?}"
                    );

                 /*endpoints.MapAreaControllerRoute(
                name: "Area",
                areaName: "CoverType",
                pattern: "{area=CoverType}/{controller=Home}/{action=Index}/{id?}"
                    );*/
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"); // modified the pattern with the {area=Customer}
                endpoints.MapRazorPages();
            });
        }
    }
}
