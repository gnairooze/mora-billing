using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBilling.Models.Org.Bll
{
    public class Bill:BaseModel
    {
        [Required]
        [Index]
        public long AccountID { get; set; }
        [Required]
        [Index]
        public Guid AccountCode { get; set; }
        [Required]
        [Index]
        public long BillDefID { get; set; }
        [Required]
        [Index]
        public Guid BillDefCode { get; set; }
        [Required]
        [MaxLength(50)]
        public string BillDefName { get; set; }
        [Required]
        [MaxLength(300)]
        public string BillDefDescription { get; set; }
        [Required]
        public DateTime IssueDate { get; set; }
        [Required]
        public DateTime DueDate { get; set; }
        [Required]
        [Index]
        public float TotalValue { get; set; }
        [Required]
        [Index]
        public float RemainingValue { get; set; }
    }
}
