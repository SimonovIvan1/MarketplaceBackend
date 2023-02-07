using MarketplaceBackend.DAL.Interfaces;
using MarketplaceBackend.Domain.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace MarketplaceBackend.DAL.Repository
{
    public class ProductRepository : IBaseRepository<Product>
    {
        private readonly AppDbContext _db;

        public ProductRepository(AppDbContext dbContext)
        {
            _db = dbContext;
        }
        public async Task Create(Product entity)
        {
            await _db.Product.AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public async Task Delete(Product entity)
        {
            _db.Product.Remove(entity);
            await _db.SaveChangesAsync();
        }

        public IQueryable<Product> GetAll()
        {
            return _db.Product;
        }

        public async Task<Product> Update(Product entity)
        {
            _db.Product.Update(entity);
            await _db.SaveChangesAsync();

            return entity;
        }
    }
}
