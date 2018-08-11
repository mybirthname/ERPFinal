using Common.ModelConstants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ERP.Models
{
    public class InvoicePosition : BaseModel
    {
        public InvoicePosition()
        {
            Quantity = 1;
        }

        [Required]
        [StringLength(SolutionConstants.StandardFieldLength)]
        public string Title { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public decimal Price { get; set; }

        public int InvoiceID { get; set; }

        public Invoice Invoice { get; set; }

        [StringLength(SolutionConstants.DescriptionLength)]
        public string Description { get; set; }
    }
}
