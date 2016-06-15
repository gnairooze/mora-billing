using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBilling.Models
{
    public class AppUserLogin
    {
        [Key]
        [Required]
        public long ID { get; set; }
        [Required]
        [MaxLength(50)]
        [Index]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        [Index]
        public string Email { get; set; }
        [Required]
        [MaxLength(20)]
        public string Password { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }
        [Required]
        [Index]
        public DateTime ModifiedOn { get; set; }
    }
}
