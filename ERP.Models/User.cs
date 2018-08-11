using Common.ModelConstants;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ERP.Models
{
    public class User :IdentityUser
    {
        [StringLength(SolutionConstants.StandardFieldLength)]
        public string FirstName { get; set; }

        [StringLength(SolutionConstants.StandardFieldLength)]
        public string LastName { get; set; }

        [StringLength(SolutionConstants.DescriptionLength)]
        public string Description { get; set; }

        [StringLength(SolutionConstants.StandardFieldLength)]
        public string CreateBy { get; set; }

        [StringLength(SolutionConstants.StandardFieldLength)]
        public string UpdateBy { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreateDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime UpdateDate { get; set; }

        public int OrganizationID { get; set; }

        [StringLength(SolutionConstants.CultureLength)]
        public string Culture { get; set; }

        [StringLength(SolutionConstants.CultureLength)]
        public string CultureUI { get; set; }
    }
}
