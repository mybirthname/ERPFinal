using ERP.Common.ModelConstants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ERP.Models
{
    public class News: BaseModel
    {
        [Required]
        [StringLength(FieldLengthConstants.StandardFieldLength)]
        public string Title { get; set; }

        [Required]
        [StringLength(FieldLengthConstants.DescriptionLength)]
        public string Description { get; set; }

    }
}
