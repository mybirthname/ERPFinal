using ERP.Common.ModelConstants;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ERP.Models
{
    public class User :IdentityUser<string>
    {
        [Required]
        [StringLength(FieldLengthConstants.StandardFieldLength)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(FieldLengthConstants.StandardFieldLength)]
        public string LastName { get; set; }

        [StringLength(FieldLengthConstants.DescriptionLength)]
        public string Description { get; set; }

        [StringLength(FieldLengthConstants.StandardFieldLength)]
        public string CreateBy { get; set; }

        [StringLength(FieldLengthConstants.StandardFieldLength)]
        public string UpdateBy { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreateDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime UpdateDate { get; set; }

        public Guid OrganizationID { get; set; }

    }
}
