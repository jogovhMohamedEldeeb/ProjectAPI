using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academic.Core.Entities
{
    public class Instructor : BaseEntity
    {
        /* Credentials */
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string HashedPassword { get; set; }
         

        /* Contacts */
        [Required]
        [Phone]
        public string Phone { get; set; }
         
        [MaxLength(100)]
        public string Title { get; set; }

        [MaxLength(50)]
        public string JobType { get; set; }

        // Navigation Property
        public ICollection<Module> Modules { get; set; }

    }
}
