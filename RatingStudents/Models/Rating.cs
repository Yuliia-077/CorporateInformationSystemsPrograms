using System;
using System.Collections.Generic;

#nullable disable

namespace RatingStudents.Models
{
    public partial class Rating
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public int Mark { get; set; }
        public DateTime DateRating { get; set; }

        public virtual Student Student { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
