using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RatingStudents.Models;

namespace RatingStudents.Pages
{
    public class AddModel : PageModel
    {
        StudentRatingContext db;
        public List<Student> Students { get; set; }
        public List<Subject> Subjects { get; set; }
        public AddModel(StudentRatingContext context)
        {
            db = context;
        }

        public List<Student> StudentsList()
        {
            var stud = from st in db.Students
                       select new
                       {
                           Id = st.Id,
                           LastName = st.LastName,
                           FirstName = st.FirstName
                       };
            List<Student> students = new List<Student>();
            foreach (var st in stud)
            {
                Student student = new Student();
                student.Id = st.Id;
                student.LastName = st.LastName;
                student.FirstName = st.FirstName;
                students.Add(student);
            }
            return students;
        }

        public List<Subject> SubjectsList()
        {
            var sub = from st in db.Subjects
                      select new
                      {
                          Id = st.Id,
                          Name = st.Name,
                      };
            List<Subject> subjects = new List<Subject>();
            foreach (var s in sub)
            {
                Subject subject = new Subject();
                subject.Id = s.Id;
                subject.Name = s.Name;
                subjects.Add(subject);
            }
            return subjects;
        }

        public IActionResult OnPost(Rating rating)
        {
            if (rating != null)
            {
                db.Ratings.Add(rating);
                db.SaveChanges();
                return RedirectToPage("Index");
            }
            return NotFound();
        }

        public void OnGet()
        {
            Students = StudentsList();
            Subjects = SubjectsList();
        }
    }
}
