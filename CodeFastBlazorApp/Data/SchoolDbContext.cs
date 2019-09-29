using EntitieApps;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFastBlazorApp.Data
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext()
        {
        }
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
        {
           
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-C4K70KG\\MSSQLSERVER14;Database=SchoolBlazorDbContext;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Department { get; set; }
      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("Department");
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}
