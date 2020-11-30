using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RatingStudents.Models;

namespace RatingStudents.Pages.Students
{
    public class ChangeModel : PageModel
    {
        StudentRatingContext db;
        public Student Student { get; set; }
        public ChangeModel(StudentRatingContext context)
        {
            db = context;
        }
        public IActionResult OnGet(int? id)
        {
            if (id != null)
            {
                Student = db.Students.FirstOrDefault(p => p.Id == id);
                if (Student != null)
                    return Page();
            }
            return NotFound();
        }

        public IActionResult OnPost(Student student)
        {
            db.Students.Update(student);
            db.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
