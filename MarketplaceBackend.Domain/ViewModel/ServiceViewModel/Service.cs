using MarketplaceBackend.Domain.ViewModel.CategoryViewModel;
using MarketplaceBackend.Domain.ViewModel.PartnerViewModel;
using MarketplaceBackend.Domain.ViewModel.ProductViewModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MarketplaceBackend.Domain.ViewModel.ServiceViewModel
{

    public class Service
    {
        [JsonProperty("serviceId")]
        public int Id { get; set; }

        [JsonProperty("marketVersion")]
        public double MarketVersion { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public string ImageUrl { get; set; }

        [JsonProperty("headerImage")]
        public string HeaderImageUrl { get; set; }

        public Category Category { get; set; }
        public Partner Partner { get; set; }

        [JsonProperty("externalCatalogUrl")]
        public string ExternalCatalogUrl { get; set; }

        [JsonProperty("useNativeCatalog")]
        public bool UseNativeCatalog { get; set; }

        public List<Product>? Products { get; set; }

    }
}