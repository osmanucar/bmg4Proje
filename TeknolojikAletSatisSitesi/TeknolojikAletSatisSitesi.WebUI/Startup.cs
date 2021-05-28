using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeknolojikAletSatisSitesi.Business.Abstract;
using TeknolojikAletSatisSitesi.Business.Concrete;
using TeknolojikAletSatisSitesi.DataAccess.Abstract;
using TeknolojikAletSatisSitesi.DataAccess.Concrete.EfCore;
using TeknolojikAletSatisSitesi.WebUI.Identity;
using TeknolojikAletSatisSitesi.WebUI.Middlewares;

namespace TeknolojikAletSatisSitesi.WebUI
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationIdentityDbContext>(options =>
             options.UseSqlServer(Configuration.GetConnectionString("IdentityConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationIdentityDbContext>()
                .AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(options =>
            {
                // password

                options.Password.RequireDigit = true; //Parolanın içinde Sayısal değer olmalı 
                options.Password.RequireLowercase = true; //Parolanın içinde küçük karakterde olmalı
                options.Password.RequiredLength = 6; // Min. Parola değeri
                options.Password.RequireNonAlphanumeric = true; //Parolanın içinde alfabetik karakter olmasa da olur
                options.Password.RequireUppercase = true; //Parolanın içinde mutlaka büyük karakter olmalı

                options.Lockout.MaxFailedAccessAttempts = 5; // parola kaç sefer yanlış girilebilsin
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5); // yanlış girilen parolalardan sonra bekleme süresi (5 Dakika)
                options.Lockout.AllowedForNewUsers = true; //kitleme işlemi yeni kullanıcı içinde geçerli olacak

                // options.User.AllowedUserNameCharacters = "";
                options.User.RequireUniqueEmail = true; // Aynı 2 Mail adresinin kaydına izin vermez

                options.SignIn.RequireConfirmedEmail = false; // hesap oluşturulduktan mail adresinden onaylası gerekir
                options.SignIn.RequireConfirmedPhoneNumber = false; // telefon NO üzeriinden onaya sunmak için TRUE dememiz yeterli
            });

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/account/login";
                options.LogoutPath = "/account/logout";
                options.AccessDeniedPath = "/account/accessdenied";
                options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
                options.SlidingExpiration = true;
                options.Cookie = new CookieBuilder
                {
                    HttpOnly = true,
                    Name = ".ShopApp.Security.Cookie",
                    SameSite = SameSiteMode.Strict
                };

            });

            services.AddScoped<IProductDal, EfCoreProductDal>();
            services.AddScoped<ICategoryDal, EfCoreCategoryDal>();
            services.AddScoped<ICartDal, EfCoreCartDal>();
            services.AddScoped<IOrderDal, EfCoreOrderDal>();

            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICartService, CartManager>();
            services.AddScoped<IOrderService, OrderManager>();


            services.AddMvc()
                .SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0);
            services.AddMvc(option => option.EnableEndpointRouting = false);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostEnvironment env, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                SeedDatebase.Seed();
            }
            app.UseStaticFiles();
            app.CustomStaticFiles();
            app.UseAuthentication();
            app.UseMvc(routes =>
             {
                /* routes.MapRoute(
                    name: "adminProducts",
                    template: "admin/products",
                    defaults: new { controller = "Admin", action = "Index" }
                 );*/

                routes.MapRoute(
                     name: "adminProducts",
                     template: "admin/products/{id?}",
                     defaults: new { controller = "Admin", action = "EditProduct" }
                 );

                 routes.MapRoute(
                   name: "cart",
                   template: "cart",
                   defaults: new { controller = "Cart", action = "Index" }
                 );

                 routes.MapRoute(
                     name: "orders",
                     template: "orders",
                     defaults: new { controller = "Cart", action = "GetOrders" }
                 );

                 routes.MapRoute(
                   name: "checkout",
                   template: "checkout",
                   defaults: new { controller = "Cart", action = "Checkout" }
                 );

                 routes.MapRoute(
                   name: "products",
                   template: "products/{category?}",
                   defaults: new { controller = "Shop", action = "List" }
                 );

                 routes.MapRoute(
                     name: "default",
                     template: "{controller=Home}/{action=Index}/{id?}"
                 );

             });

            SeedIdentity.Seed(userManager, roleManager, Configuration).Wait();

        }
    }
}
