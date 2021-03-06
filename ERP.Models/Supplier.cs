﻿using ERP.Common.ModelConstants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ERP.Models
{
    public class Supplier : BaseModel
    {
        [StringLength(FieldLengthConstants.StandardFieldLength)]
        [Required(ErrorMessage ="_TitleRequired")]
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

        [StringLength(FieldLengthConstants.StandardFieldLength)]
        [EmailAddress]
        [Display(Name = "_Email")]
        public string Email { get; set; }

        public Guid SupplierOrganizationID { get; set; }

        [StringLength(FieldLengthConstants.PhoneLength)]
        [Phone]
        [Display(Name = "_Phone")]
        public string Phone { get; set; }

    }
}
