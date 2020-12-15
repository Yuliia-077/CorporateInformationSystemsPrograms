using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RatingStudents.Data
{
    public class TeacherService
    {
            readonly StudentRatingContext _db;

            public TeacherService(StudentRatingContext context)
            {
                _db = context;
            }

            public List<Teacher> GetTeachers()
            {
                var teachersList = _db.Teachers.ToList();
                List<Teacher> teachers = new List<Teacher>();
                foreach (var rat in teachersList)
                {
                    Teacher teacher = rat;
                    teachers.Add(teacher);

                }
                return teachers;
            }

            public string Create(Teacher teacher)
            {
                _db.Teachers.Add(teacher);
                _db.SaveChanges();
                return "Add successfully";
            }

            public Teacher GetTeacher(int id)
            {
                Teacher teacher = _db.Teachers.FirstOrDefault(p => p.Id == id);
                return teacher;
            }

            public string Edit(Teacher teacher)
            {
                _db.Teachers.Update(teacher);
                _db.SaveChanges();
                return "Edit succesfully";
            }

            public string Delete(Teacher teacher)
            {
                _db.Teachers.Remove(teacher);
                _db.SaveChanges();
                return "Delete succesfully";

            }
        }
}
