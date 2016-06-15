using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBilling.Models.Org.Accnt
{
    public class AccountItem_BillDef:BaseModel
    {
        [Required]
        [Index]
        public long AccountItemID { get; set; }
        [Required]
        [Index]
        public Guid AccountItemCode { get; set; }
        [Required]
        [Index]
        public long BillDefID { get; set; }
        [Required]
        [Index]
        public Guid BillDefCode { get; set; }
        [Required]
        public int Status { get; set; }
    }
}
