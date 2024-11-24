using Academic.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academic.Repository.Data.Configurations
{
    public class PathTaskConfig : IEntityTypeConfiguration<PathTask>
    {
        public void Configure(EntityTypeBuilder<PathTask> builder)
        {
            builder.HasKey(p => p.ID);

            builder.Property(p => p.TotalPoints)
                .IsRequired()
                .HasDefaultValue(1)
                .HasAnnotation("Range", new { Min = 1, Max = 100 });

            builder.Property(p => p.MinPointsToCertify)
                .IsRequired()
                .HasDefaultValue(1)
                .HasAnnotation("Range", new { Min = 1, Max = 70 });

            builder.Property(p => p.Description)
                .IsRequired()
                .HasMaxLength(200);

            // Relation
            builder.HasMany(p => p.Questions)
                .WithMany()
                .UsingEntity(p => p.ToTable("PathTaskQuestions"));
        }
    }
}
