using MarketplaceBackend.DAL.Interfaces;
using MarketplaceBackend.Domain.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace MarketplaceBackend.DAL.Repository
{
    public class ProductInCartRepository : IBaseRepository<ProductInCart>
    {
        private readonly AppDbContext _db;

        public ProductInCartRepository(AppDbContext dbContext)
        {
            _db = dbContext;
        }
        public async Task Create(ProductInCart entity)
        {
            await _db.ProductInCart.AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public async Task Delete(ProductInCart entity)
        {
            _db.ProductInCart.Remove(entity);
            await _db.SaveChangesAsync();
        }

        public IQueryable<ProductInCart> GetAll()
        {
            return _db.ProductInCart;
        }

        public async Task<ProductInCart> Update(ProductInCart entity)
        {
            _db.ProductInCart.Update(entity);
            await _db.SaveChangesAsync();

            return entity;
        }
    }
}
