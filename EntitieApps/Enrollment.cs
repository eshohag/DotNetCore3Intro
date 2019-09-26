﻿using System;
using System.Collections.Generic;
using System.Text;
using Utilities;

namespace EntitieApps
{
   public class Enrollment
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public Grade? Grade { get; set; }
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}
