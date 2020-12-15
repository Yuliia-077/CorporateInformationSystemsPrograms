using System;
using System.Collections.Generic;

#nullable disable

namespace RatingStudents.Models
{
    public partial class Subject
    {
        public Subject()
        {
            Ratings = new HashSet<Rating>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int MaxMark { get; set; }
        public int TeacherId { get; set; }

        public virtual Teacher Teacher { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
    }
}
