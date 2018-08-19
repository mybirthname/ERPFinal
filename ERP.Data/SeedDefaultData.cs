using ERP.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Data
{
    public class SeedDefaultData
    {
        private static string UserID { get; set; } = "49dc92d3-0025-42eb-8bc0-b3c3acde0f39";
        private static string Email { get; set; } = "martin.stanchev87@gmail.com";
        private static string RoleID { get; set; } = "065548f8-a5a6-4e2a-a30f-000b8d109ed2";
        private static Guid Organization { get; set; } = new Guid("065548f8-a5a6-4e2a-a30f-000b8d109ed2");

        public static Role[] GetRoleData()
        {
            List<Role> list = new List<Role>();
            var adminRole = new Role()
            {
                Id = RoleID,
                Name = "SuperAdmin",
                NormalizedName = "SUPERADMIN"
            };
            list.Add(adminRole);

            var orderRole = new Role()
            {
                Id= Guid.NewGuid().ToString(),
                Name="Order",
                NormalizedName = "ORDER"
            };
            list.Add(orderRole);

            var stockReceiptRole = new Role()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "StockReceipt",
                NormalizedName = "STOCKRECEIPT"
            };
            list.Add(stockReceiptRole);

            var invoiceRole = new Role()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Invoice",
                NormalizedName = "INVOICE"
            };

            list.Add(invoiceRole);

            var supplierRole = new Role()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Supplier",
                NormalizedName = "SUPPLIER"
            };
            list.Add(supplierRole);

            var customerRole = new Role()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Customer",
                NormalizedName = "CUSTOMER"
            };
            list.Add(customerRole);

            return list.ToArray();
        }

        public static UserRole GetUserRoleData()
        {
            return new UserRole()
            {
                RoleId = RoleID,
                UserId = UserID
            };

        }

        public static Organization GetDefaultOrganizationData ()
        {

            return new Organization()
            {
                ID = Organization,

                ProviderOrganizationID = Guid.Empty,

                Title = "Provider Organization",

                Description = "Organization of the company which provides ",

                Country = "Bulgaria",

                City = "Sofia",

                ZipCode = "1000",

                Email = "ContactCompanyEmail@CompanyDomain.com",

                Phone = "+359 888 123 456",

                CreateBy = "Automatic Seed Function",

                UpdateBy = "Automatic Seed Function",

                CreateDate = DateTime.Now,

                UpdateDate = DateTime.Now,

                Remark = "Values are filled automatically"
            };
        }

        public static User GetDefaultSAUser()
        {
            var user = new User()
            {
                Id = UserID,

                UserName = Email,

                NormalizedEmail = Email.ToUpper(),

                Email = Email,

                NormalizedUserName = Email.ToUpper(),

                EmailConfirmed = true,

                OrganizationID = Organization,

                SecurityStamp = Guid.NewGuid().ToString(),

                FirstName = "Martin",

                LastName = "Stanchev",

                CreateBy = "Automatic Seed Function",

                UpdateBy = "Automatic Seed Function",

                CreateDate = DateTime.Now,

                UpdateDate = DateTime.Now,
            };

            var password = new PasswordHasher<User>();
            user.PasswordHash = password.HashPassword(user, "admin123");

            return user;

        }

    }
}
