using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RatingStudents.Models
{
    public class StudentSubjectRating
    {
        public Student Student{ get; set; }
        public Subject Subject { get; set; }
        public Rating Rating{ get; set; }

        public StudentSubjectRating()
        { }

        public StudentSubjectRating(Rating rating, Student student, Subject subject)
        {
            Student = student;
            Subject = subject;
            Rating = rating;
        }
    }
}
