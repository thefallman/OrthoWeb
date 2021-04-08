using System;
using System.Linq;
using System.Threading.Tasks;
using com.orthofeet.Entities;
using com.orthofeet.EntityFramework;
using com.orthofeet.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace com.orthofeet.Repositories
{
    public class OrderingRepository: X3SageRepository, IOrderingRepository
    {
        public OrderingRepository(X3SageDbContext context): base(context)
        {
        
        }

        public async Task<InvoiceHeader> GetInvoiceHeader(string number)
        {
            return await Context.InvoiceHeaders.FirstOrDefaultAsync(i => i.NUM_0 == number);
        }

        public async Task<OrderHeader> GetOrderHeader(string number)
        {
            return await Context.OrderHeaders.FirstOrDefaultAsync(i => i.SOHNUM_0 == number);
        }

        public async Task<OrderHeader> GetOrderDetail(string number)
        {
            return await Context.OrderHeaders.Include(s => s.Lines).FirstOrDefaultAsync(i => i.SOHNUM_0 == number);
        }
    }
}
