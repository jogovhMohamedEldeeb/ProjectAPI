using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academic.Core.Entities
{
    public class Module: BaseEntity
    {
        [Required] 
        [MaxLength(150)]
        public string Title { get; set; }
        [Range(1, 5)]
        public int Difficulty { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        [Range(1, 50)]
        public int NumOfSections { get; set; }

        public TimeSpan ExpectedTimeToComplete { get; set; }

        public DateTime CreatedAt { get; set; }

        // 1(Path) - M(Module)
        public ICollection<ModuleSection> Sections { get; set; }
        public ICollection<Quiz> Quizzes { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
