using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using StudentRating.Models;

namespace StudentRating.Controllers
{
    public class TeachersController : Controller
    {
        StudentRatingContext db;
        public TeachersController(StudentRatingContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            return View(db.Teachers.ToList());

        }

        public IActionResult Add()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Add(Teacher teacher)
        {
            db.Teachers.Add(teacher);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id != null)
            {
                Teacher teacher = db.Teachers.FirstOrDefault(p => p.Id == id);
                if (teacher != null)
                    return View(teacher);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult Edit(Teacher teacher)
        {
            db.Teachers.Update(teacher);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id != null)
            {
                Teacher teacher = db.Teachers.FirstOrDefault(p => p.Id == id);
                if (teacher != null)
                {
                    db.Teachers.Remove(teacher);
                    db.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }
    }
}
