using ERP.Common.ModelConstants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dtos.Customer
{
    public class CustomerInputeModel
    {
        public Guid ID { get; set; }

        [Required(ErrorMessage = "_NrInternRequired")]
        [Display(Name = "_NrIntern")]
        public string NrIntern { get; set; }

        [StringLength(FieldLengthConstants.StandardFieldLength)]
        [Required(ErrorMessage = "_TitleRequired")]
        [Display(Name = "_Title")]
        public string Title { get; set; }

        [StringLength(FieldLengthConstants.DescriptionLength)]
        [Display(Name = "_Description")]
        public string Description { get; set; }

        [StringLength(FieldLengthConstants.StandardFieldLength)]
        [Display(Name = "_Country")]
        public string Country { get; set; }

        [StringLength(FieldLengthConstants.StandardFieldLength)]
        [Display(Name = "_City")]
        public string City { get; set; }

        [StringLength(FieldLengthConstants.StandardFieldLength)]
        [Display(Name = "_Street")]
        public string Street { get; set; }

        [StringLength(FieldLengthConstants.ZipCodeLength)]
        [Display(Name = "_ZipCode")]
        public string ZipCode { get; set; }

        [StringLength(FieldLengthConstants.StandardFieldLength)]
        [EmailAddress]
        [Required(ErrorMessage = "_EmailRequired")]
        [Display(Name = "_Email")]
        public string Email { get; set; }

        [StringLength(FieldLengthConstants.PhoneLength)]
        [Phone]
        [Display(Name = "_Phone")]
        public string Phone { get; set; }

        [StringLength(FieldLengthConstants.StandardFieldLength)]
        [Display(Name = "_Remark")]
        public string Remark { get; set; }

    }
}
