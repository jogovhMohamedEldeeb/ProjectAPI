using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academic.Core.Entities
{
    public class ModuleSection : BaseEntity
    {

        [Required] 
        [MaxLength(150)]
        public string Title { get; set; }
        [MaxLength(1000)]
        public string Body { get; set; }

        // 1 - 1
        public ICollection<Quiz> Quizzes { get; set; }

    }
}
