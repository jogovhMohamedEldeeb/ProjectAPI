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
    public class ModuleSectionConfig : IEntityTypeConfiguration<ModuleSection>
    {
        public void Configure(EntityTypeBuilder<ModuleSection> builder)
        {
            builder.Property(m => m.Title).IsRequired().HasMaxLength(150);

            builder.Property(m => m.Body).IsRequired().HasMaxLength(1000);

            // Relation
            builder.HasMany(ms => ms.Quizzes)
                   .WithOne()
                   .HasForeignKey("ModuleSectionId") 
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
