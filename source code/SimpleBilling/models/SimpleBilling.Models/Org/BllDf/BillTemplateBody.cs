using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBilling.Models.Org.BllDf
{
    public class BillTemplateBody:BaseModel
    {
        [Required]
        [MaxLength(50)]
        [Index]
        public string Name { get; set; }
    }
}
