using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ERP.Models
{
    public class User :IdentityUser
    {
        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(2000)]
        public string Description { get; set; }

        [Phone]
        [StringLength(20)]
        public string Phone { get; set; }

        public string CreateBy { get; set; }

        public string UpdateBy { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime UpdateDate { get; set; }

        public int OrganizationID { get; set; }

        public Organization Organization { get; set; }

        [StringLength(50)]
        public string Remark { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
