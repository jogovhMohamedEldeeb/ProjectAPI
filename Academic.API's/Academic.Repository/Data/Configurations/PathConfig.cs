using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Path = Academic.Core.Entities.Path;
namespace Academic.Repository.Data.Configurations
{
    public class PathConfig : IEntityTypeConfiguration<Path>
    {
        public void Configure(EntityTypeBuilder<Path> builder)
        {
            //   Key
            builder.HasKey(p => p.ID);

            // Properties
            builder.Property(p => p.Title).IsRequired().HasMaxLength(200);

            builder.Property(p => p.Description).HasMaxLength(500);

            builder.Property(p => p.Difficulty).IsRequired()
                   .HasDefaultValue(1)
                   .HasAnnotation("Range", new { Min = 1, Max = 5 });

            builder.Property(p => p.NumOfModules).IsRequired()
                   .HasDefaultValue(1)
                   .HasAnnotation("Range", new { Min = 1, Max = 100 });

            builder.Property(p => p.CreatedAt).IsRequired();


            // Relation
            builder.HasMany(p => p.Modules)
                  .WithOne()
                  .HasForeignKey("PathId")  
                  .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(p => p.Tasks)
                   .WithOne()
                   .HasForeignKey("PathId")  
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(p => p.Users)
                   .WithMany(p => p.Paths)
                   .UsingEntity(p => p.ToTable("PathUsers"));
        }
    }
}

