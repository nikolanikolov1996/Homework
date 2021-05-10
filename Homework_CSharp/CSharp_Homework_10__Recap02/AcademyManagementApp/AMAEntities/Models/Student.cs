using System;
using System.Collections.Generic;
using System.Text;
using AMAEntities.Enums;

namespace AMAEntities.Models
{
    public class Student : User
    {
        private Dictionary<string, int> Grades { get; set; } // grades property - dictionary string key and int value
        public List<Subject> Subjects { get; set; } // subjects property

        // Student constructor inheriting from : base User constructor
        public Student(int id, string fname, string lname, string email, string password)
            : base(id, fname, lname, email, password, Role.Student)
        {
            Grades = new Dictionary<string, int>();
        }

        // Returns grades
        public Dictionary<string, int> GetGrades()
        {
            return Grades;
        }

        // Adds grade
        public void AddGrade(string subject, int grade)
        {
            Grades.Add(subject, grade);
        }
    }
}
