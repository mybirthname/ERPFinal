using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ERP.Dtos
{
    public class StockReceipt : BaseModel
    {
        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(2000)]
        public string Description { get; set; }

        public DateTime SendDate { get; set; }

        public int Status { get; set; }

        public decimal AmountNet { get; set; }

        public int OrderID { get; set; }

        public Order Order { get; set; }

    }
}
