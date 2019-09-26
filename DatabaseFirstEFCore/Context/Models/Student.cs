using System;
using System.Collections.Generic;

namespace DatabaseFirstEFCore.Context.Models
{
    public partial class Student
    {
        public Student()
        {
            Enrollment = new HashSet<Enrollment>();
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }
        public virtual ICollection<Enrollment> Enrollment { get; set; }
    }
}
