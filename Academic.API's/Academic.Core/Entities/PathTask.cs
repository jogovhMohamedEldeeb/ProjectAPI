using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academic.Core.Entities
{
    public class PathTask : BaseEntity
    {

        [Range(1, 100)]
        public int TotalPoints { get; set; }
        [Range(1, 70)]
        public int MinPointsToCertify { get; set; }
        [Required] 
        [MaxLength(200)]
        public string Description { get; set; }

        // M - M
        public ICollection<MultiChoiceQuestion> Questions { get; set; }
    }
}
