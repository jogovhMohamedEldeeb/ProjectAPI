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
    public class ModuleConfig : IEntityTypeConfiguration<Module>
    {
        void IEntityTypeConfiguration<Module>.Configure(EntityTypeBuilder<Module> builder)
        {
            // Key
            builder.HasKey(m => m.ID);

            builder.Property(m => m.Title).IsRequired().HasMaxLength(150);

            builder.Property(m => m.Difficulty).IsRequired()
                   .HasDefaultValue(1)
                   .HasAnnotation("Range", new { Min = 1, Max = 5 });

            builder.Property(m => m.Description).HasMaxLength(200);

            builder.Property(m => m.NumOfSections).IsRequired()
                .HasDefaultValue(1)
                .HasAnnotation("Range", new { Min = 1, Max = 50 });

            builder.Property(m => m.ExpectedTimeToComplete)
                   .IsRequired()
                   .HasDefaultValue(TimeSpan.Zero);

            builder.Property(m => m.CreatedAt).IsRequired();

            // Relations
            builder.HasMany(m => m.Sections)
                   .WithOne()
                   .HasForeignKey("ModuleId")
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(m => m.Quizzes)
                   .WithOne()
                   .HasForeignKey("ModuleId")
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(m => m.Users)
                   .WithMany(u => u.Modules)
                   .UsingEntity(j => j.ToTable("ModuleUsers"));
        }
    }
}
