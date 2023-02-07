using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MarketplaceBackend.Domain.Enum
{
    public enum PaymentTypes
    {
        [Display(Name = "Оплата наличными")]
        Cash = 0,
        [Display(Name = "Оплата по карте")]
        Card = 1
    }
}
