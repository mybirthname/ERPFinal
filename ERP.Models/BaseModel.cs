using ERP.Common.ModelConstants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ERP.Models
{
    public abstract class BaseModel
    {
        public int ID { get; set; }

        [Required(ErrorMessage ="_NrInternError")]
        [StringLength(FieldLengthConstants.StandardFieldLength)]
        [Display(Name ="_NrIntern")]
        public string NrIntern { get; set; }

        public string UserID { get; set; }

        [StringLength(FieldLengthConstants.StandardFieldLength)]
        [Display(Name = "_CreateBy")]
        public string CreateBy { get; set; }

        [StringLength(FieldLengthConstants.StandardFieldLength)]
        public string UpdateBy { get; set; }

        [DataType(DataType.Date)]
        [Display(Name ="_CreateDate")]
        public DateTime CreateDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime UpdateDate { get; set; }

        public int OrganizationID { get; set; }

        [StringLength(FieldLengthConstants.RemarkLength)]
        [Display(Name ="_Remark")]
        public string Remark { get; set; }

        public int Deleted { get; set; }

    }
}
