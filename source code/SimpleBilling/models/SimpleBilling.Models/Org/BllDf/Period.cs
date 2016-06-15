using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBilling.Models.Org.BllDf
{
    public class Period:BaseModel
    {
        [Required]
        [MaxLength(50)]
        [Index]
        public string Name { get; set; }
        [Required]
        public DateTime DateFrom { get; set; }
        [Required]
        public DateTime DateTo { get; set; }
        [Required]
        [Index]
        public int Status { get; set; }
    }
}
