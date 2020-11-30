using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RatingStudents.Models;

namespace RatingStudents.Pages.Students
{
    public class AddModel : PageModel
    {
        StudentRatingContext db;
        public List<Student> Students { get; set; }
        public AddModel(StudentRatingContext context)
        {
            db = context;
        }
        public IActionResult OnPost(Student student)
        {
            db.Students.Add(student);
            db.SaveChanges();
            return RedirectToPage("Index");
        }
        public void OnGet()
        {
        }
    }
}
