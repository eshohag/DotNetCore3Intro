
using System;

namespace EntitieApps
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
