﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Routing;
using OdeToFood.Services;
using OdeToFood.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;

namespace OdeToFood
{
    public class Startup
    {
        private IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            // Authentication med Azure AD (Open ID Connect)

            services.AddAuthentication(options =>
            {
                options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = OpenIdConnectDefaults.AuthenticationScheme;
            })
            .AddOpenIdConnect(options => 
            {                
                _configuration.Bind("AzureAd", options);
            })
            .AddCookie();

            // Registera dina tjänster

            services.AddSingleton<IGreeter, Greeter>();
            services.AddScoped<IRestaurantService, RestaurantService>();
            services.AddScoped<IHttpService, HttpService>();
            services.AddDbContext<OdeToFoodDbContext>(
                options => options.UseSqlServer(_configuration.GetConnectionString("OdeToFood")));
            services.AddScoped<IRestaurantData, SqlRestaurantData>();
            //services.AddScoped<IRestaurantData, InMemoryRestaurantData>();
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IGreeter greeter, ILogger<Startup> logger)
        {
            if (env.IsDevelopment())
            {               
                app.UseDeveloperExceptionPage();
            }

            // Kör sajten med HTTPS

            app.UseRewriter(new RewriteOptions().AddRedirectToHttpsPermanent()); 

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseMvc(ConfigureRoutes);
          
            //app.Run(async (context) =>
            //{
            //    var greeting = greeter.GetMessageOfTheDay();
            //    context.Response.ContentType = "text/plain";
            //    await context.Response.WriteAsync($"Not found");
            //});
        }

        private void ConfigureRoutes(IRouteBuilder routeBuilder)
        {
            // Sätt upp default routing

            // /Home/Index/4

            routeBuilder.MapRoute("Default", "{controller=Home}/{action=Index}/{id?}");
        }
    }
}
