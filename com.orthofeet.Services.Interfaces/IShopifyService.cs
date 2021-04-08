using System;
using System.Threading.Tasks;

namespace com.orthofeet.Services.Interfaces
{
    public interface IShopifyService
    {
        Task<bool> Authorize();
    }
}
