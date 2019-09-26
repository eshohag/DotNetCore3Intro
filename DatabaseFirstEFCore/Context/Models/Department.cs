using System;
using System.Collections.Generic;

namespace DatabaseFirstEFCore.Context.Models
{
    public partial class Department
    {
        public Department()
        {
            Student = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string DeptName { get; set; }

        public virtual ICollection<Student> Student { get; set; }
    }
}
