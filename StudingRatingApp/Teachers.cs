using System;
using System.Collections.Generic;

namespace StudingRatingApp
{
    public partial class Teachers
    {
        public Teachers()
        {
            Subjects = new HashSet<Subjects>();
        }

        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }

        public virtual ICollection<Subjects> Subjects { get; set; }
    }
}
