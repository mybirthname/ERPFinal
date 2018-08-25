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
            Status = 5;
        }

        [Required]
        [Display(Name = "_Title")]
        [StringLength(FieldLengthConstants.StandardFieldLength)]
        public string Title { get; set; }

        [StringLength(FieldLengthConstants.DescriptionLength)]
        public string Description { get; set; }

        [DataType(DataType.Date)]
        [Display(Name ="_SendDate")]
        public DateTime? SendDate { get; set; }

        [Display(Name ="_Status")]
        [Range(FieldLengthConstants.StatusMinValue, FieldLengthConstants.StatusMaxValue)]
        public int Status { get; set; }

        [Range(0, int.MaxValue)]
        [Display(Name ="_AmountNet")]
        public decimal AmountNet { get; set; }

        public Guid? SupplierOrganizationID { get; set; }

        public Guid? SupplierID { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DeliveryDate { get; set; }

        public string AttachmentPath { get; set; }
    }
}
