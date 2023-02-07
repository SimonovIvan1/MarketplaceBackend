using MarketplaceBackend.DAL.Interfaces;
using MarketplaceBackend.Domain.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace MarketplaceBackend.DAL.Repository
{
    public class CartRepository : IBaseRepository<Cart>
    {
        private readonly AppDbContext _db;

        public CartRepository(AppDbContext dbContext)
        {
            _db = dbContext;
        }
        public async Task Create(Cart entity)
        {
            await _db.Cart.AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public async Task Delete(Cart entity)
        {
            _db.Cart.Remove(entity);
            await _db.SaveChangesAsync();
        }

        public IQueryable<Cart> GetAll()
        {
            return _db.Cart;
        }

        public async Task<Cart> Update(Cart entity)
        {
            _db.Cart.Update(entity);
            await _db.SaveChangesAsync();

            return entity;
        }
    }
}
