using ERP.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Data
{
    public class SeedDefaultData
    {
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
            return new User()
            {
                Id= Guid.NewGuid().ToString(),

                UserName = "defaultUser@CompanyDomain.com",

                NormalizedEmail = "DEFAULTUSER@COMPANYDOMAIN.COM",

                Email = "defaultUser@CompanyDomain.com",

                NormalizedUserName = "DEFAULTUSER@COMPANYDOMAIN.COM",

                EmailConfirmed = true,

                PasswordHash = "AQAAAAEAACcQAAAAEGM4W32GEuzZrBKnX02YJWuTmukzR+y3V8Uklky6jZ3eGuVk+i1r7LFCZzNaSs31Mg==",

                SecurityStamp = "FWHMMPZT5JBVI233XP7CYJMNTMQBPAMK",

                ConcurrencyStamp = Guid.NewGuid().ToString(),

                FirstName = "Default",

                LastName = "User",

                Culture = "EN",

                CultureUI = "EN",

                CreateBy = "Automatic Seed Function",

                UpdateBy = "Automatic Seed Function",

                CreateDate = DateTime.Now,

                UpdateDate = DateTime.Now,
            };

        }
    }
}
