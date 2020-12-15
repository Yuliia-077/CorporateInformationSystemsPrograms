using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RatingStudents.Data
{
    public class RatingService
    {
        readonly StudentRatingContext _db;

        public RatingService(StudentRatingContext context)
        {
            _db = context;
        }

        public List<Rating> GetRatings()
        {
            var ratingsList = _db.Ratings.ToList();
            List<Rating> ratings = new List<Rating>();
            foreach (var rat in ratingsList)
            {
                Rating rating = new Rating();
                rating = rat;
                ratings.Add(rating);

            }
            return ratings;
        }

        public string Create(Rating rating)
        {
            _db.Ratings.Add(rating);
            _db.SaveChanges();
            return "Add successfully";
        }

        public Rating GetRating(int id)
        {
            Rating rating = _db.Ratings.FirstOrDefault(p => p.Id == id);
            return rating;
        }

        public string Edit(Rating rating)
        {
            _db.Ratings.Update(rating);
            _db.SaveChanges();
            return "Edit succesfully";
        }

        public string Delete(Rating rating)
        {
            _db.Ratings.Remove(rating);
            _db.SaveChanges();
            return "Delete succesfully";

        }
    }
}
