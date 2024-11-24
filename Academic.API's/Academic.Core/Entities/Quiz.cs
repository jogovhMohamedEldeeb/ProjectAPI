using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academic.Core.Entities
{
    public class Quiz : BaseEntity
    {
        [Required] 
        [MaxLength(200)]
        public string Title { get; set; }

        // M - M
        public ICollection<MultiChoiceQuestion> Questions { get; set; }
         
    }
}
