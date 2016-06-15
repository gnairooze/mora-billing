using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBilling.Models.Org.Ctlg
{
    public class ItemDef:BaseModel
    {
        [Required]
        [Index]
        public long CatalogID { get; set; }
        [Required]
        [Index]
        public Guid CatalogCode { get; set; }
        [Required]
        [MaxLength(50)]
        [Index]
        public string Name { get; set; }
        [Required]
        [Index]
        public int Status { get; set; }
    }
}
