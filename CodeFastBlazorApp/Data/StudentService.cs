using EntitieApps;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CodeFastBlazorApp.Data
{
    public class StudentService
    {
        private readonly SchoolDbContext context;
        public StudentService()
        {
            context = new SchoolDbContext();
        }
        public IList<Student> GetStudents()
        {
            var students = context.Students
                .Include(a => a.Department)
                .Include(a => a.Enrollments)
                .ToList();
            return students;
        }
    }
}
