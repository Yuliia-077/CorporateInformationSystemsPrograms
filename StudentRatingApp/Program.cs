using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;


namespace StudentRatingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=localhost\SQLEXPRESS02;Initial Catalog=StudentRating;Integrated Security=True";

            string SqlExpAmountOfStudents = "SELECT COUNT(Surname) FROM Students";
            string SqlExpAmountOfTeachers = "SELECT COUNT(Surname) FROM Teachers";
            string SqlExpAmountOfSubjects = "SELECT COUNT(Name) FROM Subjects";
            string SqlExpression = "SELECT Students.* " + 
                "FROM Rating INNER JOIN Students ON StudentId = Students.Id " +
                "GROUP BY Id, Surname, FirstName, MiddleName, Town, Street, NumberOfHouse, NumberOfFlat, PhoneNumber, DateOfBirth " +
                "HAVING COUNT(SubjectId) >= 2 ";
            string SqlExpression1 = "SELECT * FROM Subjects INNER JOIN Teachers ON TeacherId = Teachers.Id";
            string SqlExpression2 = "SELECT Students.*, Subjects.* " +
                "FROM(Rating INNER JOIN Students ON StudentId = Students.Id) INNER JOIN Subjects ON Subjects.Id = SubjectId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command1 = new SqlCommand(SqlExpAmountOfStudents, connection);
                var countStudents = command1.ExecuteScalar();
                Console.WriteLine("Amount of students: {0}", countStudents);

                SqlCommand command2 = new SqlCommand(SqlExpAmountOfTeachers, connection);
                var countTeachers = command2.ExecuteScalar();
                Console.WriteLine("Amount of teachers: {0}", countTeachers);

                SqlCommand command3 = new SqlCommand(SqlExpAmountOfSubjects, connection);
                var countSubjects = command3.ExecuteScalar();
                Console.WriteLine("Amount of subjects: {0}", countSubjects);

                SqlCommand command4 = new SqlCommand(SqlExpression, connection);
                SqlDataReader reader = command4.ExecuteReader();
                Console.WriteLine();
                Console.WriteLine("Students have ration not less than 2 subjects");
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Student student = new Student(reader);
                        Console.WriteLine(student.ToShortString());
                    }
                }
                reader.Close();

                SqlCommand command5 = new SqlCommand(SqlExpression1, connection);
                SqlDataReader reader1 = command5.ExecuteReader();
                Console.WriteLine();
                Console.WriteLine("Subjects and teachers who teach them");
                if (reader1.HasRows)
                {
                    while (reader1.Read())
                    {
                        Subject subject = new Subject(reader1.GetInt32(0), reader1.GetString(1), reader1.GetInt32(2), reader1.GetInt32(3));
                        Teacher teacher = new Teacher(reader1.GetInt32(4), reader1.GetString(5), reader1.GetString(6), reader1.GetString(7));
                        Console.WriteLine(subject.ToString() + " " + teacher.ToString());
                    }
                }
                reader1.Close();

                SqlCommand command6 = new SqlCommand(SqlExpression2, connection);
                SqlDataReader reader2 = command6.ExecuteReader();
                Console.WriteLine();
                Console.WriteLine("Subjects and students who learn them");
                if (reader2.HasRows)
                {
                    while (reader2.Read())
                    {
                        Student student = new Student(reader2);
                        Subject subject = new Subject(reader2.GetInt32(10), reader2.GetString(11), reader2.GetInt32(12), reader2.GetInt32(13));
                        Console.WriteLine(student.ToShortString() + " " + subject.ToString());
                    }
                }
                reader2.Close();
            }
        }
    }
}
