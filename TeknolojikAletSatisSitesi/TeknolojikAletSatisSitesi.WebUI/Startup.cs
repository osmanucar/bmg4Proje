using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
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
using TeknolojikAletSatisSitesi.WebUI.Middlewares;

namespace TeknolojikAletSatisSitesi.WebUI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IProductDal, EfCoreProductDal>();
            services.AddScoped<ICategoryDal, EfCoreCategoryDal>();
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<ICategoryService, CategoryManager>();

            services.AddMvc()
                .SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0);
            services.AddMvc(option => option.EnableEndpointRouting = false);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                SeedDatebase.Seed();
            }
            app.UseStaticFiles();
            app.CustomStaticFiles();
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
                   name: "products",
                   template: "products/{category?}",
                   defaults: new { controller = "Shop", action = "List" }
                 );

                 routes.MapRoute(
                     name: "default",
                     template: "{controller=Home}/{action=Index}/{id?}"
                 );

             });
            // bunuda kullanabiliriz aynı görevi görüyor
           /* app.UseRouting();
            app.UseCors();

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapControllerRoute(
                name: "adminProducts",
                pattern: "admin/products",
                defaults: new { controller = "Admin", action = "ProductList" });

                endpoints.MapControllerRoute(
                name: "adminProducts",
                pattern: "admin/products/{id?}",
                defaults: new { controller = "Admin", action = "EditProduct" });

                endpoints.MapControllerRoute(
                name: "products",
                pattern: "products/{category?}",
                defaults: new { controller = "Shop", action = "List" });

                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });*/

        }
    }
}
