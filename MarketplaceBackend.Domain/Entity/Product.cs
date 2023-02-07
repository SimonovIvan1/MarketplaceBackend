using Newtonsoft.Json;

namespace MarketplaceBackend.Domain.Entity
{
    public class Product
    {
        public int Id { get; set; }

        public string ItemExternalName { get; set; }

        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public string Description { get; set; }

        public int Quantity { get; set; }

        //TODO Prices

        public Service Service { get; set; }


        public OrderingRules OrderingRules { get; set; }

    }
}
