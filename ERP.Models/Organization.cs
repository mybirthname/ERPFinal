using Common.ModelConstants;
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

        [EmailAddress]
        [StringLength(SolutionConstants.StandardFieldLength)]
        public string Email { get; set; }

        [Phone]
        [StringLength(SolutionConstants.PhoneLength)]
        public string Phone { get; set; }

        [StringLength(SolutionConstants.StandardFieldLength)]
        public string CreateBy { get; set; }

        [StringLength(SolutionConstants.StandardFieldLength)]
        public string UpdateBy { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreateDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime UpdateDate { get; set; }

        [StringLength(SolutionConstants.StandardFieldLength)]
        public string Remark { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
