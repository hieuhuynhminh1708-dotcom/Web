using Lab07.Models;

using Microsoft.EntityFrameworkCore;

namespace Lab07.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options)
            : base(options)
        {
        }
        public DbSet<Lab07.Models.Student> Students { get; set; } = default!;
        public DbSet<Lab07.Models.Course> Courses { get; set; } = default!;
        public DbSet<Lab07.Models.Enrollment> Enrollments { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {

            modelBuilder.Entity<Course>().ToTable("Course");

            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");

            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}


