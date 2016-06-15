using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBilling.Models.Org.Bll
{
    public class BillItemPricePart:BaseModel
    {
        [Required]
        [Index]
        public long BillItemID { get; set; }
        [Required]
        [Index]
        public Guid BillItemCode { get; set; }
        [Required]
        public long AccountItemDefPricePartID { get; set; }
        [Required]
        public Guid AccountItemDefPricePartCode { get; set; }
        [Required]
        [MaxLength(50)]
        public string AccountItemDefPricePartName { get; set; }
        [Required]
        public int AccountItemDefPricePartOrder { get; set; }
        [Required]
        public float AccountItemPricePartValue { get; set; }
    }
}
