using AMABusiness.ServiceModels;
using AMAEntities;
using AMAEntities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AMABusiness.Services
{
    public class TrainerService
    {
        // Start trainer service
        public static void StartTrainerService(int userChoice, LoggedUser loggedUser)
        {
            switch (userChoice)
            {
                case 1:
                    SeeAllStudents();
                    break;
                case 2:
                    SeeAllSubjects();
                    break;
                default:
                    throw new Exception("Wrong input. Please select option from 1 or 2!");
            }

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Do you want another service?");
                Console.WriteLine("Type YES of you want to continue");
                Console.WriteLine("Type NO of you want to Logout");
                Console.WriteLine("YES/NO");

                string endChoice = Console.ReadLine();

                if (endChoice.ToUpper() == "YES")
                {
                    UserService.MenuOption(loggedUser);
                    break;
                }

                if (endChoice.ToUpper() == "NO")
                {
                    UserHelper.Logout(loggedUser);
                    break;
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input");
                Console.ResetColor();
                Thread.Sleep(1500);
                Console.Clear();
            }
        }

        private static void SeeAllStudents()
        {
            while (true)
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("==============================");
                Console.WriteLine("ACADEMY MANAGEMENT APPLICATION");
                Console.WriteLine("==============================");

                try
                {
                    UserHelper.DisplayStudentsNames();

                    Console.WriteLine("Write the name of the student to see what subjects is he attending:");
                    string studentName = Console.ReadLine();

                    UserHelper.CheckNamesInput(studentName);

                    Student student = UserHelper.SearchStudentByFirstName(studentName);
                    if (student != null)
                    {
                        SubjectHelper.ListOfStudentSubjects(student);
                        return;
                    }
                    else
                    {
                        throw new Exception("The student name you've entered doesn't exist in our database. Please try again!");
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ResetColor();
                    Thread.Sleep(1750);
                    Console.Clear();
                }

            }
        }

        public static void SeeAllSubjects()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("==============================");
            Console.WriteLine("ACADEMY MANAGEMENT APPLICATION");
            Console.WriteLine("==============================");

            List<Student> studentsList = InMemoryDatabase.Students;
            List<Subject> subjectsList = InMemoryDatabase.Subjects;

            subjectsList.ForEach(subject =>
            {
                studentsList.ForEach(student =>
                {
                    student.Subjects.ForEach(item =>
                    {
                        if (subject.Name == item.Name)
                        {
                            subject.StudentsAttending.Add(student.FirstName);
                        }
                    });
                });
            });

            subjectsList.ForEach(subject =>
            {
                subject.StudentsAttending.ForEach(element =>
                {
                    Console.WriteLine($"Subject: {subject.Name} - Attending students: {element}");
                });
            });
        }
    }
}
