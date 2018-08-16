using ERP.Common.ModelConstants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ERP.Models
{
    public class StockReceipt : BaseModel
    {

        public StockReceipt()
        {
            AmountNet = 0;
        }

        [Required]
        [StringLength(FieldLengthConstants.StandardFieldLength)]
        public string Title { get; set; }

        [StringLength(FieldLengthConstants.DescriptionLength)]
        public string Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime SendDate { get; set; }

        public int Status { get; set; }

        [Range(0, int.MaxValue)]
        public decimal AmountNet { get; set; }

        public int OrderID { get; set; }

        public Order Order { get; set; }

    }
}
