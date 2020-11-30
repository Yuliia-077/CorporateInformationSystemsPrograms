using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RatingStudents.Models;

namespace RatingStudents.Pages.Students
{
    public class IndexModel : PageModel
    {
        StudentRatingContext db;
        public List<Student> Students { get; set; }
        public IndexModel(StudentRatingContext context)
        {
            db = context;
        }
        public void OnGet()
        {
           Students = db.Students.ToList();
        }

        public IActionResult OnPostDelete(int id)
        {
            Student student = db.Students.FirstOrDefault(p => p.Id == id);
                if (student != null)
                {
                    db.Students.Remove(student);
                    db.SaveChanges();
                }
            return RedirectToPage("Index");
        }
    }
}
