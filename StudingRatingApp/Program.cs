using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata;

namespace StudingRatingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StudentRatingContext db = new StudentRatingContext())
            {
                // select subjects and teacher who teaches them
                var subjects = from s in db.Subjects.Include(t => t.Teacher)
                               select s;

                // select students and subjects they attend
                var students = from r in db.Rating
                               join st in db.Students on r.StudentId equals st.Id
                               join sub in db.Subjects on r.SubjectId equals sub.Id
                               select new
                               {
                                   LastName = st.LastName,
                                   FirstName = st.FirstName,
                                   SubjectName = sub.Name,
                                   Mark = r.Mark
                               };

                // select students who have ration not less than 2 subjects
                var studentSubject = from r in db.Rating.Include(s => s.Student)
                                     group r by new
                                     { r.StudentId, r.Student.FirstName, r.Student.LastName } into grp
                                     where grp.Count() >= 2
                                     select grp.Key;
                Console.WriteLine("Subjects and teachers who teach them");
                foreach (var subject in subjects.ToList())
                    Console.WriteLine($"{subject.Name} {subject.MaxMark} - {subject.Teacher.LastName} {subject.Teacher.FirstName} {subject.Teacher.MiddleName}");
                
                Console.WriteLine();
                Console.WriteLine("Subjects and students who learn them");
                foreach (var student in students)
                    Console.WriteLine($"{student.LastName} {student.FirstName} {student.SubjectName} {student.Mark}");

                Console.WriteLine();
                Console.WriteLine("Students have ration not less than 2 subjects");
                foreach (var stSub in studentSubject.ToList())
                    Console.WriteLine($"{stSub.LastName} {stSub.FirstName}");
            }

        }
    }
}
