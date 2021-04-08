using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using com.orthofeet.Entities;
using com.orthofeet.EntityFramework;
using com.orthofeet.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace com.orthofeet.Repositories
{
    public class InventoryRepository: X3SageRepository, IInventoryRepository
    {
        public InventoryRepository(X3SageDbContext context) : base(context)
        {
        }
        public async Task<ICollection<StockItem>> GetInventory(string partNumber)
        {
            return await Context.StockItems.Where(i => i.ITMREF_0 == partNumber).ToListAsync();
        }
    }
}