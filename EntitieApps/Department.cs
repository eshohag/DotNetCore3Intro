using System;
using System.Collections.Generic;
using System.Text;

namespace EntitieApps
{
   public class Department
    {
        public int Id { get; set; }
        public string DeptName { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
