using Newtonsoft.Json;
using System.Collections.Generic;

namespace MarketplaceBackend.Domain.Entity
{

    public class Service
    {
        public int Id { get; set; }
        public double MarketVersion { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string HeaderImageUrl { get; set; }
        public Category Category { get; set; }
        public Partner Partner { get; set; }
        public string ExternalCatalogUrl { get; set; }
        public bool UseNativeCatalog { get; set; }
        public List<Product>? Products { get; set; }

    }
}