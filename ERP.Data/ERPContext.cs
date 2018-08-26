using ERP.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Linq;

namespace ERP.Data
{
    public class ERPContext: IdentityDbContext<User, Role, string, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>
    {

        public ERPContext(DbContextOptions<ERPContext> databaseOptions) :base(databaseOptions)
        {
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
        public DbSet<News> News { get; set; }

        public DbSet<IdentityUserClaim<Guid>> IdentityUserClaims { get; set; } //-> bug which is workarounded with this line https://github.com/aspnet/Identity/issues/1802

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>().HasData(SeedDefaultData.GetDefaultSAUser());
            builder.Entity<Organization>().HasData(SeedDefaultData.GetDefaultOrganizationData());
            builder.Entity<Role>().HasData(SeedDefaultData.GetRoleData());
            builder.Entity<UserRole>().HasData(SeedDefaultData.GetUserRoleData());

            base.OnModelCreating(builder);
        }
    }
}
