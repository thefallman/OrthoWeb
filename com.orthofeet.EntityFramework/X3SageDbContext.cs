using System;
using com.orthofeet.Entities;
using Microsoft.EntityFrameworkCore;

namespace com.orthofeet.EntityFramework
{
    public class X3SageDbContext: DbContext
    {
        public DbSet<InvoiceHeader> InvoiceHeaders { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        public DbSet<StockItem> StockItems { get; set; }
        public DbSet<Facility> Facilities { get; set; }
        public DbSet<Customer> Customers{ get; set; }
        
        public X3SageDbContext(DbContextOptions<X3SageDbContext> options)
            :base(options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderLine>()
                .HasOne(p => p.Order)
                .WithMany(b => b.Lines)
                .HasForeignKey(p => p.SOHNUM_0)
                .HasPrincipalKey(b => b.SOHNUM_0);
        }
    }
}
