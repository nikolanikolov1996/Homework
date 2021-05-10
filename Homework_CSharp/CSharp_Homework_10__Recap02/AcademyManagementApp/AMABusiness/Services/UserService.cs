using AMABusiness.ServiceModels;
using AMAEntities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AMABusiness.Services
{
    public class UserService
    {
        // Login form
        public static LoggedUser Login()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("==============================");
                Console.WriteLine("ACADEMY MANAGEMENT APPLICATION");
                Console.WriteLine("==============================");

                try
                {
                    Console.WriteLine("Enter your email: ");
                    string emailInput = Console.ReadLine();
                    UserHelper.ValidateEmailInput(emailInput);

                    Console.WriteLine("Enter your password: ");
                    string passwordInput = Console.ReadLine();
                    UserHelper.CheckPasswordInput(passwordInput);

                    Console.ResetColor();

                    Student student = UserHelper.SearchStudentInDatabase(emailInput, passwordInput);
                    if (student != null)
                    {
                        return new LoggedUser
                        {
                            Student = student,
                            IsLoggedIn = true
                        };
                    }

                    Admin admin = UserHelper.SearchAdminInDatabase(emailInput, passwordInput);
                    if (admin != null)
                    {
                        return new LoggedUser
                        {
                            Admin = admin,
                            IsLoggedIn = true
                        };
                    }

                    Trainer trainer = UserHelper.SearchTrainerInDatabase(emailInput, passwordInput);
                    if (trainer != null)
                    {
                        return new LoggedUser
                        {
                            Trainer = trainer,
                            IsLoggedIn = true
                        };
                    }

                    throw new Exception("E-mail not found. Please try again !!!");

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

        // Menu 
        public static void MenuOption(LoggedUser loggedUser)
        {
            // If Admin is logged on
            if (loggedUser.Admin != null)
            {
                while (loggedUser.IsLoggedIn)
                {
                    AdminMenu(loggedUser);

                    try
                    {
                        string userInput= Console.ReadLine();
                        int userChoice = UserHelper.ValidateUserChoice(userInput);

                        if (userChoice < 1 || userChoice > 7)
                        {
                            throw new Exception("Please choose option from 1 to 7 !");
                            
                        }
                        else
                        {
                            if (userChoice == 7)
                            {
                                UserHelper.Logout(loggedUser);
                            }
                            else
                            {
                                AdminService.StartAdminService(userChoice, loggedUser);
                                break;
                            }

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
            // If Trainer is logged on
            else if (loggedUser.Trainer != null)
            {
                while (loggedUser.IsLoggedIn)
                {
                    TrainerMenu(loggedUser);

                    try
                    {
                        string userInput = Console.ReadLine();
                        int userChoice = UserHelper.ValidateUserChoice(userInput);

                        if (userChoice < 1 || userChoice > 3)
                        {
                            throw new Exception("Please choose option from 1 to 3 !");

                        }
                        else
                        {
                            if (userChoice == 3)
                            {
                                UserHelper.Logout(loggedUser);
                            }
                            else
                            {
                                TrainerService.StartTrainerService(userChoice, loggedUser);
                            }

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
            // If Student is logged on
            else if (loggedUser.Student != null)
            {
                while (loggedUser.IsLoggedIn)
                {
                    StudentMenu(loggedUser);

                    try
                    {
                        string userInput = Console.ReadLine();
                        int userChoice = UserHelper.ValidateUserChoice(userInput);

                        if (userChoice < 1 || userChoice > 2)
                        {
                            throw new Exception("Please choose option 1 or 2 !");

                        }
                        else
                        {
                            if (userChoice == 2)
                            {
                                UserHelper.Logout(loggedUser);
                            }
                            else
                            {
                                StudentService.StartStudentService(userChoice, loggedUser);
                            }

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
            else
            {
                Console.WriteLine("Something bad has happend");
            }
        }

        // Admins menu
        public static void AdminMenu(LoggedUser loggedUser)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("======================================");
            Console.WriteLine("    ACADEMY MANAGEMENT APPLICATION");
            Console.WriteLine("======================================");
            Console.WriteLine($"Hello Admin {loggedUser.Admin.FirstName}! Welcome back to AMA!");
            Console.WriteLine("=            ADMINS MENU             =");
            Console.WriteLine("1) Press 1 to add new Admin");
            Console.WriteLine("2) Press 2 to remove existing Admin");
            Console.WriteLine("3) Press 3 to add new Trainer");
            Console.WriteLine("4) Press 4 to remove existing Trainer");
            Console.WriteLine("5) Press 5 to add new Student");
            Console.WriteLine("6) Press 6 to remove existing Student");
            Console.WriteLine("7) Press 7 to Exit");
            Console.ResetColor();
        }

        // Trainers menu
        public static void TrainerMenu(LoggedUser loggedUser)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("======================================");
            Console.WriteLine("    ACADEMY MANAGEMENT APPLICATION");
            Console.WriteLine("======================================");
            Console.WriteLine($"Hello Trainer {loggedUser.Trainer.FirstName}! Welcome back to AMA!");
            Console.WriteLine("=            TRAINERS MENU           =");
            Console.WriteLine("1) Press 1 to see all Students");
            Console.WriteLine("2) Press 2 to see all Subjects");
            Console.WriteLine("3) Press 3 to Exit");
            Console.ResetColor();
        }

        // Students menu
        public static void StudentMenu(LoggedUser loggedUser)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("======================================");
            Console.WriteLine("    ACADEMY MANAGEMENT APPLICATION");
            Console.WriteLine("======================================");
            Console.WriteLine($"Hello Student {loggedUser.Student.FirstName}! Welcome back to AMA!");
            Console.WriteLine("=            STUDENTS MENU           =");
            Console.WriteLine("1) Press 1 to check your grades");
            Console.WriteLine("3) Press 2 to Exit");
            Console.ResetColor();
        }
    }
}
