using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Academic.Core.Entities
{
    public class Path : BaseEntity
    {
        /* Path info */
        [Required] 
        [MaxLength(200)]
        public string Title { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }

        /* indication */
        [Range(1, 5)]
        public int Difficulty { get; set; }

        [Range(1, 100)]
        public int NumOfModules { get; set; }

        public DateTime CreatedAt { get; set; }

        // 1(Path) - M(Module)
        public ICollection<Module> Modules { get; set; }

        // M - M
        public ICollection<User> Users { get; set; }


        public ICollection<PathTask> Tasks { get; set; }
    }
}
