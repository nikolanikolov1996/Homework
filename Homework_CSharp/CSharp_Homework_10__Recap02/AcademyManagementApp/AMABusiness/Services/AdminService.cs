using AMABusiness.ServiceModels;
using AMAEntities;
using AMAEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AMABusiness.Services
{
    public class AdminService
    {
        // Start admin service
        public static void StartAdminService(int choice, LoggedUser loggedUser)
        {
            switch (choice)
            {
                case 1:
                    AddNewAdmin();
                    break;
                case 2:
                    RemoveAdmin(loggedUser);
                    break;
                case 3:
                    AddNewTrainer();
                    break;
                case 4:
                    RemoveTrainer();
                    break;
                case 5:
                    AddNewStudent();
                    break;
                case 6:
                    RemoveStudent();
                    break;
                default:
                    throw new Exception("Wrong input. Please select option from 1 to 7!");
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

        // Method for adding new admin
        public static void AddNewAdmin()
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
                    Console.WriteLine("Please enter admin's first name:");
                    string newAdminName = Console.ReadLine();
                    UserHelper.CheckNamesInput(newAdminName);

                    Console.WriteLine("Please enter admin's last name:");
                    string newAdminLastName = Console.ReadLine();
                    UserHelper.CheckNamesInput(newAdminLastName);

                    Console.WriteLine("Please enter admin's email:");
                    string newAdminEmail = Console.ReadLine();
                    UserHelper.ValidateEmailInput(newAdminEmail);

                    Console.WriteLine("Please enter admin's password:");
                    string newAdminPassword = Console.ReadLine();
                    UserHelper.CheckPasswordInput(newAdminPassword);

                    UserHelper.ChecksIfEmailAlreadyUsed(newAdminEmail, newAdminPassword);
                    UserHelper.AddAdmin(new Admin(UserHelper.GetLengthOfAdmins() + 1, newAdminName, newAdminLastName, newAdminEmail, newAdminPassword));
                    return;
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

        // Method for adding new trainer
        public static void AddNewTrainer()
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
                    Console.WriteLine("Please enter trainer's first name:");
                    string newTrainerName = Console.ReadLine();
                    UserHelper.CheckNamesInput(newTrainerName);

                    Console.WriteLine("Please enter trainer's last name:");
                    string newTrainerLastName = Console.ReadLine();
                    UserHelper.CheckNamesInput(newTrainerLastName);

                    Console.WriteLine("Please enter trainer's email:");
                    string newTrainerEmail = Console.ReadLine();
                    UserHelper.ValidateEmailInput(newTrainerEmail);

                    Console.WriteLine("Please enter trainer's password:");
                    string newTrainerPassword = Console.ReadLine();
                    UserHelper.CheckPasswordInput(newTrainerPassword);

                    UserHelper.ChecksIfEmailAlreadyUsed(newTrainerEmail, newTrainerPassword);
                    UserHelper.AddTrainer(new Trainer(UserHelper.GetLengthOfTrainers() + 1, newTrainerName, newTrainerLastName, newTrainerEmail, newTrainerPassword));
                    return;
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

        // Method for adding new student
        public static void AddNewStudent()
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
                    Console.WriteLine("Please enter student's first name:");
                    string newStudentName = Console.ReadLine();
                    UserHelper.CheckNamesInput(newStudentName);

                    Console.WriteLine("Please enter student's last name:");
                    string newStudentLastName = Console.ReadLine();
                    UserHelper.CheckNamesInput(newStudentLastName);

                    Console.WriteLine("Please enter student's email:");
                    string newStudentEmail = Console.ReadLine();
                    UserHelper.ValidateEmailInput(newStudentEmail);

                    Console.WriteLine("Please enter student's password:");
                    string newStudentPassword = Console.ReadLine();
                    UserHelper.CheckPasswordInput(newStudentPassword);

                    UserHelper.ChecksIfEmailAlreadyUsed(newStudentEmail, newStudentPassword);
                    UserHelper.AddStudent(new Student(UserHelper.GetLengthOfStudents() + 1, newStudentName, newStudentLastName, newStudentEmail, newStudentPassword));
                    return;
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

        // Method for removing admin
        public static void RemoveAdmin(LoggedUser loggedUser)
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
                    UserHelper.PrintListOfAdmins();
                    Console.WriteLine("Please enter the email of the admin you want to remove:");
                    string emailInput = Console.ReadLine();
                    UserHelper.ValidateEmailInput(emailInput);
                    Admin admin = InMemoryDatabase.Admins.Where(admin => admin.Email == emailInput).FirstOrDefault();

                    if (loggedUser.Admin.Email == emailInput)
                    {
                        throw new Exception("Error, you cant remove yourself!");
                    }

                    else if (admin != null)
                    {
                        UserHelper.RemoveAdmin(admin);
                        return;
                    }

                    else
                    {
                        throw new Exception("There is no such admins's email in database!");
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

        // Method for removing trainer
        public static void RemoveTrainer()
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
                    UserHelper.PrintListOfTrainers();
                    Console.WriteLine("Please enter the email of the trainer you want to remove:");
                    string emailInput = Console.ReadLine();
                    UserHelper.ValidateEmailInput(emailInput);
                    Trainer trainer = InMemoryDatabase.Trainers.Where(trainer => trainer.Email == emailInput).FirstOrDefault();

                    if (trainer != null)
                    {
                        UserHelper.RemoveTrainer(trainer);
                        return;
                    }

                    else
                    {
                        throw new Exception("There is no such trainer's email in database!");
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

        // Method for removing student
        public static void RemoveStudent()
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
                    UserHelper.PrintListOfStudents();
                    Console.WriteLine("Please enter the email of the student you want to remove");
                    string emailInput = Console.ReadLine();
                    UserHelper.ValidateEmailInput(emailInput);
                    Student student = InMemoryDatabase.Students.Where(student => student.Email == emailInput).FirstOrDefault();

                    if (student != null)
                    {
                        UserHelper.RemoveStudent(student);
                        return;
                    }

                    else
                    {
                        throw new Exception("There is no such student's email in database!");
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




    }
}
