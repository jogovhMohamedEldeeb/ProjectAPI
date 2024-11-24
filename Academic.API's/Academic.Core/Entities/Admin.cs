using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academic.Core.Entities
{
    public class Admin : BaseEntity
    {
        /* Credentials */
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string HashPassword { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        /* Contacts */
        [Required]
        [Phone]
        public string Phone { get; set; }
    }
}
