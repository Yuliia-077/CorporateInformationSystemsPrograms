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
    public class HomeController : Controller
    {
        StudentRatingContext db;
        public HomeController(StudentRatingContext context)
        {
            db = context;
        }

        public List<Student> StudentsList()
        {
            var stud = from st in db.Students
                           select new
                           {
                               Id = st.Id,
                               LastName = st.LastName,
                               FirstName = st.FirstName
                           };
            List<Student> students = new List<Student>();
            foreach (var st in stud)
            {
                Student student = new Student();
                student.Id = st.Id;
                student.LastName = st.LastName;
                student.FirstName = st.FirstName;
                students.Add(student);
            }
            return students;
        }

        public List<Subject> SubjectsList()
        {
            var sub = from st in db.Subjects
                      select new
                      {
                          Id = st.Id,
                          Name = st.Name,
                      };
            List<Subject> subjects = new List<Subject>();
            foreach (var s in sub)
            {
                Subject subject = new Subject();
                subject.Id = s.Id;
                subject.Name = s.Name;
                subjects.Add(subject);
            }
            return subjects;
        }

        public IActionResult Index()
        {
            var students = from r in db.Ratings
                                       join st in db.Students on r.StudentId equals st.Id
                                       join sub in db.Subjects on r.SubjectId equals sub.Id
                                       select new
                                       {
                                           Id = r.Id,
                                           LastName = st.LastName,
                                           FirstName = st.FirstName,
                                           StudentId = r.StudentId,
                                           SubjectId = r.SubjectId,
                                           SubjectName = sub.Name,
                                           Mark = r.Mark,
                                           Date = r.DateRating
                                       };
            List<StudentSubjectRating> studentSubjectRating = new List<StudentSubjectRating>();
            foreach (var student in students)
            {
                Rating rating = new Rating();
                Student student1 = new Student();
                Subject subject = new Subject();
                rating.Id = student.Id;
                rating.StudentId = student.StudentId;
                rating.SubjectId = student.SubjectId;
                rating.Mark = student.Mark;
                rating.DateRating = student.Date;
                subject.Name = student.SubjectName;
                student1.LastName = student.LastName;
                student1.FirstName = student.FirstName;
                StudentSubjectRating studentSubjectRating1 = new StudentSubjectRating(rating, student1, subject);
                studentSubjectRating.Add(studentSubjectRating1);
            }
            return View(studentSubjectRating);

        }

        public IActionResult AddRating()
        {
            ViewBag.Students = StudentsList();
            ViewBag.Subjects = SubjectsList();
            return View();
        }

        [HttpPost]
        public IActionResult AddRating(Rating rating)
        {
            db.Ratings.Add(rating);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditRating(int? id)
        {
            if (id != null)
            {
                Rating rating = db.Ratings.FirstOrDefault(p => p.Id == id);
                Student student = db.Students.FirstOrDefault(p => p.Id == rating.StudentId);
                Subject subject = db.Subjects.FirstOrDefault(p => p.Id == rating.SubjectId);
                StudentSubjectRating studentSubjectRating = new StudentSubjectRating(rating, student, subject);
                ViewBag.Students = StudentsList();
                ViewBag.Subjects = SubjectsList();
                ViewBag.StSubRat = studentSubjectRating;
                if (rating != null)
                    return View();
            }
            return NotFound();
        }
        [HttpPost]
        public IActionResult EditRating(Rating rating)
        {
            db.Ratings.Update(rating);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteRating(int? id)
        {
            if (id != null)
            {
                Rating rating = db.Ratings.FirstOrDefault(p => p.Id == id);
                if (rating != null)
                {
                    db.Ratings.Remove(rating);
                    db.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }
        /*[HttpPost]
        public IActionResult DeleteRating(Rating rating)
        {
            db.Ratings.Update(rating);
            db.SaveChanges();
            return RedirectToAction("Index");
        }*/
    }
}
