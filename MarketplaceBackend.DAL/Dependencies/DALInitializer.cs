using MarketplaceBackend.Domain.Entity;
using MarketplaceBackend.DAL.Interfaces;
using MarketplaceBackend.DAL.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace MarketplaceBackend.DAL.Dependencies
{
    public static class DALInitializer
    {
        public static void InitializeRepositories(this IServiceCollection services)
        {
            services.AddScoped<IBaseRepository<Cart>, CartRepository>();
            services.AddScoped<IBaseRepository<Category>, CategoryRepository>();
            services.AddScoped<IBaseRepository<OrderingRules>, OrderingRulesRepository>();
            services.AddScoped<IBaseRepository<Partner>, PartnerRepository>();
            services.AddScoped<IBaseRepository<ProductInCart>, ProductInCartRepository>();
            services.AddScoped<IBaseRepository<Product>, ProductRepository>();
            services.AddScoped<IBaseRepository<Service>, ServiceRepository>();
        }
    }
}
