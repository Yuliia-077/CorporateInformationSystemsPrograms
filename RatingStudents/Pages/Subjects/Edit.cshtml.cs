using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RatingStudents.Models;

namespace RatingStudents.Pages.Subjects
{
    public class ChangeModel : PageModel
    {
        StudentRatingContext db;
        public SubjectTeacher SubjectTeacher { get; set; }
        public List<Teacher> Teachers { get; set; }
        public ChangeModel(StudentRatingContext context)
        {
            db = context;
        }
        public List<Teacher> TeachersList(int id)
        {
            var teachersList = from t in db.Teachers
                               where t.Id != id
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
        public IActionResult OnGet(int? id)
        {
            if (id != null)
            {
                Subject subject = new Subject();
                subject = db.Subjects.FirstOrDefault(p => p.Id == id);
                Teacher teacher = new Teacher();
                teacher = db.Teachers.FirstOrDefault(p => p.Id == subject.TeacherId);
                SubjectTeacher = new SubjectTeacher(subject, teacher);
                if (SubjectTeacher != null)
                {
                    Teachers = TeachersList(SubjectTeacher.Subject.TeacherId);
                    return Page();
                }
            }
            return NotFound();
        }

        public IActionResult OnPost(Subject subject)
        {
            db.Subjects.Update(subject);
            db.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
