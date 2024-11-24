using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academic.Core.Entities
{
    public class MultiChoiceQuestion : BaseEntity
    {
        [Required]
        public string Content { get; set; }

        /* Options */
        [Required]
        public string ChoiceA { get; set; }
        [Required]
        public string ChoiceB { get; set; }
        [Required]
        public string ChoiceC { get; set; }
        [Required]
        public string ChoiceD { get; set; }

        [Required]
        public string Answer { get; set; }
        [Range(1,20)]
        public int Points { get; set; }

    }
}
