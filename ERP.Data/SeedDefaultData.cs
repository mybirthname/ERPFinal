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

        public static Role GetRoleData()
        {
            return new Role()
            {
                Id = RoleID,
                Name = "SuperAdmin",
                NormalizedName = "SUPERADMIN"
            };
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
                ID = 1,

                ProviderOrganizationID = 0,

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

                OrganizationID = 1,

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
