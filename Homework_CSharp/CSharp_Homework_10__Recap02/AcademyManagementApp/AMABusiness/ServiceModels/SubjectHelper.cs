using AMAEntities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AMABusiness.ServiceModels
{
    class SubjectHelper
    {
        // Prints student's subjects
        public static void ListOfStudentSubjects(Student student)
        {
            Console.Clear();

            Console.WriteLine($"These are the subjects student {student.FirstName} is attending on:");
            Dictionary<string, int> gradesDictionary = student.GetGrades();
            foreach (KeyValuePair<string, int> item in gradesDictionary)
            {
                Console.WriteLine($"Subject: {item.Key}");
            }
        }

        // Prints the students subjects and grades
        public static void PrintListOfSubjectAndGrades(LoggedUser loggedUser)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("==============================");
            Console.WriteLine("ACADEMY MANAGEMENT APPLICATION");
            Console.WriteLine("==============================");

            Console.WriteLine($"{loggedUser.Student.FirstName} here are your grades:");
            Dictionary<string, int> gradesDictionary = loggedUser.Student.GetGrades();
            foreach (KeyValuePair<string, int> item in gradesDictionary)
            {
                Console.WriteLine($"Subject: {item.Key} - Grade: {item.Value}");
            }
        }
    }
}
