using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RatingStudents.Models;

namespace RatingStudents.Pages.Subjects
{
    public class IndexModel : PageModel
    {
        StudentRatingContext db;
        public List<SubjectTeacher> Subjects { get; set; }
        public IndexModel(StudentRatingContext context)
        {
            db = context;
        }

        public void OnGet()
        {
            var subTea = from sub in db.Subjects
                         join tea in db.Teachers on sub.TeacherId equals tea.Id
                         select new
                         {
                             sub,
                             tea
                         };
            List<SubjectTeacher> subjectTeachers = new List<SubjectTeacher>();
            foreach (var sT in subTea)
            {
                SubjectTeacher subjectTeacher = new SubjectTeacher(sT.sub, sT.tea);
                subjectTeachers.Add(subjectTeacher);
            }
            Subjects = subjectTeachers;
        }

        public IActionResult OnPostDelete(int id)
        {
            Subject subject = db.Subjects.FirstOrDefault(p => p.Id == id);
                if (subject != null)
                {
                    db.Subjects.Remove(subject);
                    db.SaveChanges();
                }
            return RedirectToPage("Index");
        }
    }
}
