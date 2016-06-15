using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBilling.Models.Org.Accnt
{
    public class Account:BaseModel
    {
        [Index]
        public long ParentAccountID { get; set; }
        [Required]
        [MaxLength(50)]
        [Index]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        [Index]
        public string Email { get; set; }
        [Required]
        [Index]
        public int Status { get; set; }
    }
}
