using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentRating.Models;

namespace StudentRating.Controllers
{
    public class SubjectsController : Controller
    {
        StudentRatingContext db;
        public SubjectsController(StudentRatingContext context)
        {
            db = context;
        }

        public List<Teacher> TeachersList()
        {
            var teachersList = from t in db.Teachers
                       select t;
            List<Teacher> teachers = new List<Teacher>();
            foreach (var t in teachersList)
            {
                Teacher teacher = new Teacher();
                teacher.Id = t.Id;
                teacher.LastName = t.LastName;
                teacher.FirstName = t.FirstName;
                teacher.MiddleName = t.MiddleName;
                teachers.Add(teacher);
            }
            return teachers;
        }


        public IActionResult Index()
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
                Subject subject = new Subject();
                Teacher teacher = new Teacher();
                SubjectTeacher subjectTeacher = new SubjectTeacher(sT.sub, sT.tea);
                subjectTeachers.Add(subjectTeacher);
            }
            return View(subjectTeachers);

        }

        public IActionResult Add()
        {
            ViewBag.Teachers = TeachersList();
            return View();
        }

        [HttpPost]
        public IActionResult Add(Subject subject)
        {
            db.Subjects.Add(subject);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id != null)
            {
                Subject subject = db.Subjects.FirstOrDefault(p => p.Id == id);
                Teacher teacher = db.Teachers.FirstOrDefault(p => p.Id == subject.TeacherId);
                SubjectTeacher subjectTeacher = new SubjectTeacher(subject, teacher);
                ViewBag.Teachers = TeachersList();
                ViewBag.SubTea = subjectTeacher;
                if (subject != null)
                    return View();
            }
            return NotFound();
        }
        [HttpPost]
        public IActionResult Edit(Subject subject)
        {
            db.Subjects.Update(subject);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id != null)
            {
                Subject subject = db.Subjects.FirstOrDefault(p => p.Id == id);
                if (subject != null)
                {
                    db.Subjects.Remove(subject);
                    db.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }
    }
}
