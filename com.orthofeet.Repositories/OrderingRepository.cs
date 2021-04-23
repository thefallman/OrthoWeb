using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using com.orthofeet.Entities;
using com.orthofeet.EntityFramework;
using com.orthofeet.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Task = System.Threading.Tasks.Task;

namespace com.orthofeet.Repositories
{
    public class OrderingRepository: X3SageRepository, IOrderingRepository
    {
	    private readonly SageX3Context _sageX3Context;
        public OrderingRepository(X3SageDbContext context, SageX3Context sageX3Context): base(context)
        {
	        _sageX3Context = sageX3Context;
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

        public Sorder CreateOrder(string number)
        {
	        const string bpc = "GENERATED";
	        const string bpa = "BT1";
	        var order = new Sorder()
	        {
		        Sohnum0 = number,
                Cpy0 = "200",
                Sohtyp0 = "SON",
                Sohcat0 = 1,
                Salfcy0 = "201",
                Stofcy0 = "201",
                Orifcy0 = "201",
                Creusr0 = "ADMIN",

                Bpcord0 = bpc,
                Bpcinv0 = bpc,
                Bpcpyr0 = bpc,
                Bpcgru0 = bpc,

                Bpaadd0 = bpa,
                Bpainv0 = bpa,
                Bpapyr0 = bpa,
                Bpaord0 = bpa,

                Cusordref0 = "ZAP0000000001",
                Bpcnam0 = "ZAPOS.COM",

                Pjt0 = "Test"
                
	        };

            //SVCRFOOT
            //SVCRVAT
	        var props = order.GetType().GetProperties().ToList();
	        props.ForEach(prop =>
	        {
		        var propType = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;
		        if (propType == typeof(string))
		        {
                    var val =  (string)prop.GetValue(order);
                    prop.SetValue(order, val ?? " ");
		        }
                else if (propType == typeof(DateTime))
		        {
			        prop.SetValue(order, DateTime.Now);
		        }

	        });
            
	        _sageX3Context.Sorders.Add(order);
	        try
	        {
		        _sageX3Context.SaveChanges();
	        }
	        catch (ValidationException ex)
	        {
		        Console.WriteLine(ex);
		        throw;
	        }
	        catch (Exception e)
	        {
		        Console.WriteLine(e);
		        throw;
	        }

	        return order;
	        // return await Context.OrderHeaders.Include(s => s.Lines).FirstOrDefaultAsync(i => i.SOHNUM_0 == number);
        }

    }
}
