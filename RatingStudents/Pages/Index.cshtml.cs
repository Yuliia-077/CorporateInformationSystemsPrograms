using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RatingStudents.Models;

namespace RatingStudents.Pages
{
    public class IndexModel : PageModel
    {
        StudentRatingContext db;
        public List<StudentSubjectRating> Rating { get; set; }
        public IndexModel(StudentRatingContext context)
        {
            db = context;
        }

        public void OnGet()
        {
            var students = from r in db.Ratings
                           join st in db.Students on r.StudentId equals st.Id
                           join sub in db.Subjects on r.SubjectId equals sub.Id
                           select new
                           {
                               r, sub, st
                           };
            List<StudentSubjectRating> studentSubjectRating = new List<StudentSubjectRating>();
            foreach (var student in students)
            {
                StudentSubjectRating studentSubjectRating1 = new StudentSubjectRating(student.r, student.st, student.sub);
                studentSubjectRating.Add(studentSubjectRating1);
            }
            Rating = studentSubjectRating;
        }

        public IActionResult OnPostDelete(int id)
        {
            Rating rating = db.Ratings.FirstOrDefault(p => p.Id == id);
            if (rating != null)
            {
                db.Ratings.Remove(rating);
                db.SaveChanges();
            }
            return RedirectToPage("Index");
        }
    }
}
