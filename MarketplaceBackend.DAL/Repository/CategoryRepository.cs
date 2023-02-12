using MarketplaceBackend.DAL.Interfaces;
using MarketplaceBackend.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace MarketplaceBackend.DAL.Repository
{
    public class CategoryRepository : IBaseRepository<Category>
    {
        private readonly AppDbContext _db;

        public CategoryRepository(AppDbContext dbContext)
        {
            _db = dbContext;
        }
        public async Task Create(Category entity)
        {
            await _db.Category.AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public async Task Delete(Category entity)
        {
            _db.Category.Remove(entity);
            await _db.SaveChangesAsync();
        }

        public IQueryable<Category> GetAll()
        {
            return _db.Category;
        }

        public async Task<Category> Update(Category entity)
        {
            _db.Category.Update(entity);
            await _db.SaveChangesAsync();

            return entity;
        }
    }
}
