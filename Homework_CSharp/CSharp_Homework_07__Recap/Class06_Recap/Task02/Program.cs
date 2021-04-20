using System;
using Task02.Classes;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            UserOpinion();
        }

        public static void UserOpinion()
        {
            Console.WriteLine(" ------------------------");
            Console.WriteLine("|    User Application    |");
            Console.WriteLine("|                        |");
            Console.WriteLine("|       1. Log in        |");
            Console.WriteLine("|       2. Register      |");
            Console.WriteLine("|                        |");
            Console.WriteLine(" ------------------------\n");
            Console.Write("Please enter your option: ");

            bool checkUserInput = int.TryParse(Console.ReadLine(), out int checkedNumber);
            if (checkUserInput)
            {
                if (checkedNumber == 1)
                {
                    LogIn();
                }
                else if (checkedNumber == 2)
                {
                    Register();
                }
                else
                {
                    Console.WriteLine("Wrong input! Please select option 1 or 2 !!!");
                }
            }
        }

        public static void LogIn()
        {
            Console.Clear();
            Console.WriteLine(" ---------------------------------------");
            Console.WriteLine("|           User Application            |");
            Console.WriteLine("|                                       |");
            Console.Write("|  1. Please enter your username: ");
            string userNameInp = Console.ReadLine();
            Console.Write("|  2. Please enter your password: ");
            string passwordInp = Console.ReadLine();
            Console.WriteLine("|                                       |");
            Console.WriteLine(" ---------------------------------------\n");
            ValidateLogIn(userNameInp, passwordInp);
        }

        public static void Register()
        {
            Console.Clear();
            Console.WriteLine(" ---------------------------------------");
            Console.WriteLine("|           User Application            |");
            Console.WriteLine("|                                       |");
            Console.Write("|  1. Please enter ID: ");
            int userIdReg = int.Parse(Console.ReadLine());
            Console.Write("|  2. Please enter username: ");
            string userNameReg = Console.ReadLine();
            Console.Write("|  3. Please enter password: ");
            string passwordReg = Console.ReadLine();
            Console.WriteLine("|                                       |");
            Console.WriteLine(" ---------------------------------------\n");
            ValidateRegister(userIdReg, userNameReg, passwordReg);
        }

        public static void ValidateLogIn(string username, string password)
        {
            User[] arrayOfUsers = new User[3]
            {
                new User(1, "Bob", "bob123"),
                new User(2, "John", "john123"),
                new User(3, "Tom", "tom123")
            };

            foreach (var user in arrayOfUsers)
            {
                if (user.Username == username && user.Password == password)
                {
                    Console.WriteLine($"Welcome {user.Username}. Here are your messages: ");
                    displayMessages(user.Messages);
                    return;
                }
            }
            Console.WriteLine($"User: {username} with password {password} not found. Please try again!\nIf you are new user please go and Register!");
        }

        public static void ValidateRegister(int id, string username, string password)
        {
            User[] arrayOfUsers = new User[3]
            {
                new User(1, "Bob", "bob123"),
                new User(2, "John", "john123"),
                new User(3, "Tom", "tom123")
            };

            for (int i = 0; i < arrayOfUsers.Length; i++)
            {
                if (arrayOfUsers[i].Username == username)
                {
                    Console.WriteLine($"There is already a user called {arrayOfUsers[i].Username}. Please try new username!");
                    Console.WriteLine("Registration incomplete!");
                    break;
                }
                else
                {
                    Array.Resize(ref arrayOfUsers, arrayOfUsers.Length + 1);
                    arrayOfUsers[arrayOfUsers.Length - 1] = new User(id, username, password);
                    displayUsers(arrayOfUsers);
                    Console.WriteLine("Registration complete!");
                    return;
                }
            }
        }

        public static void displayMessages(string[] messagesArr)
        {
            foreach (var message in messagesArr)
            {
                Console.WriteLine(message);
            }
        }

        public static void displayUsers(User[] arrOfUsers)
        {
            foreach (var user in arrOfUsers)
            {
                Console.WriteLine($"User ID: {user.Id} Username: {user.Username}");
            }
        }
    }
}
