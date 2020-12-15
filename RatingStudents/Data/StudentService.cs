using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RatingStudents.Data
{
    public class SubjectService
    {
            readonly StudentRatingContext _db;

            public SubjectService(StudentRatingContext context)
            {
                _db = context;
            }

            public List<Subject> GetSubjects()
            {
                var subjectsList = _db.Subjects.ToList();
                List<Subject> subjects = new List<Subject>();
                foreach (var rat in subjectsList)
                {
                    Subject subject = rat;
                    subjects.Add(subject);

                }
                return subjects;
            }

            public string Create(Subject subject)
            {
                _db.Subjects.Add(subject);
                _db.SaveChanges();
                return "Add successfully";
            }

            public Subject GetSubject(int id)
            {
                Subject subject = _db.Subjects.FirstOrDefault(p => p.Id == id);
                return subject;
            }

            public string Edit(Subject subject)
            {
                _db.Subjects.Update(subject);
                _db.SaveChanges();
                return "Edit succesfully";
            }

            public string Delete(Subject subject)
            {
                _db.Subjects.Remove(subject);
                _db.SaveChanges();
                return "Delete succesfully";

            }
        }
}
