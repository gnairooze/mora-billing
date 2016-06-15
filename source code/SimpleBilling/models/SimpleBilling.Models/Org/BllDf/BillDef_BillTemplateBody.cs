using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBilling.Models.Org.BllDf
{
    public class BillDef_BillTemplateBody:BaseModel
    {
        [Required]
        [Index]
        public long BillDefID { get; set; }
        [Required]
        [Index]
        public Guid BillDefCode { get; set; }
        [Required]
        [Index]
        public long BillTemplateBodyID { get; set; }
        [Required]
        [Index]
        public Guid BillTemplateBodyCode { get; set; }
        [Required]
        [Index]
        public int Status { get; set; }
    }
}
