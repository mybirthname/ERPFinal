using Common.ModelConstants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ERP.Models
{
    public abstract class BaseModel
    {
        public int ID { get; set; }

        [Required]
        [StringLength(SolutionConstants.StandardFieldLength)]
        public string NrIntern { get; set; }

        public int UserID { get; set; }

        [StringLength(SolutionConstants.StandardFieldLength)]
        public string CreateBy { get; set; }

        [StringLength(SolutionConstants.StandardFieldLength)]
        public string UpdateBy { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreateDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime UpdateDate { get; set; }

        public int OrganizationID { get; set; }

        [StringLength(SolutionConstants.RemarkLength)]
        public string Remark { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

    }
}
