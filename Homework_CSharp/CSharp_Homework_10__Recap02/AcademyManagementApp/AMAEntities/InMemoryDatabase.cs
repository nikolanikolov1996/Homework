using AMAEntities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AMAEntities
{
    public static class InMemoryDatabase
    {
        public static List<Admin> Admins { get; set; } // Database admins
        public static List<Trainer> Trainers { get; set; } // Database trainers
        public static List<Subject> Subjects { get; set; } // Database subjects
        public static List<Student> Students { get; set; } // Database students

        // Static consturctor generating admins, trainers, students and subjects when instantiang or calling the InMemoryDatabase
        static InMemoryDatabase()
        {
            GenerateAdmins();
            GenerateTrainers();
            GenerateStudentsAndSubjects();
        }

        // Generate admins
        private static void GenerateAdmins()
        {
            Admins = new List<Admin>()
            {
                new Admin(1, "Bob", "Bobsky", "adminbob@mail.com", "bob123"),
                new Admin(2, "John", "Johnsky", "adminjohn@mail.com", "john123")
            };
        }

        // Generate trainers
        private static void GenerateTrainers()
        {
            Trainers = new List<Trainer>()
            {
                new Trainer(1, "Christy", "Christsky", "christytrainer@mail.com", "christy123"),
                new Trainer(2, "Jill", "Jillsky", "jilltrainer@mail.com", "jill123")
            };
        }

        // Generate students and subjects
        private static void GenerateStudentsAndSubjects()
        {
            Subjects = new List<Subject>()
            {
                new Subject() { Name = "HTML5",
                    IsOptional = false,
                    NumberOfClasses = 10,
                    EndOn = new DateTime(2021, 04, 20),
                    StartOn =  new DateTime(2021, 04, 01)},
                new Subject() { Name = "CSS",
                    IsOptional = false,
                    NumberOfClasses = 10,
                    EndOn = new DateTime(2021, 05, 20),
                    StartOn =  new DateTime(2021, 05, 01)},
                new Subject() { Name = "Basic JavaScript",
                    IsOptional = false,
                    NumberOfClasses = 10,
                    EndOn = new DateTime(2021, 03, 20),
                    StartOn =  new DateTime(2021, 03, 01)},
                new Subject() { Name = "Advanced JavaScript",
                    IsOptional = false,
                    NumberOfClasses = 10,
                    EndOn = new DateTime(2021, 02, 20),
                    StartOn =  new DateTime(2021, 02, 01)},
                new Subject() { Name = "Basic C#",
                    IsOptional = false,
                    NumberOfClasses = 10,
                    EndOn = new DateTime(2021, 01, 20),
                    StartOn =  new DateTime(2021, 01, 01)},
                new Subject() { Name = "Advanced C#",
                    IsOptional = false,
                    NumberOfClasses = 10,
                    EndOn = new DateTime(2020, 12, 20),
                    StartOn =  new DateTime(2020, 12, 01)},
            };

            Students = new List<Student>()
            {
                new Student(1, "Tom", "Tomsky", "tomtomsky@mail.com", "tom123")
                { Subjects = new List<Subject> { Subjects[0], Subjects[1], Subjects[4] } },

                new Student(2, "Greg", "Gregsky", "greggregsky@mail.com", "greg123")
                { Subjects = new List<Subject> { Subjects[1], Subjects[0], Subjects[2] } },

                new Student(3, "Jane", "Janesky", "janejanesky@mail.com", "jane123")
                { Subjects = new List<Subject> { Subjects[2], Subjects[3], Subjects[4] } },

                new Student(4, "Chris", "Doe", "chrisdoe@mail.com", "chris123")
                { Subjects = new List<Subject> { Subjects[3], Subjects[4], Subjects[1] } },

                new Student(5, "Merry", "King", "rodrodsky@mail.com", "rod123")
                { Subjects = new List<Subject> { Subjects[4], Subjects[3], Subjects[2] } },

                new Student(6, "Zoi", "Zosky", "zoizosky@mail.com", "zoi123")
                { Subjects = new List<Subject> { Subjects[1], Subjects[3], Subjects[4] } },

                new Student(7, "Michael", "Prince", "michaelprince@mail.com", "michael123")
                { Subjects = new List<Subject> { Subjects[2], Subjects[3], Subjects[1] } }
            };

            Random randomNumber = new Random();

            Students.ForEach(student => 
            {
                student.Subjects.ForEach(subject => 
                {
                    student.AddGrade(subject.Name, randomNumber.Next(6, 11));
                });
            });
        }
    }
}
