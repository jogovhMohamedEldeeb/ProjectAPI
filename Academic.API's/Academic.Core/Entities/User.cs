using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academic.Core.Entities
{
    public class User:BaseEntity
    {

        /* Credentials  */
        [Required]
        [MaxLength(50)]
        public string UserName { get; set; }

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

        /* perosnal info */
        [Required] 
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Country { get; set; }
        [MaxLength(50)]
        public string Education { get; set; }

        [Range(0, int.MaxValue)]
        public int Points { get; set; }

        public bool HaveCertification { get; set; }

        // M - M
        public ICollection<Path> Paths { get; set; }

        // M - M
        public ICollection<Module> Modules { get; set; }
    }
}
