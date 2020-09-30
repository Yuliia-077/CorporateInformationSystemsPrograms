using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace StudentRatingApp
{
    class Subject
    {
        private int _id;
        private string _name;
        private int _maxMark;
        private int _teacherId;

        public int Id
        {
            get => _id;
            set => _id = value;
        }
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public int MaxMark
        {
            get => _maxMark;
            set => _maxMark = value;
        }
        public int TeacherId
        {
            get => _teacherId;
            set => _teacherId = value;
        }

        public Subject(int id, string name, int maxMark, int teacherId)
        {
            Id = id;
            Name = name;
            MaxMark = maxMark;
            TeacherId = teacherId;
        }

        public Subject()
        {
            Id = 0;
            Name = "C#";
            MaxMark = 100;
            TeacherId = 0;
        }

        public Subject(SqlDataReader reader)
        {
            Id = reader.GetInt32(0);
            Name = reader.GetString(1);
            MaxMark = reader.GetInt32(2);
            TeacherId = reader.GetInt32(3);

        }

        public override string ToString()
        {
            return Name + " " + MaxMark;
        }


    }
}
