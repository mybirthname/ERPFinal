using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ERP.Models
{
    public abstract class BaseModel
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string NrIntern { get; set; }

        public int UserID { get; set; }

        public string CreateBy { get; set; }

        public string UpdateBy { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime UpdateDate { get; set; }

        public int OrganizationID { get; set; }

        [StringLength(50)]
        public string Remark { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

        public User Users { get; set; }

        public Organization Organization { get; set; }

    }
}
