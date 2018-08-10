using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ERP.Dtos
{
    public class OrderPosition : BaseModel
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal Price { get; set; }

        public int OrderID { get; set; }

        public Order Order { get; set; }

        [StringLength(2000)]
        public string Description { get; set; }

    }
}
