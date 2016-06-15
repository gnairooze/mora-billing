using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBilling.Models.Org.BllDf
{
    public class BillDef_BillTemplateBody_Period:BaseModel
    {
        [Required]
        [Index]
        public long BillDef_BillTemplateBodyID { get; set; }
        [Required]
        [Index]
        public Guid BillDef_BillTemplateBodyCode { get; set; }
        [Required]
        [Index]
        public long PeriodID { get; set; }
        [Required]
        [Index]
        public Guid PeriodCode { get; set; }
        [Required]
        [Index]
        public int Status { get; set; }
    }
}
