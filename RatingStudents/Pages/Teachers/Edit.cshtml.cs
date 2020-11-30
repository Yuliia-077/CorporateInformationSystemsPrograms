using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RatingStudents.Models;

namespace RatingStudents.Pages.Teachers
{
    public class ChangeModel : PageModel
    {
        StudentRatingContext db;
        public Teacher Teacher { get; set; }
        public ChangeModel(StudentRatingContext context)
        {
            db = context;
        }
        public IActionResult OnGet(int? id)
        {
            if (id != null)
            {
                Teacher = db.Teachers.FirstOrDefault(p => p.Id == id);
                if (Teacher != null)
                    return Page();
            }
            return NotFound();
        }

        public IActionResult OnPost(Teacher teacher)
        {
            db.Teachers.Update(teacher);
            db.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
