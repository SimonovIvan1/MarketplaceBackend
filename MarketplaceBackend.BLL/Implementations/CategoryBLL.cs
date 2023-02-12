using MarketplaceBackend.BLL.Interfaces;
using MarketplaceBackend.DAL.Interfaces;
using MarketplaceBackend.DAL.Repository;
using MarketplaceBackend.Domain.Entity;
using MarketplaceBackend.Domain.Enum;
using MarketplaceBackend.Domain.Response;
using Microsoft.EntityFrameworkCore;
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

        public async Task<IBaseResponse<Category>> EditCategory(int id)
        {
            try
            {
                var category = await _categoryRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);
                if (category == null)
                {
                    return new BaseResponse<Category>()
                    {
                        Description = "Category not found"
                    };
                }

                category.Name = category.Name;

                await _categoryRepository.Update(category);


                return new BaseResponse<Category>()
                {
                    Data = category,
                    
                };
                
            }
            catch (Exception ex)
            {
                return new BaseResponse<Category>()
                {
                    Description = $"[Edit] : {ex.Message}"
                };
            }
        }

        public IBaseResponse<List<Category>> GetCategories()
        {
            try
            {
                var categories = _categoryRepository.GetAll().ToList();
                if (!categories.Any())
                {
                    return new BaseResponse<List<Category>>()
                    {
                        Description = "Найдено 0 элементов"
                    };
                }

                return new BaseResponse<List<Category>>()
                {
                    Data = categories,
                   
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<List<Category>>()
                {
                    Description = $"[GetCategories] : {ex.Message}"
                    
                };
            }
        }

        public Task<IBaseResponse<Category>> GetCategory(int id)
        {
            throw new NotImplementedException();
        }
    }
}
