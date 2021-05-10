using AMAEntities;
using AMAEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AMABusiness.ServiceModels
{
    public static class UserHelper
    {
        // Searches if there is admin with the email and password in the database
        public static Admin SearchAdminInDatabase(string email, string password)
        {
            Admin admin = InMemoryDatabase.Admins.Where(admin => admin.Email == email && admin.ValidatePassword(password)).FirstOrDefault();

            return admin;
        }

        // Searches if there is trainer with the email and password in the database
        public static Trainer SearchTrainerInDatabase(string email, string password)
        {
            Trainer trainer = InMemoryDatabase.Trainers.Where(trainer => trainer.Email == email && trainer.ValidatePassword(password)).FirstOrDefault();

            return trainer;
        }

        // Searches if there is student with the email and password in the database
        public static Student SearchStudentInDatabase(string email, string password)
        {
            Student student = InMemoryDatabase.Students.Where(student => student.Email == email && student.ValidatePassword(password)).FirstOrDefault();

            return student;
        }

        // Searches for students by first name
        public static Student SearchStudentByFirstName(string studentName)
        {
            Student student = InMemoryDatabase.Students.Where(student => student.FirstName.ToLower() == studentName.ToLower()).FirstOrDefault();

            return student;
        }

        // Add admin
        public static void AddAdmin(Admin newAdmin)
        {
            InMemoryDatabase.Admins.Add(newAdmin);
            Console.WriteLine("Admin Created.");
        }

        // Add trainer
        public static void AddTrainer(Trainer newTrainer)
        {
            InMemoryDatabase.Trainers.Add(newTrainer);
            Console.WriteLine("Trainer Created.");
        }

        // Add student
        public static void AddStudent(Student newStudent)
        {
            InMemoryDatabase.Students.Add(newStudent);
            Console.WriteLine("Student Created.");
        }

        // Remove admin
        public static void RemoveAdmin(Admin admin)
        {
            if (!InMemoryDatabase.Admins.Remove(admin))
            {
                throw new Exception("Something went wrong. Please try again");
            }
            else
            {
                Console.WriteLine($"Admin {admin.FirstName} was removed from Database");
            }

        }

        // Remove trainer
        public static void RemoveTrainer(Trainer trainer)
        {
            if (!InMemoryDatabase.Trainers.Remove(trainer))
            {
                throw new Exception("Something went wrong. Please try again");             
            }
            else
            {
                Console.WriteLine($"Trainer {trainer.FirstName} was removed from Database");
            }

        }

        // Remove student
        public static void RemoveStudent(Student student)
        {
            if (!InMemoryDatabase.Students.Remove(student))
            {
                throw new Exception("Something went wrong. Please try again");             
            }
            else
            {
                Console.WriteLine($"Student {student.FirstName} was removed from Database");
            }

        }

        // Prints the admins that are saved in the database
        public static void PrintListOfAdmins()
        {
            InMemoryDatabase.Admins.ForEach(admin => Console.WriteLine(admin.Email));
        }

        // Prints the trainers that are saved in the database
        public static void PrintListOfTrainers()
        {
            InMemoryDatabase.Trainers.ForEach(trainer => Console.WriteLine(trainer.Email));
        }

        // Prints the students that are saved in the database
        public static void PrintListOfStudents()
        {
            InMemoryDatabase.Students.ForEach(student => Console.WriteLine(student.Email));
        }

        // Displays Students by name
        public static void DisplayStudentsNames()
        {
            InMemoryDatabase.Students.ForEach(student => Console.WriteLine(student.FirstName));
        }

        //Get length of admins base
        public static int GetLengthOfAdmins()
        {
            int numb = InMemoryDatabase.Admins.Count;
            return numb;
        }

        //Get length of trainers base
        public static int GetLengthOfTrainers()
        {
            int numb = InMemoryDatabase.Trainers.Count;
            return numb;
        }

        //Get length of students base
        public static int GetLengthOfStudents()
        {
            int numb = InMemoryDatabase.Students.Count;
            return numb;
        }

        // Validates email input, checks if it ends with @mail.com
        public static void ValidateEmailInput(string email)
        {
            if (!email.EndsWith("@mail.com"))
            {
                throw new Exception("Email must end with @mail.com!");
            }
        }

        // Validates if the email is already used
        public static void ChecksIfEmailAlreadyUsed(string emailInput, string password)
        {
            Admin admin = SearchAdminInDatabase(emailInput, password);
            Trainer trainer = SearchTrainerInDatabase(emailInput, password);
            Student student = SearchStudentInDatabase(emailInput, password);
            if (admin != null)
            {
                throw new Exception($"The email {emailInput} already exist in admin Database ");
            }
            if (student != null)
            {
                throw new Exception($"The email {emailInput} already exist in student Database ");
            }
            if (trainer != null)
            {
                throw new Exception($"The email {emailInput} already exist in trainer Database ");
            }
        }

        // Validates if the name and last name input contain only letters
        public static void CheckNamesInput(string nameInput)
        {
            if (!nameInput.All(char.IsLetter))
            {
                throw new Exception("Name and last name can contain only LETTERS!");
            }
        }

        // Validating password, checks if it contains only numbers and letters
        public static void CheckPasswordInput(string password)
        {
            if (!password.All(Char.IsLetterOrDigit))
            {
                throw new Exception("Password must contain only letter and digits!");
            }
        }

        // Validating user choice input
        public static int ValidateUserChoice(string input) 
        {
            bool isMenuChoiceValid = int.TryParse(input, out int choice);

            if (!isMenuChoiceValid) 
            {
                throw new Exception("Wrong input...");
            }

            return choice;
        }

        //  Method for logging out
        public static void Logout(LoggedUser loggedUser)
        {
            loggedUser.Admin = null;
            loggedUser.Trainer = null;
            loggedUser.Student = null;
            loggedUser.IsLoggedIn = false;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Logging out...");
            Console.ResetColor();
            Thread.Sleep(2000);
            Console.Clear();
            Service.StartApp();
            return;
        }
    }
}
