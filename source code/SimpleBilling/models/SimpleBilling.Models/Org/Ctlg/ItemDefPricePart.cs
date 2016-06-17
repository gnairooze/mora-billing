using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBilling.Models.Org.Ctlg
{
    public class ItemDefPricePart
    {
        [Required]
        [Index]
        public long ItemDefID { get; set; }

        [Required]
        [Index]
        public Guid ItemDefCode { get; set; }
        [Required]
        public int Order { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public bool IsPercent { get; set; }

        [Required]
        public float MinValue { get; set; }

        [Required]
        public float MaxValue { get; set; }

        [Required]
        public int Recurring { get; set; }
        
        public int? BillCount { get; set; }

        [Required]
        public bool IsOptional { get; set; }

        [Required]
        public int Status { get; set; }
    }
}
