using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using StudentRating.Models;

namespace StudentRating.Controllers
{
    public class StudentsController : Controller
    {
        StudentRatingContext db;
        public StudentsController(StudentRatingContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            return View(db.Students.ToList());

        }

        public IActionResult Add()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Add(Student student)
        {
            db.Students.Add(student);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id != null)
            {
                Student student = db.Students.FirstOrDefault(p => p.Id == id);
                if (student != null)
                    return View(student);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            db.Students.Update(student);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id != null)
            {
                Student student = db.Students.FirstOrDefault(p => p.Id == id);
                if (student != null)
                {
                    db.Students.Remove(student);
                    db.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }
    }
}
