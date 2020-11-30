using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RatingStudents.Models;

namespace RatingStudents.Pages
{
    public class EditModel : PageModel
    {
        StudentRatingContext db;
        public List<Student> Students { get; set; }
        public List<Subject> Subjects { get; set; }
        public StudentSubjectRating StudentSubjectRating { get; set; }
        public EditModel(StudentRatingContext context)
        {
            db = context;
        }

        public List<Student> StudentsList(int id)
        {
            var stud = from st in db.Students
                       where st.Id != id
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

        public List<Subject> SubjectsList(int id)
        {
            var sub = from st in db.Subjects
                      where st.Id != id
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
                db.Ratings.Update(rating);
                db.SaveChanges();
                return RedirectToPage("Index");
            }
            return NotFound();
        }

        public IActionResult OnGet(int? id)
        {
            if (id != null)
            {
                Rating rating = db.Ratings.FirstOrDefault(p => p.Id == id);
                Student student = db.Students.FirstOrDefault(p => p.Id == rating.StudentId);
                Subject subject = db.Subjects.FirstOrDefault(p => p.Id == rating.SubjectId);
                StudentSubjectRating = new StudentSubjectRating(rating, student, subject);
                Students = StudentsList(student.Id);
                Subjects = SubjectsList(subject.Id);
                if (StudentSubjectRating != null)
                {
                    return Page();
                }
            }
            return NotFound();
        }
    }
}
