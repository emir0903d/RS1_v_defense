using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PRENATALv2.Areas.Home.Models;

namespace PRENATALv2
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
            services.AddDbContext<Context>(options =>
            {
            options.UseSqlServer(Configuration.GetConnectionString("plesk01"));
            });

            services.AddIdentity<AppUser, AppRole>(cfg =>
            {
                cfg.Password.RequiredLength = 8;
                cfg.Password.RequireDigit = true;
                cfg.Password.RequireNonAlphanumeric = true;
                cfg.Password.RequireUppercase = true;
                cfg.Password.RequireLowercase = true;
                cfg.SignIn.RequireConfirmedPhoneNumber = false;
                cfg.SignIn.RequireConfirmedEmail = true;
                cfg.SignIn.RequireConfirmedAccount = true;

            }).AddEntityFrameworkStores<Context>().AddDefaultTokenProviders();
           
            
            //services.Configure<SecurityStampValidatorOptions>(options =>//
            //        options.ValidationInterval = TimeSpan.FromSeconds(10));//

            
            services.ConfigureApplicationCookie(cfg =>
            {
                cfg.Cookie.Name = "Identity.Cookie";
                cfg.LoginPath = "/Account/Login";

                //cfg.SlidingExpiration = true;//
                //cfg.ExpireTimeSpan = TimeSpan.FromMinutes(30);//
            });

            services.AddControllersWithViews();
            services.AddMvc(options =>
            {
                options.EnableEndpointRouting = false;

                var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
                options.Filters.Add(new AuthorizeFilter(policy));

                options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute());//
            })
                .AddXmlSerializerFormatters().AddControllersAsServices();

            services.AddRazorPages().AddViewOptions(options => options.HtmlHelperOptions.ClientValidationEnabled = true);

            

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            
            app.UseAuthentication();
            app.UseAuthorization();
           
            app.UseEndpoints(endpoints =>
            {
                
                endpoints.MapControllers();
                endpoints.MapRazorPages();
            

                endpoints.MapAreaControllerRoute(
                  name: "Admin",
                  areaName: "Admin",
                  pattern: "{area:exists}/{controller=RemoteValidation}/{action=Index}/{id?}"
                );
                endpoints.MapAreaControllerRoute(
                  name: "Admin",
                  areaName: "Admin",
                  pattern: "{area:exists}/{controller=Email}/{action=Index}/{id?}"
                );
                endpoints.MapAreaControllerRoute(
                  name: "Admin",
                  areaName: "Admin",
                  pattern: "{area:exists}/{controller=Administration}/{action=Index}/{id?}"
                );
                endpoints.MapAreaControllerRoute(
                  name: "Home",
                  areaName:"Home",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
                endpoints.MapAreaControllerRoute(
                   name: "Home",
                   areaName: "Home",
                   pattern: "{area:exists}/{controller=Account}/{action=Index}/{id?}"
                 );
                endpoints.MapAreaControllerRoute(
                  name: "Home",
                  areaName: "Home",
                  pattern: "{area:exists}/{controller=Charts}/{action=Index}/{id?}"
                );
                
                endpoints.MapAreaControllerRoute(
                  name: "Employees",
                  areaName: "Employees",
                  pattern: "{area:exists}/{controller=Doctors}/{action=Index}/{id?}"
                );
                endpoints.MapAreaControllerRoute(
                  name: "Employees",
                  areaName: "Employees",
                  pattern: "{area:exists}/{controller=Nurses}/{action=Index}/{id?}"
                );
                endpoints.MapAreaControllerRoute(
                  name: "Employees",
                  areaName: "Employees",
                  pattern: "{area:exists}/{controller=Patients}/{action=Index}/{id?}"
                );
                endpoints.MapAreaControllerRoute(
                  name: "Records",
                  areaName: "Records",
                  pattern: "{area:exists}/{controller=Therapies}/{action=Index}/{id?}"
                );
                endpoints.MapAreaControllerRoute(
                  name: "Records",
                  areaName: "Records",
                  pattern: "{area:exists}/{controller=PregnanciesPrevious}/{action=Index}/{id?}"
                );
                endpoints.MapAreaControllerRoute(
                  name: "Records",
                  areaName: "Records",
                  pattern: "{area:exists}/{controller=PregnanciesLoss}/{action=Index}/{id?}"
                );
                endpoints.MapAreaControllerRoute(
                  name: "Records",
                  areaName: "Records",
                  pattern: "{area:exists}/{controller=VitalSigns}/{action=Index}/{id?}"
                );
                endpoints.MapAreaControllerRoute(
                  name: "Records",
                  areaName: "Records",
                  pattern: "{area:exists}/{controller=SubstancesUse}/{action=Index}/{id?}"
                );
                endpoints.MapAreaControllerRoute(
                  name: "Records",
                  areaName: "Records",
                  pattern: "{area:exists}/{controller=MedicalRecords}/{action=Index}/{id?}"
                );
                endpoints.MapAreaControllerRoute(
                  name: "Records",
                  areaName: "Records",
                  pattern: "{area:exists}/{controller=Allergies}/{action=Index}/{id?}"
                );
                endpoints.MapAreaControllerRoute(
                  name: "Records",
                  areaName: "Records",
                  pattern: "{area:exists}/{controller=Partners}/{action=Index}/{id?}"
                );
                endpoints.MapAreaControllerRoute(
                  name: "Records",
                  areaName: "Records",
                  pattern: "{area:exists}/{controller=Files}/{action=Index}/{id?}"
                );
                endpoints.MapAreaControllerRoute(
                  name: "Records",
                  areaName: "Records",
                  pattern: "{area:exists}/{controller=Photos}/{action=Index}/{id?}"
                );
                endpoints.MapAreaControllerRoute(
                  name: "Admin",
                  areaName: "Admin",
                  pattern: "{area:exists}/{controller=SMS}/{action=Index}/{id?}"
                );
                endpoints.MapAreaControllerRoute(
                name: "Home",
                areaName: "Home",
                pattern: "{area:exists}/{controller=Profile}/{action=Index}/{id?}"
              );
                endpoints.MapAreaControllerRoute(
                name: "Home",
                areaName: "Home",
                pattern: "{area:exists}/{controller=TwoFactorAuth}/{action=Index}/{id?}"
              );
                endpoints.MapControllerRoute(
                name: "default",
                pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
            });

        }
    }
}
