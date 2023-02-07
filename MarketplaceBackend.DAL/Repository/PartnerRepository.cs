using MarketplaceBackend.DAL.Interfaces;
using MarketplaceBackend.Domain.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace MarketplaceBackend.DAL.Repository
{
    public class PartnerRepository : IBaseRepository<Partner>
    {
        private readonly AppDbContext _db;

        public PartnerRepository(AppDbContext dbContext)
        {
            _db = dbContext;
        }
        public async Task Create(Partner entity)
        {
            await _db.Partner.AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public async Task Delete(Partner entity)
        {
            _db.Partner.Remove(entity);
            await _db.SaveChangesAsync();
        }

        public IQueryable<Partner> GetAll()
        {
            return _db.Partner;
        }

        public async Task<Partner> Update(Partner entity)
        {
            _db.Partner.Update(entity);
            await _db.SaveChangesAsync();

            return entity;
        }
    }
}
