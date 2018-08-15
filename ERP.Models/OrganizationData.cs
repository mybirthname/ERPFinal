using Common.ModelConstants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ERP.Models
{
    public class OrganizationData
    {
        public int ID { get; set; }

        [StringLength(FieldLengthConstants.CounterLength)]
        public string OrderCounter { get; set; }

        [StringLength(FieldLengthConstants.CounterLength)]
        public string SupplierCounter { get; set; }

        [StringLength(FieldLengthConstants.CounterLength)]
        public string UserCounter { get; set; }

        [StringLength(FieldLengthConstants.CounterLength)]
        public string CustomerCounter { get; set; }

        [StringLength(FieldLengthConstants.CounterLength)]
        public string InvoiceCounter { get; set; }

        [StringLength(FieldLengthConstants.CounterLength)]
        public string StockReceiptCounter { get; set; }

    }
}
