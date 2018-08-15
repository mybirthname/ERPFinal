using Common.ModelConstants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ERP.Models
{
    public class StockReceiptPosition : BaseModel
    {
        [Required]
        [StringLength(FieldLengthConstants.StandardFieldLength)]
        public string Title { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int Quantity { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public decimal Price { get; set; }

        public int StockReceiptID { get; set; }

        public StockReceipt StockReceipt { get; set; }

        [StringLength(FieldLengthConstants.DescriptionLength)]
        public string Description { get; set; }
    }
}
