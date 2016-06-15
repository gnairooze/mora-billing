using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBilling.Models.Org.Accnt
{
    public class AccountItem:BaseModel
    {
        [Required]
        public long ItemDefID { get; set; }
        [Required]
        public Guid ItemDefCode { get; set; }
        [Required]
        [MaxLength(50)]
        public string ItemDefName { get; set; }
        [Required]
        [MaxLength(300)]
        public string ItemDefDescription { get; set; }
        [Required]
        public int ItemCount { get; set; }
        [Required]
        public int Status { get; set; }
    }
}
