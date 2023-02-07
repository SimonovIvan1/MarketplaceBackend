using MarketplaceBackend.DAL.Interfaces;
using MarketplaceBackend.Domain.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace MarketplaceBackend.DAL.Repository
{
    public class OrderingRulesRepository : IBaseRepository<OrderingRules>
    {
        private readonly AppDbContext _db;

        public OrderingRulesRepository(AppDbContext dbContext)
        {
            _db = dbContext;
        }
        public async Task Create(OrderingRules entity)
        {
            await _db.OrderingRules.AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public async Task Delete(OrderingRules entity)
        {
            _db.OrderingRules.Remove(entity);
            await _db.SaveChangesAsync();
        }

        public IQueryable<OrderingRules> GetAll()
        {
            return _db.OrderingRules;
        }

        public async Task<OrderingRules> Update(OrderingRules entity)
        {
            _db.OrderingRules.Update(entity);
            await _db.SaveChangesAsync();

            return entity;
        }
    }
}
