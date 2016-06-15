using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBilling.Models.Org.Bll
{
    public class BillItem:BaseModel
    {
        [Required]
        [Index]
        public long BillID { get; set; }
        [Required]
        [Index]
        public Guid BillCode { get; set; }
        [Required]
        [Index]
        public long AccountItemDefID { get; set; }
        [Required]
        [Index]
        public Guid AccountItemDefCode { get; set; }
        [Required]
        [MaxLength(50)]
        public string AccountItemDefName { get; set; }
        [Required]
        [MaxLength(300)]
        public string AccountItemDefDescription { get; set; }
        [Required]
        [Index]
        public float SubTotalValue { get; set; }
        [Required]
        [Index]
        public float SubRemainingValue { get; set; }
    }
}
