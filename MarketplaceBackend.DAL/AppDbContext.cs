using MarketplaceBackend.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace MarketplaceBackend.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
                : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<OrderingRules> OrderingRules { get; set; }

        public DbSet<Partner> Partner { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductInCart> ProductInCart { get; set; }
        public DbSet<Service> Service { get; set; }


    }
}

