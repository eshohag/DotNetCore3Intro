using System;
using System.Collections.Generic;

namespace DatabaseFirstEFCore.Context.Models
{
    public partial class Course
    {
        public Course()
        {
            Enrollment = new HashSet<Enrollment>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public virtual ICollection<Enrollment> Enrollment { get; set; }
    }
}
