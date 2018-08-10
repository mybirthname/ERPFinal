using ERP.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Linq;

namespace ERP.Data
{
    public class ERPContext: IdentityDbContext<User>
    {
        public SqlDatabaseOptions SqlDbOptions { get; set; }

        public ERPContext(IOptions<SqlDatabaseOptions> databaseOptions) :base()
        {
            SqlDbOptions = databaseOptions.Value;
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoicePosition> InvoicePositions { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderPosition> OrderPositions { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<StockReceipt> StockReceipts { get; set; }
        public DbSet<StockReceiptPosition> StockReceiptPositions { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnConfiguring(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(SqlDbOptions.ConnectionString);
            }

            base.OnConfiguring(optionsBuilder);
        }

    }
}
