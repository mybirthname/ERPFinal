using ERP.Common.ModelConstants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dtos.OrderProcess
{
    public class OrderInputModel
    {
        public Guid ID { get; set; }

        [Required(ErrorMessage = "_NrInternRequired")]
        [Display(Name = "_NrIntern")]
        [StringLength(FieldLengthConstants.StandardFieldLength)]
        public string NrIntern { get; set; }

        [Required(ErrorMessage = "_DescriptionRequired")]
        [Display(Name = "_Description")]
        [StringLength(FieldLengthConstants.DescriptionLength)]
        public string Description { get; set; }

        [Required(ErrorMessage = "_TitleRequired")]
        [Display(Name = "_Title")]
        [StringLength(FieldLengthConstants.StandardFieldLength)]
        public string Title { get; set; }

        [StringLength(FieldLengthConstants.RemarkLength)]
        [Display(Name = "_Remark")]
        public string Remark { get; set; }

    }
}
