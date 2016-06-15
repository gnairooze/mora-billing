using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBilling.Models.Org.BllDf
{
    public class BillDef:BaseModel
    {
        [Index]
        public long AccountID { get; set; }
        [Index]
        public Guid AccountCode { get; set; }
        [Required]
        [MaxLength(50)]
        [Index]
        public string Name { get; set; }
        [Required]
        public DateTime NextDate { get; set; }
        [Required]
        public int DueDateDifference { get; set; }
        [Required]
        public int Recurring { get; set; }
    }
}
