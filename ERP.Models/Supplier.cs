using Common.ModelConstants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ERP.Models
{
    public class Supplier : BaseModel
    {
        [StringLength(SolutionConstants.StandardFieldLength)]
        public string Title { get; set; }

        [StringLength(SolutionConstants.DescriptionLength)]
        public string Description { get; set; }

        [StringLength(SolutionConstants.StandardFieldLength)]
        public string Country { get; set; }

        [StringLength(SolutionConstants.StandardFieldLength)]
        public string City { get; set; }

        [StringLength(SolutionConstants.StandardFieldLength)]
        public string Street { get; set; }

        [StringLength(SolutionConstants.ZipCodeLength)]
        public string ZipCode { get; set; }

        [StringLength(SolutionConstants.StandardFieldLength)]
        [EmailAddress]
        public string Email { get; set; }

        [StringLength(SolutionConstants.PhoneLength)]
        [Phone]
        public string Phone { get; set; }

    }
}
