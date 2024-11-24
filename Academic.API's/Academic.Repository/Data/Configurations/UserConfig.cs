using Academic.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academic.Repository.Data.Configurations
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        void IEntityTypeConfiguration<User>.Configure(EntityTypeBuilder<User> builder)
        {
            // Key
            builder.HasKey(u => u.ID);

            
            builder.Property(u => u.UserName).IsRequired().HasMaxLength(50);

            builder.Property(u => u.Email).IsRequired()
                .HasMaxLength(100)
                .HasAnnotation("EmailAddress", true);

            builder.Property(u => u.Password).IsRequired();

            builder.Property(u => u.HashedPassword).IsRequired();

            builder.Property(u => u.Phone).IsRequired()
                .HasAnnotation("Phone", true);

            builder.Property(u => u.Name).IsRequired().HasMaxLength(100);

            builder.Property(u => u.Country).IsRequired().HasMaxLength(50);

            builder.Property(u => u.Education).IsRequired().HasMaxLength(50);

            builder.Property(u => u.Points)
                   .IsRequired()
                   .HasDefaultValue(0)
                   .HasAnnotation("Range", new { Min = 0, Max = int.MaxValue });


            builder.Property(u => u.HaveCertification).IsRequired();

            // Relation

            builder.HasMany(u => u.Paths)
                  .WithMany(p => p.Users)
                  .UsingEntity(j => j.ToTable("UserPaths")); 

            
            builder.HasMany(u => u.Modules)
                   .WithMany(m => m.Users)
                   .UsingEntity(j => j.ToTable("UserModules"));

        }
    }
}
