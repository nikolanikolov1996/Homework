using Homework01.Domain.AbstractClasses;
using Homework01.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework01.Domain.Models
{
    public class Student : User, IStudent
    {
        public int Grades { get; set; }

        public Student(int id, string name, string userName, string password, int grades)
            : base(id, name, userName, password)
        {
            Grades = grades;
        }

        public override void PrintUser()
        {
            Console.WriteLine($"Student info - Id: {Id} Name: {Name} Username: {UserName} Grades: {Grades}");
        }
    }
}
