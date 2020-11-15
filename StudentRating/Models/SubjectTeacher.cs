using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRating.Models
{
    public class SubjectTeacher
    {
        public Subject Subject { get; set; }
        public Teacher Teacher{ get; set; }

        public SubjectTeacher(Subject subject, Teacher teacher)
        {
            Subject = subject;
            Teacher = teacher;
        }
    }
}
