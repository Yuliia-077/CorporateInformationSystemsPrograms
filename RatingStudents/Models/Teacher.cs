using System;
using System.Collections.Generic;

#nullable disable

namespace RatingStudents.Models
{
    public partial class Teacher
    {
        public Teacher()
        {
            Subjects = new HashSet<Subject>();
        }

        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }

        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
