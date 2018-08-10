using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ERP.Models
{
    public class Organization
    {

        public int ID { get; set; }

        [Required]
        public int ProviderOrganizationID { get; set; }

        [Required]
        [StringLength(50)]
        public string NrIntern { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(2000)]
        public string Description { get; set; }

        [StringLength(50)]
        public string Country { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string Street { get; set; }

        [StringLength(10)]
        public string ZipCode { get; set; }

        [EmailAddress]
        [StringLength(50)]
        public string Email { get; set; }

        [Phone]
        [StringLength(20)]
        public string Phone { get; set; }

        public string CreateBy { get; set; }

        public string UpdateBy { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime UpdateDate { get; set; }

        [StringLength(50)]
        public string Remark { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

        public Organization ProviderOrganization { get; set; }
    }
}
