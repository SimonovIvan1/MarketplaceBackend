using MarketplaceBackend.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketplaceBackend.Domain
{
    public interface IBaseResponse<T>
    {
        string Description { get; }
        StatusCode StatusCode { get; }
        T Data { get; }
    }
}
