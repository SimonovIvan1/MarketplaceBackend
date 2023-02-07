using MarketplaceBackend.Domain.ViewModel.ServiceViewModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text.Json;

namespace MarketplaceBackend.Domain.ViewModel.CategoryViewModel
{

    public class Category
    {
        [JsonProperty("categoryId")]
        public int Id { get; set; }
        [JsonProperty("categoryName")]
        public string Name { get; set; }
        public List<Service>? Services { get; set; }
    }
}
