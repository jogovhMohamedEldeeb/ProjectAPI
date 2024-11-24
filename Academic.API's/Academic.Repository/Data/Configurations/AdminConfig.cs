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
    public class AdminConfig : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {

            // key 
            builder.HasKey(p => p.ID);

            builder.Property(p => p.UserName).IsRequired().HasMaxLength(30);

            builder.Property(p => p.Password).IsRequired().HasMaxLength(100);

            builder.Property(p => p.HashPassword).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Email).IsRequired()
                .HasMaxLength(100)
                .HasAnnotation("Email",true);

            builder.Property(p => p.Phone).IsRequired()
                .HasMaxLength(100)
                .HasAnnotation("Phone", true);
        }
    }
}
