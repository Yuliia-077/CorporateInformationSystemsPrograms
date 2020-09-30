using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace StudentRatingApp
{
    class Ration
    {
        private int _studentId;
        private int _subjectId;
        private int _mark;
        private DateTime _date;
        public int StudentId
        {
            get => _studentId;
            set => _studentId = value;
        }
        public int SubjectId
        {
            get => _subjectId;
            set => _subjectId = value;
        }
        public int Mark
        {
            get => _mark;
            set => _mark = value;
        }
        public DateTime Date
        {
            get => _date;
            set => _date = value;
        }
        public Ration(int studentId, int subjectId, int mark, DateTime dateTime)
        {
            StudentId = studentId;
            SubjectId = subjectId;
            Mark = mark;
            Date = dateTime;
        }
        public Ration()
        {
            StudentId = 0;
            SubjectId = 0;
            Mark = 100;
            Date = new DateTime(2020,09,01);
        }
        public Ration(SqlDataReader reader)
        {
            StudentId = reader.GetInt32(0);
            SubjectId = reader.GetInt32(1);
            Mark = reader.GetInt32(2);
            Date = reader.GetDateTime(3);
        }
    }
}
