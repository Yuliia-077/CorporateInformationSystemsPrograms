using System;
using System.Collections.Generic;

namespace StudentRating
{
    public partial class Subjects
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MaxMark { get; set; }
        public int TeacherId { get; set; }

        public virtual Teachers Teacher { get; set; }
    }
}
