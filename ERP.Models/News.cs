using ERP.Common.ModelConstants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ERP.Models
{
    public class News: BaseModel
    {
        [Required(ErrorMessage = "_TitleRequired")]
        [StringLength(FieldLengthConstants.StandardFieldLength)]
        [Display(Name ="_Title")]
        public string Title { get; set; }

        [Required(ErrorMessage ="_DescriptionRequired")]
        [StringLength(FieldLengthConstants.DescriptionLength)]
        [Display(Name ="_Description")]
        public string Description { get; set; }

    }
}
