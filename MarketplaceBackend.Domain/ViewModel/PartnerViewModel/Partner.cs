using MarketplaceBackend.Domain.ViewModel.ServiceViewModel;
using Newtonsoft.Json;

namespace MarketplaceBackend.Domain.ViewModel.PartnerViewModel
{
    public class Partner
    {
        [JsonProperty("orgId")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public string ImageUrl { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("phoneNumbers")]
        public string[] PhoneNumbers { get; set; }

        [JsonProperty("emails")]
        public string[] Emails { get; set; }

        [JsonProperty("webSite")]
        public string WebSite { get; set; }

        public Service Service { get; set; }
    }
}
