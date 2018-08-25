using Dtos.Filters;
using ERP.Common.ModelConstants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dtos.OrderProcess
{
    public class OrderInputModel
    {

        public OrderInputModel()
        {
            AmountNet = 0;
            Status = 5;
            Quantity = 1;
            Price = 0;
        }

        public Guid ID { get; set; }

        [Display(Name = "_SupplierName")]
        public Guid SupplierID { get; set; }

        [Required(ErrorMessage = "_NrInternRequired")]
        [Display(Name = "_NrIntern")]
        [StringLength(FieldLengthConstants.StandardFieldLength)]
        public string NrIntern { get; set; }

        [Required(ErrorMessage = "_DescriptionRequired")]
        [Display(Name = "_Description")]
        [StringLength(FieldLengthConstants.DescriptionLength)]
        public string Description { get; set; }

        [Required(ErrorMessage = "_TitleRequired")]
        [Display(Name = "_Title")]
        [StringLength(FieldLengthConstants.StandardFieldLength)]
        public string Title { get; set; }

        [StringLength(FieldLengthConstants.RemarkLength)]
        [Display(Name = "_Remark")]
        public string Remark { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "_SendDate")]
        public DateTime? SendDate { get; set; }

        [Display(Name = "_Status")]
        public string StatusText { get; set; }

        [Range(0, int.MaxValue)]
        [Display(Name = "_AmountNet")]
        public int AmountNet { get; set; }

        [Required(ErrorMessage ="_QuantityRequired")]
        [Range(0, int.MaxValue)]
        [Display(Name ="_Quantity")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "_PriceRequired")]
        [Range(0, int.MaxValue)]
        [Display(Name = "_Price")]
        public int Price { get; set; }

        [Display(Name = "_DeliveryDate")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "_DeliveryDateRequired")]
        [ValidateDateAttribute]
        public DateTime? DeliveryDate { get; set; }

        [Display(Name ="_CompanyName")]
        public string CompanyName { get; set; }

        [Display(Name ="_SupplierName")]
        public string SupplierName { get; set; }

        [Display(Name ="_CreateBy")]
        public string CreateBy { get; set; }

        public int Status { get; set; }

        public Guid OrganizationID { get; set; }
    }
}
