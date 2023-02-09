using MarketplaceBackend.BLL.Interfaces;
using MarketplaceBackend.DAL.Interfaces;
using MarketplaceBackend.Domain.Entity;
using MarketplaceBackend.Domain.Response;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace MarketplaceBackend.BLL.Implementations
{
    public class CategoryBLL : ICategoryBLL
    {
        private readonly IBaseRepository<Category> _categoryRepository;

        public CategoryBLL(IBaseRepository<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public Task<IBaseResponse<Category>> Create()
        {
            throw new NotImplementedException();
        }

        public Task<IBaseResponse<bool>> DeleteCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IBaseResponse<Category>> EditCategory(int id)
        {
            throw new NotImplementedException();
        }

        public IBaseResponse<List<Category>> GetCategories()
        {
            throw new NotImplementedException();
        }

        public Task<IBaseResponse<Category>> GetCategory(int id)
        {
            throw new NotImplementedException();
        }
    }
}
