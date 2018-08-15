using Common.ModelConstants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ERP.Models
{
    public class Supplier : BaseModel
    {
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

        [StringLength(FieldLengthConstants.StandardFieldLength)]
        [EmailAddress]
        public string Email { get; set; }

        [StringLength(FieldLengthConstants.PhoneLength)]
        [Phone]
        public string Phone { get; set; }

    }
}
