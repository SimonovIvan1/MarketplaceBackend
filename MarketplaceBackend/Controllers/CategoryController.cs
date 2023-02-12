using MarketplaceBackend.BLL.Interfaces;
using MarketplaceBackend.Domain.Entity;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketplaceBackend.Controllers
{
    [ApiController]
    [Route("category")]
    [ApiExplorerSettings(GroupName = "category")]
    public class CategoryController : Controller
    {
        private readonly ICategoryBLL _CategoryBLL;

        public CategoryController(ICategoryBLL CategoryBLL)
        {
            _CategoryBLL = CategoryBLL;
        }

        
        [HttpGet]
        [Route("get_all")]
        public List<Category> GetCategories()
        {
            return (List<Category>)_CategoryBLL.GetCategories();
        }
    }
}
