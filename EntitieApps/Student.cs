
using System;
using System.Collections.Generic;

namespace EntitieApps
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
