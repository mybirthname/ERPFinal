using ERP.Common.ModelConstants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ERP.Models
{
    public class Organization
    {

        public Guid ID { get; set; }

        public Guid ProviderOrganizationID { get; set; }

        [StringLength(FieldLengthConstants.StandardFieldLength)]
        [Display(Name ="_Title")]
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

        [EmailAddress]
        [StringLength(FieldLengthConstants.StandardFieldLength)]
        [Display(Name = "_Email")]
        public string Email { get; set; }

        [Phone]
        [StringLength(FieldLengthConstants.PhoneLength)]
        [Display(Name = "_Description")]
        public string Phone { get; set; }

        [StringLength(FieldLengthConstants.StandardFieldLength)]
        public string CreateBy { get; set; }

        [StringLength(FieldLengthConstants.StandardFieldLength)]
        public string UpdateBy { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreateDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime UpdateDate { get; set; }

        [StringLength(FieldLengthConstants.StandardFieldLength)]
        [Display(Name = "_Remark")]
        public string Remark { get; set; }

        public int Deleted { get; set; }

    }
}
