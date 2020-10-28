using System;
using System.Collections.Generic;

namespace StudentRating
{
    public partial class Rating
    {
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public int Mark { get; set; }
        public DateTime DateRating { get; set; }

        public virtual Students Student { get; set; }
        public virtual Subjects Subject { get; set; }
    }
}
