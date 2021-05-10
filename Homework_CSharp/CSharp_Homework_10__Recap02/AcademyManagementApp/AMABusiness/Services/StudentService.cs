using AMABusiness.ServiceModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AMABusiness.Services
{
    public class StudentService
    {
        // Start student service
        public static void StartStudentService(int userChoice, LoggedUser loggedUser)
        {
            if(userChoice == 1)
            {
                SubjectHelper.PrintListOfSubjectAndGrades(loggedUser);
            }
            else
            {
                throw new Exception("Wrong input. Please select option 1!");
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
    }
}
