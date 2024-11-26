using FullStackWebApplicationBackend.Entities;
using Microsoft.EntityFrameworkCore;

namespace FullStackWebApplicationBackend.Context
{
    public class SchoolDbContext(DbContextOptions<SchoolDbContext> options) : DbContext(options)
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    StudentId = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    Gender = "Male",
                    Email = "john.doe@xample.com",
                    PhoneNumber = "123-456-7890",
                });
                
        }

    }
}
