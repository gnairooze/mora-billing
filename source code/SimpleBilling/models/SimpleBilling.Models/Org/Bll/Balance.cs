using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBilling.Models.Org.Bll
{
    public class Balance:BaseModel
    {
        [Required]
        [Index]
        public long AccountID { get; set; }
        [Required]
        [Index]
        public Guid AccountCode { get; set; }
        [Required]
        public float Value { get; set; }
    }
}
