using System;
using System.ComponentModel.DataAnnotations;

namespace ERP.Models
{
    public class Order : BaseModel
    {
        [Required]
        public string Title { get; set; }

        [StringLength(2000)]
        public string Description { get; set; }

        public DateTime SendDate { get; set; }

        public int Status { get; set; }

        public decimal AmountNet { get; set; }

        public int SupplierOrganizationID { get; set; }

        public Organization SupplierOrganization { get; set; }

        public int SupplierID { get; set; }

        public Supplier Supplier { get; set; }
    }
}
