using System;
using System.Threading.Tasks;
using com.orthofeet.Entities;

namespace com.orthofeet.Repositories.Interfaces
{
    public interface IOrderingRepository
    {
        Task<InvoiceHeader> GetInvoiceHeader(string number);
        Task<OrderHeader> GetOrderHeader(string number);
        Task<OrderHeader> GetOrderDetail(string number);
        Sorder CreateOrder(string number);
    }
}
