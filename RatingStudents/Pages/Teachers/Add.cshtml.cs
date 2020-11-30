using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RatingStudents.Models;

namespace RatingStudents.Pages.Teachers
{
    public class AddModel : PageModel
    {
        StudentRatingContext db;
        public AddModel(StudentRatingContext context)
        {
            db = context;
        }
        public IActionResult OnPost(Teacher teacher)
        {
            db.Teachers.Add(teacher);
            db.SaveChanges();
            return RedirectToPage("Index");
        }
        public void OnGet()
        {
        }
    }
}
