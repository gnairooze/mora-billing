using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBilling.Models.Org.Accnt
{
    public class AccountItemPricePart : BaseModel
    {
        [Required]
        [Index]
        public long AccountItemID { get; set; }
        [Required]
        [Index]
        public Guid AccountItemCode { get; set; }
        [Required]
        public long ItemDefPricePartID { get; set; }
        [Required]
        public Guid ItemDefPricePartCode { get; set; }
        [Required]
        [MaxLength(50)]
        public string ItemDefPricePartName { get; set; }
        [Required]
        public int ItemDefPricePartOrder { get; set; }
        [Required]
        public float Value { get; set; }
        [Required]
        public int ItemDefPricePartRecurring { get; set; }
        [Required]
        public bool ItemDefPricePartIsOptional { get; set; }
        [Required]
        public int RemainingBillCount { get; set; }
        [Required]
        public int Status { get; set; }
    }
}
