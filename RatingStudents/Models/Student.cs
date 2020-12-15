using System;
using System.Collections.Generic;

#nullable disable

namespace RatingStudents.Models
{
    public partial class Student
    {
        public Student()
        {
            Ratings = new HashSet<Rating>();
        }

        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Town { get; set; }
        public string Street { get; set; }
        public int NumberOfHouse { get; set; }
        public int? NumberOfFlat { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }

        public virtual ICollection<Rating> Ratings { get; set; }
    }
}
