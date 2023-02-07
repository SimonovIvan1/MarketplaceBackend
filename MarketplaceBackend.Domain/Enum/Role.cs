using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MarketplaceBackend.Domain.Enum
{
    public enum Role
    {
        [Display(Name = "Администратор")]
        Admin = 0,
        [Display(Name = "Поставщик")]
        Partner = 1,
        [Display(Name = "Пользователь")]
        User = 2
    }
}
