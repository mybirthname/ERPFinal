using ERP.Common.ModelConstants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ERP.Models
{
    public class Organization
    {

        public int ID { get; set; }

        public int ProviderOrganizationID { get; set; }

        [StringLength(FieldLengthConstants.StandardFieldLength)]
        public string Title { get; set; }

        [StringLength(FieldLengthConstants.DescriptionLength)]
        public string Description { get; set; }

        [StringLength(FieldLengthConstants.StandardFieldLength)]
        public string Country { get; set; }

        [StringLength(FieldLengthConstants.StandardFieldLength)]
        public string City { get; set; }

        [StringLength(FieldLengthConstants.StandardFieldLength)]
        public string Street { get; set; }

        [StringLength(FieldLengthConstants.ZipCodeLength)]
        public string ZipCode { get; set; }

        [EmailAddress]
        [StringLength(FieldLengthConstants.StandardFieldLength)]
        public string Email { get; set; }

        [Phone]
        [StringLength(FieldLengthConstants.PhoneLength)]
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
        public string Remark { get; set; }

    }
}
