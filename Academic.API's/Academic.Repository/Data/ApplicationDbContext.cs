using Academic.Core.Entities;
using Academic.Repository.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Module = Academic.Core.Entities.Module;
using Path = Academic.Core.Entities.Path;

namespace Academic.Repository.Data
{
    public  class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {         
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new AdminConfig());
            //modelBuilder.ApplyConfiguration(new InstructorConfig());
            //modelBuilder.ApplyConfiguration(new ModuleConfig());
            //modelBuilder.ApplyConfiguration(new ModuleSectionConfig());
            //modelBuilder.ApplyConfiguration(new MultiChoiceQuestionConfig());
            //modelBuilder.ApplyConfiguration(new PathConfig());
            //modelBuilder.ApplyConfiguration(new UserConfig());
            //modelBuilder.ApplyConfiguration(new PathTaskConfig());
            //modelBuilder.ApplyConfiguration(new QuizConfig());

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); // Corrected here
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Instructor> Instructors { get; set; } // Corrected to Instructors
        public DbSet<Module> Modules { get; set; } // Corrected to Modules
        public DbSet<ModuleSection> ModuleSections { get; set; } // Corrected to ModuleSections
        public DbSet<MultiChoiceQuestion> MultiChoiceQuestions { get; set; } // Corrected to MultiChoiceQuestions
        public DbSet<Path> Paths { get; set; } // Corrected to Paths
        public DbSet<User> Users { get; set; } // Corrected to Users
        public DbSet<PathTask> PathTasks { get; set; } // Corrected to PathTasks
        public DbSet<Quiz> Quizzes { get; set; } // Corrected to Quizzes

    }
}
