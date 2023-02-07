using MarketplaceBackend.Domain.ViewModel.OrderingRulesViewModel;
using MarketplaceBackend.Domain.ViewModel.ServiceViewModel;
using Newtonsoft.Json;

namespace MarketplaceBackend.Domain.ViewModel.ProductViewModel
{
    public class Product
    {
        [JsonProperty("itemId")]
        public int Id { get; set; }

        [JsonProperty("itemExternalName")]
        public string ItemExternalName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public string ImageUrl { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        //TODO Prices

        public Service Service { get; set; }


        public OrderingRules OrderingRules { get; set; }

    }
}
