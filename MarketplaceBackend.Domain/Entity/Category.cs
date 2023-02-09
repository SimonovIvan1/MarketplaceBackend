using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text.Json;

namespace MarketplaceBackend.Domain.Entity
{
    
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Service>? Services { get; set; }
    }
}
