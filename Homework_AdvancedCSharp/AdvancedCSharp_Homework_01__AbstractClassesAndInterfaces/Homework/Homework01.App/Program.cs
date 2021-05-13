using Homework01.Domain.Models;
using System;
using System.Collections.Generic;

namespace Homework01.App
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>
            {
               new Student(1, "Bob", "bobbobsky", "bob123", 10),
               new Student(2, "Tom", "tomtomsky", "tom123", 9),
            };

            List<Teacher> teacherList = new List<Teacher>
            {
               new Teacher(1, "Jill", "jilljillsky", "jill123", "HTML"),
               new Teacher(2, "Jane", "janejanesky", "jane123", "CSS"),
            };

            Console.WriteLine("Printing the students:");
            studentList.ForEach(student => student.PrintUser());

            Console.WriteLine("Printing the teachers: ");
            teacherList.ForEach(teacher => teacher.PrintUser());

            Console.ReadLine();
        }
}
}

