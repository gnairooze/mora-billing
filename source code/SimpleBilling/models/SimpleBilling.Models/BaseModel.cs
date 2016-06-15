using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBilling.Models
{
    public abstract class BaseModel
    {
        [Key]
        [Required]
        public long ID { get; set; }
        [Required]
        public long OrganizationID { get; set; }
        [Required]
        [Index]
        public Guid OrganizationCode { get; set; }
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
