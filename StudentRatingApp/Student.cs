using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace StudentRatingApp
{
    class Student
    {
        private int _id;
        private string _lastName;
        private string _firstName;
        private string _middleName;
        private string _town;
        private string _street;
        private int _numberOfHouse;
        private int _numberOfFlat;
        private string _phoneNumber;
        private DateTime _dateOfBirth;

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
        public string Town
        {
            get => _town;
            set => _town = value;
        }
        public string Street
        {
            get => _street;
            set => _street = value;
        }
        public int NumberOfHouse
        {
            get => _numberOfHouse;
            set => _numberOfHouse = value;
        }
        public int NumberOfFlat
        {
            get => _numberOfFlat;
            set => _numberOfFlat = value;
        }
        public string PhoneNumber
        {
            get => _phoneNumber;
            set => _phoneNumber = value;
        }
        public DateTime DateOfBirth
        {
            get => _dateOfBirth;
            set => _dateOfBirth = value;
        }

        public Student(int id, string lastName, string firstName, string middleName, string town, string street, int numberOfHouse, int numberOfFlat, string phoneNumber, DateTime dateOfBirth)
        {
            Id = id;
            LastName = lastName;
            FirstName = firstName;
            MiddleName = middleName;
            Town = town;
            Street = street;
            NumberOfHouse = numberOfHouse;
            NumberOfFlat = numberOfFlat;
            PhoneNumber = phoneNumber;
            DateOfBirth = dateOfBirth;

        }
        public Student() : this(0, "Brown", "Dan", "Georgievich", "Cherniwtsi", "Holovna", 1, 0, "+3809999999999", new DateTime(2000,01,01))
        { }

        public Student(SqlDataReader reader)
        {
            Id = reader.GetInt32(0);
            LastName = reader.GetString(1);
            FirstName = reader.GetString(2);
            MiddleName = reader.GetString(3);
            Town = reader.GetString(4);
            Street = reader.GetString(5);
            NumberOfHouse = reader.GetInt32(6);
            NumberOfFlat = reader.GetInt32(7);
            PhoneNumber = reader.GetString(8);
            DateOfBirth = reader.GetDateTime(9);
        }

        public override string ToString()
        {
            return Id + " " + LastName + " " + FirstName + " " + MiddleName + " " + Town + " " + Street + " " + NumberOfHouse + " " + NumberOfFlat + " " + PhoneNumber + " " + DateOfBirth ;
        }

        virtual public string ToShortString()
        {
            return FirstName + " " + LastName + " " + DateOfBirth;
        }
    }
}
