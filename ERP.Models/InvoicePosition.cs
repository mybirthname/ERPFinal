using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ERP.Models
{
    public class InvoicePosition : BaseModel
    {

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal Price { get; set; }

        public int InvoiceID { get; set; }

        public Invoice Invoice { get; set; }

        [StringLength(2000)]
        public string Description { get; set; }
    }
}
