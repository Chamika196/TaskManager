using Microsoft.EntityFrameworkCore;
using TaskManager.API.Models.Domain;

namespace TaskManager.API.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<TaskM> TaskMs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaskM>()
     .HasData(
         new TaskM { Id = 11, Title = "Develop RESTful API", Description = "Implement RESTful API for the project", DueDate = DateTime.Now.AddDays(7).Date },
         new TaskM { Id = 12, Title = "Design Database Schema", Description = "Create database schema for the application", DueDate = DateTime.Now.AddDays(5).Date },
         new TaskM { Id = 13, Title = "Implement User Authentication", Description = "Integrate user authentication using OAuth 2.0", DueDate = DateTime.Now.AddDays(10).Date },
         new TaskM { Id = 14, Title = "Optimize Codebase", Description = "Review and optimize the existing codebase", DueDate = DateTime.Now.AddDays(14).Date },
         new TaskM { Id = 15, Title = "Write Unit Tests", Description = "Create unit tests for critical components", DueDate = DateTime.Now.AddDays(8).Date }
     );
        }

    }
}
