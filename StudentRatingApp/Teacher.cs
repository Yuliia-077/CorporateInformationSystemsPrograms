using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace StudentRatingApp
{
    class Teacher
    {
        private int _id;
        private string _lastName;
        private string _firstName;
        private string _middleName;

        public int Id
        {
            get => _id;
            set => _id = value;
        }
        public string LastName
        {
            get => _lastName;
            set => _lastName = value;
        }
        public string FirstName
        {
            get => _firstName;
            set => _firstName = value;
        }
        public string MiddleName
        {
            get => _middleName;
            set => _middleName = value;
        }

        public Teacher(int id, string lastName, string firstName, string middleName)
        {
            Id = id;
            LastName = lastName;
            FirstName = firstName;
            MiddleName = middleName;

        }
        public Teacher() : this(0, "Brown", "Dan", "Georgievich")
        { }

        public Teacher(SqlDataReader reader)
        {
            Id = reader.GetInt32(0);
            LastName = reader.GetString(1);
            FirstName = reader.GetString(2);
            MiddleName = reader.GetString(3);
        }

        public override string ToString()
        {
            return LastName + " " + FirstName + " " + MiddleName;
        }
    }
}
