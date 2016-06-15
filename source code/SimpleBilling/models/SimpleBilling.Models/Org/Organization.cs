using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBilling.Models.Org
{
    public class Organization
    {
        [Key]
        [Required]
        public long ID { get; set; }
        [Required]
        [MaxLength(50)]
        [Index]
        public string Name { get; set; }
        [Required]
        [Index]
        public Guid Code { get; set; }
        [Required]
        [MaxLength(300)]
        public string Description { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }
        [Required]
        [Index]
        public DateTime ModifiedOn { get; set; }
    }
}
