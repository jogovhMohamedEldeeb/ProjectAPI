using Academic.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academic.Repository.Data.Configurations
{
    public class MultiChoiceQuestionConfig : IEntityTypeConfiguration<MultiChoiceQuestion>
    {
        public void Configure(EntityTypeBuilder<MultiChoiceQuestion> builder)
        {
            // key
            builder.HasKey(mcq => mcq.ID);

            
            builder.Property(mcq => mcq.Content).IsRequired();

            builder.Property(mcq => mcq.ChoiceA).IsRequired();

            builder.Property(mcq => mcq.ChoiceB).IsRequired();

            builder.Property(mcq => mcq.ChoiceC).IsRequired();

            builder.Property(mcq => mcq.ChoiceD).IsRequired();

            builder.Property(mcq => mcq.Answer).IsRequired();


            // Relation
            builder.Property(mcq => mcq.Points)
                   .IsRequired()
                   .HasDefaultValue(1)
                   .HasAnnotation("Range", new { Min = 1, Max = 20 });
        }
    }

}
