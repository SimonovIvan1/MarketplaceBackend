using MarketplaceBackend.DAL.Interfaces;
using MarketplaceBackend.Domain.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace MarketplaceBackend.DAL.Repository
{
    public class ServiceRepository : IBaseRepository<Service>
    {
        private readonly AppDbContext _db;

        public ServiceRepository(AppDbContext dbContext)
        {
            _db = dbContext;
        }
        public async Task Create(Service entity)
        {
            await _db.Service.AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public async Task Delete(Service entity)
        {
            _db.Service.Remove(entity);
            await _db.SaveChangesAsync();
        }

        public IQueryable<Service> GetAll()
        {
            return _db.Service;
        }

        public async Task<Service> Update(Service entity)
        {
            _db.Service.Update(entity);
            await _db.SaveChangesAsync();

            return entity;
        }
    }
}
