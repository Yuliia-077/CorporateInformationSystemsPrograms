using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RatingStudents.Models;

namespace RatingStudents.Pages.Subjects
{
    public class AddModel : PageModel
    {
        StudentRatingContext db;
        public List<Teacher> Teachers { get; set; }
        public AddModel(StudentRatingContext context)
        {
            db = context;
        }
        public List<Teacher> TeachersList()
        {
            var teachersList = from t in db.Teachers
                               select t;
            List<Teacher> teachers = new List<Teacher>();
            foreach (var t in teachersList)
            {
                Teacher teacher = new Teacher();
                teacher.Id = t.Id;
                teacher.LastName = t.LastName;
                teacher.FirstName = t.FirstName;
                teacher.MiddleName = t.MiddleName;
                teachers.Add(teacher);
            }
            return teachers;
        }
        public IActionResult OnPost(Subject subject)
        {
            db.Subjects.Add(subject);
            db.SaveChanges();
            return RedirectToPage("Index");
        }
        public void OnGet()
        {
            Teachers = TeachersList();
        }
    }
}
