using ERP.Common.ModelConstants;
using System;
using System.ComponentModel.DataAnnotations;

namespace ERP.Models
{
    public class Order : BaseModel
    {

        public Order()
        {
            AmountNet = 0;
        }

        [Required]
        [StringLength(FieldLengthConstants.StandardFieldLength)]
        public string Title { get; set; }

        [StringLength(FieldLengthConstants.DescriptionLength)]
        public string Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime SendDate { get; set; }

        public int Status { get; set; }

        [Range(0, int.MaxValue)]
        public decimal AmountNet { get; set; }

        public int? SupplierOrganizationID { get; set; }

        public int? SupplierID { get; set; }
    }
}
