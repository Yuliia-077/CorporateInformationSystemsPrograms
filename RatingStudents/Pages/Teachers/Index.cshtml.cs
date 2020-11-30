using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RatingStudents.Models;

namespace RatingStudents.Pages.Teachers
{
    public class IndexModel : PageModel
    {
        StudentRatingContext db;
        public List<Teacher> Teachers { get; set; }
        public IndexModel(StudentRatingContext context)
        {
            db = context;
        }
        public void OnGet()
        {
           Teachers = db.Teachers.ToList();
        }

        public IActionResult OnPostDelete(int id)
        {
            Teacher teacher = db.Teachers.FirstOrDefault(p => p.Id == id);
                if (teacher != null)
                {
                    db.Teachers.Remove(teacher);
                    db.SaveChanges();
                }
            return RedirectToPage("Index");
        }
    }
}
