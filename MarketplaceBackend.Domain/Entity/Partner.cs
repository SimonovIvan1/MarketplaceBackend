using Newtonsoft.Json;

namespace MarketplaceBackend.Domain.Entity
{
    public class Partner
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public string Description { get; set; }
           
        public string[] PhoneNumbers { get; set; }

        public string[] Emails { get; set; }

        public string WebSite { get; set; }

        public Service Service { get; set; }
    }
}
