using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBilling.Models.Org.Ctlg
{
    public class Catalog:BaseModel
    {
        [Required]
        [MaxLength(50)]
        [Index]
        public string Name { get; set; }
        [Required]
        [Index]
        public long AccountID { get; set; }
        [Required]
        [Index]
        public Guid AccountCode { get; set; }
    }
}
