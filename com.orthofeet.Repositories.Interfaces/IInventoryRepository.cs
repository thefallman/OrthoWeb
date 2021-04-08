using System.Collections.Generic;
using System.Threading.Tasks;
using com.orthofeet.Entities;

namespace com.orthofeet.Repositories.Interfaces
{
    public interface IInventoryRepository
    {
        Task<ICollection<StockItem>> GetInventory(string partNumber);
    }
}