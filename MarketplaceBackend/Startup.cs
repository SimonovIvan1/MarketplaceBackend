using MarketplaceBackend.DAL.Interfaces;
using MarketplaceBackend.DAL.Repository;
using MarketplaceBackend.Domain.Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace MarketplaceBackend
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
            services.AddControllersWithViews();

            services.AddScoped<IBaseRepository<Cart>, CartRepository>();
            services.AddScoped<IBaseRepository<Category>, CategoryRepository>();
            services.AddScoped<IBaseRepository<OrderingRules>, OrderingRulesRepository>();
            services.AddScoped<IBaseRepository<Partner>, PartnerRepository>();
            services.AddScoped<IBaseRepository<ProductInCart>, ProductInCartRepository>();
            services.AddScoped<IBaseRepository<Product>, ProductRepository>();
            services.AddScoped<IBaseRepository<Service>, ServiceRepository>();

            services.AddSwaggerGen(page =>
            {
                page.SwaggerDoc("cart", new OpenApiInfo { Title = "cart", Version = "v1" });
                page.SwaggerDoc("category", new OpenApiInfo { Title = "category", Version = "v1" });
                page.SwaggerDoc("orderingRules", new OpenApiInfo { Title = "orderingRules", Version = "v1" });
                page.SwaggerDoc("partner", new OpenApiInfo { Title = "partner", Version = "v1" });
                page.SwaggerDoc("product", new OpenApiInfo { Title = "product", Version = "v1" });
                page.SwaggerDoc("productInCart", new OpenApiInfo { Title = "productInCart", Version = "v1" });
                page.SwaggerDoc("service", new OpenApiInfo { Title = "service", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(page =>
                {
                    page.SwaggerEndpoint("/swagger/cart/swagger.json", "cart");
                    page.SwaggerEndpoint("/swagger/category/swagger.json", "category");
                    page.SwaggerEndpoint("/swagger/orderingRules/swagger.json", "orderingRules");
                    page.SwaggerEndpoint("/swagger/partner/swagger.json", "partner");
                    page.SwaggerEndpoint("/swagger/product/swagger.json", "product");
                    page.SwaggerEndpoint("/swagger/productInCart/swagger.json", "productInCart");
                    page.SwaggerEndpoint("/swagger/service/swagger.json", "service");
                });
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

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
