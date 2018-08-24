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
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ERP.Data;
using ERP.Models;
using Microsoft.AspNetCore.Mvc.Razor;
using System.Globalization;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Identity.UI.Services;
using ERP.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using AutoMapper;
using ERP.Services.Administration;
using ERP.Services.Interfaces;
using ERP.Common;
using ERP.Services.Provider;
using ERP.Services.Customer;
using ERP.Services.Supplier;
using ERP.Common.Filters;
using ERP.Services.OrderProcess;

namespace ERP.Web
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
            AddLocalizationService(services);

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddSession(option => option.IdleTimeout = TimeSpan.FromMinutes(120));

            services.Configure<SqlDatabaseOptions>(option =>
            {
                option.ConnectionString = Configuration.GetConnectionString("SqlServerConnectionString");
            });

            services.AddDbContext<ERPContext>();

            AddIdentityServices(services);

            services.ConfigureApplicationCookie(options =>
            {
                options.ExpireTimeSpan = TimeSpan.FromMinutes(120);
                options.LoginPath = "/Identity/Account/Login";
            });

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            AddCustomServices(services);

            services.AddAuthorization(options =>
            {
                options.AddPolicy("AdminPolicy", policy => policy.RequireRole("SuperAdmin"));
                options.AddPolicy("OrderPolicy", policy => policy.RequireRole("SuperAdmin", "Order"));
                options.AddPolicy("CustomerPolicy", policy => policy.RequireRole("SuperAdmin", "Customer"));
                options.AddPolicy("SupplierPolicy", policy => policy.RequireRole("SuperAdmin", "Supplier"));
                options.AddPolicy("InvoicePolicy", policy => policy.RequireRole("SuperAdmin", "Invoice"));
            });


            services
                .AddMvc(options=> 
                {
                    options.Filters.Add<SettingUserSessionFilter>();
                    options.Filters.Add<SettingUserSessionPageFilter>();
                    options.Filters.Add<LoggingFilter>();
                    options.Filters.Add<ExceptionFilter>();
                })
                .AddRazorPagesOptions(options=>
                {
                    options.Conventions.AuthorizeAreaFolder("Identity", "/Account/Manage");
                    options.Conventions.AuthorizeAreaFolder("Administration", "/News", "AdminPolicy");
                    options.Conventions.AuthorizeAreaFolder("Administration", "/Users", "AdminPolicy");
                    options.Conventions.AuthorizeAreaFolder("Provider", "/Organization", "AdminPolicy");
                })
                .AddDataAnnotationsLocalization()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddAntiforgery(o => o.HeaderName = "XSRF-TOKEN");
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
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
            
            app.UseRequestLocalization();

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseSession();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "area",
                    template: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }

        private void AddIdentityServices(IServiceCollection services)
        {
            services
                .AddIdentity<User, Role>(options =>
                {
                    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                    options.Lockout.MaxFailedAccessAttempts = 5;
                })
                .AddEntityFrameworkStores<ERPContext>()
                .AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(options =>
            {
                options.Password = new PasswordOptions()
                {
                    RequiredLength = 6,
                    RequiredUniqueChars = 1,
                    RequireLowercase = true,
                    RequireDigit = false,
                    RequireUppercase = false,
                    RequireNonAlphanumeric = false
                };
            });
        }

        private void AddCustomServices(IServiceCollection services)
        {
            services.AddSingleton<IEmailSender, EmailService>();
            services.Configure<SendGridEmailOptions>(this.Configuration.GetSection("EmailSettings"));
            services.AddScoped<UserSession>();
            services.AddScoped<DateTimeService>();

            services.AddAutoMapper();
            services.AddScoped<INewsService, NewsService>();
            services.AddScoped<IUsersService, UsersService>();
            services.AddScoped<IOrganizationService, OrganizationService>();
            services.AddScoped<ISupplierService, SupplierService>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IOrderService, OrderService>();
        }

        private void AddLocalizationService(IServiceCollection services)
        {
            var supportedCultures = new[]
            {
                new CultureInfo("en-US"),
                new CultureInfo("bg-BG"),
            };

            services.AddLocalization(options => options.ResourcesPath = "Resources");
            services.Configure<RequestLocalizationOptions>(options =>
            {
                options.DefaultRequestCulture = new RequestCulture("bg-BG");
                options.SupportedUICultures = supportedCultures;
                options.SupportedCultures = supportedCultures;
                options.RequestCultureProviders = new List<IRequestCultureProvider>()
                {
                    new QueryStringRequestCultureProvider(),
                    new CookieRequestCultureProvider()
                };
            });

        }
    }
}
