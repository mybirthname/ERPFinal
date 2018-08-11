using Common.ModelConstants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ERP.Models
{
    public class Invoice: BaseModel
    {
        [Required]
        [StringLength(SolutionConstants.StandardFieldLength)]
        public string Title { get; set; }

        [StringLength(SolutionConstants.DescriptionLength)]
        public string Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime SendDate { get; set; }

        public int Status { get; set; }

        [Range(0, int.MaxValue)]
        public decimal AmountNet { get; set; }

        public int SupplierOrganizationID { get; set; }

        public int OrderID { get; set; }

        public Organization SupplierOrganization { get; set; }

        public Order Order { get; set; }

    }
}
