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
    public class QuizConfig : IEntityTypeConfiguration<Quiz>
    {
        public void Configure(EntityTypeBuilder<Quiz> builder)
        {
            builder.HasKey(p => p.ID);

            builder.Property(p => p.Title).IsRequired().HasMaxLength(200);

            // Relation

            builder.HasMany(p => p.Questions)
                .WithMany()
                .UsingEntity(p => p.ToTable("QuizQuestions"));
        }
    }
}
