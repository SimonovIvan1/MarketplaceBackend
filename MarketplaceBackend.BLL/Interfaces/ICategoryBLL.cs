using MarketplaceBackend.Domain.Entity;
using MarketplaceBackend.Domain.Response;
using MarketplaceBackend.Domain.ViewModel.CartViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace MarketplaceBackend.BLL.Interfaces
{
    public interface ICategoryBLL
    {

        IBaseResponse<List<Category>> GetCategories();
        Task<IBaseResponse<Category>> GetCategory(int id);
    
        Task<IBaseResponse<Category>> Create();

        Task<IBaseResponse<bool>> DeleteCategory(int id);

        Task<IBaseResponse<Category>> EditCategory(int id);
    }
}
