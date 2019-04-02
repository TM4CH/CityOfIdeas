using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DAL.EF;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Domain;
using Domain.UserClasses;

namespace UI_MVC
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<ApplicationDbContext>();

            services.AddIdentity<User, Role>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddAuthentication()
            .AddGoogle(googleOptions =>
            {
                //dit is zeer onveilig en zou normaal met de secrets.json file moeten gebeuren.
                googleOptions.ClientId = "727289347009-oqqv9kalodjhc230rbb99ode1hbn7kon.apps.googleusercontent.com";
                googleOptions.ClientSecret = "pXxzYuQ9iqrPLeOmEym43sw5";
                //googleOptions.ClientId = Configuration["Authentication:Google:ClientId"];
                //googleOptions.ClientSecret = Configuration["Authentication:Google:ClientSecret"];
            }).AddMicrosoftAccount(microsoftOptions =>
            {
                microsoftOptions.ClientId = "d9deb0ea-3a3a-4304-bcdc-2523f46aa0b1";
                microsoftOptions.ClientSecret = "apviDTYH1svfNVU9882$!_?";
                //microsoftOptions.ClientId = Configuration["Authentication:Microsoft:ApplicationId"];
                //microsoftOptions.ClientSecret = Configuration["Authentication:Microsoftsxxxxxxw:Password"];
            })
            .AddFacebook(options =>
            {
                options.AppId = "786246808413303";
                options.AppSecret = "817d348b901cc4cc61d77c3513ef6dd5";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ApplicationDbContext dbContext, UserManager<User> userManager, RoleManager<Role> roleManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            dbContext.Database.EnsureCreated();

            UserDataInitializer.SeedData(userManager, roleManager);
            GlobalSettings.InputBoxSize = 255;
            GlobalSettings.TextAreaSize = 1024;
        }
    }
}
