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
    public class InstructorConfig : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            //  Key
            builder.HasKey(i => i.ID);

            builder.Property(i => i.Name).IsRequired().HasMaxLength(100);

            builder.Property(i => i.Email).IsRequired()
                .HasMaxLength(100).HasAnnotation("Email",true);

            builder.Property(i => i.Password).IsRequired().HasMaxLength(100);

            builder.Property(i => i.HashedPassword).IsRequired().HasMaxLength(100);

            builder.Property(i => i.Phone).IsRequired()
                .HasMaxLength(100).HasAnnotation("Phone", true);

            builder.Property(i => i.JobType).IsRequired().HasMaxLength(50);

            // Relation
            builder.HasMany(i => i.Modules)
                   .WithOne()
                   .HasForeignKey("InstructorId") 
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
