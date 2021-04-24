using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            LaunchApp();
        }

        public static void LaunchApp()
        {
            while (StoreNumApp())
            {
                Console.Clear();
            }

            AnotherService();
        }

        public static bool StoreNumApp()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("=================");
            Console.WriteLine("STORE NUMBERS APP");
            Console.WriteLine("=================");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Choose where you want to store your numbers:");
            Console.WriteLine("1) Queue");
            Console.WriteLine("2) Stack");
            Console.WriteLine("3) List");
            Console.ResetColor();

            bool checkUserInput = int.TryParse(Console.ReadLine(), out int userInput);

            if (!checkUserInput)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input, please select one of the options!");
                Thread.Sleep(1500);
                Console.ResetColor();
                return true;
            }

            if (userInput < 1 || userInput > 3)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input, please select one of the options!");
                Thread.Sleep(1500);
                Console.ResetColor();
                return true;
            }

            if (userInput == 1)
            {
                AddNumbersToQueue();
            }
                      
            if (userInput == 2)
            {
                AddNumbersToStack();
            }
            
            if (userInput == 3)
            {
                AddNumbersToList();
            }

            return false;
        }

        public static void AddNumbersToQueue()
        {
            Console.Clear();

            Queue<int> queueDB = new Queue<int>();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Please enter a number:");
                Console.ResetColor();
                bool checkNumber = int.TryParse(Console.ReadLine(), out int inputNumber);

                if (!checkNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input, please enter only numbers!");
                    Thread.Sleep(1500);
                    Console.ResetColor();
                    Console.Clear();
                    continue;
                }

                queueDB.Enqueue(inputNumber);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Number {inputNumber} successfully added to the list!");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Do you want to add another number?");
                Console.WriteLine("Type Y if you want to add another number");
                Console.WriteLine("Type N if you want to Main Menu");
                Console.WriteLine("Y/N");
                Console.ResetColor();

                string endChoice = Console.ReadLine();

                if (endChoice.ToUpper() == "Y")
                {
                    Console.Clear();
                    continue;
                }
                else if (endChoice.ToUpper() == "N")
                {
                    PrintDatabaseNumbers(queueDB, "Queue");
                    return;
                }
                else
                {
                    while (true)
                    {
                        Console.Write("Invalid input, please enter Y or N: ");
                        string userChoise = Console.ReadLine();
                        if (userChoise.ToUpper() == "Y")
                        {
                            AddNumbersToQueue();
                            break;
                        }
                        else if (userChoise.ToUpper() == "N")
                        {
                            PrintDatabaseNumbers(queueDB, "Queue");
                            return;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
        }

        public static void AddNumbersToStack()
        {
            Console.Clear();

            Stack<int> stackDB = new Stack<int>();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Please enter a number:");
                Console.ResetColor();
                bool checkNumber = int.TryParse(Console.ReadLine(), out int inputNumber);

                if (!checkNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input, please enter only numbers!");
                    Thread.Sleep(1500);
                    Console.ResetColor();
                    Console.Clear();
                    continue;
                }

                stackDB.Push(inputNumber);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Number {inputNumber} successfully added to the list!");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Do you want to add another number?");
                Console.WriteLine("Type Y if you want to add another number");
                Console.WriteLine("Type N if you want to Main Menu");
                Console.WriteLine("Y/N");
                Console.ResetColor();

                string endChoice = Console.ReadLine();

                if (endChoice.ToUpper() == "Y")
                {
                    Console.Clear();
                    continue;
                }
                else if (endChoice.ToUpper() == "N")
                {
                    PrintDatabaseNumbers(stackDB, "Stack");
                    return;
                }
                else
                {
                    while (true)
                    {
                        Console.Write("Invalid input, please enter Y or N: ");
                        string userChoise = Console.ReadLine();
                        if (userChoise.ToUpper() == "Y")
                        {
                            AddNumbersToStack();
                            break;
                        }
                        else if (userChoise.ToUpper() == "N")
                        {
                            PrintDatabaseNumbers(stackDB, "Stack");
                            return;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
        }

        public static void AddNumbersToList()
        {
            Console.Clear();

            List<int> listDB = new List<int>();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Please enter a number:");
                Console.ResetColor();
                bool checkNumber = int.TryParse(Console.ReadLine(), out int inputNumber);

                if (!checkNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input, please enter only numbers!");
                    Thread.Sleep(1500);
                    Console.ResetColor();
                    Console.Clear();
                }

                listDB.Add(inputNumber);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Number {inputNumber} successfully added to the list!");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Do you want to add another number?");
                Console.WriteLine("Type Y if you want to add another number");
                Console.WriteLine("Type N if you want to Main Menu");
                Console.WriteLine("Y/N");
                Console.ResetColor();

                string endChoice = Console.ReadLine();

                if (endChoice.ToUpper() == "Y")
                {
                    Console.Clear();
                    continue;
                }
                else if (endChoice.ToUpper() == "N")
                {
                    PrintDatabaseNumbers(listDB, "List");
                    break;
                }
                else
                {
                    while (true)
                    {
                        Console.Write("Invalid input, please enter Y or N: ");
                        string userChoise = Console.ReadLine();
                        if (userChoise.ToUpper() == "Y")
                        {
                            AddNumbersToList();
                            break;
                        }
                        else if (userChoise.ToUpper() == "N")
                        {
                            PrintDatabaseNumbers(listDB, "List");
                            return;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
        }

        public static void PrintDatabaseNumbers(IEnumerable collection, string name)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"The numbers in the {name} collection are: ");
            Console.ResetColor();
            foreach (var number in collection)
            {
                Console.WriteLine(number);
            }
        }

        public static void AnotherService()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Do you want to use the STORE NUM APP again or you want to Quit?");
                Console.WriteLine("Press Y if you want to use the app again");
                Console.WriteLine("Press X if you want to Quit");
                Console.WriteLine("Y / X");

                string userChoiseInp = Console.ReadLine();

                if (userChoiseInp.ToUpper() == "Y")
                {
                    LaunchApp();
                    break;
                }
                else if (userChoiseInp.ToUpper() == "X")
                {
                    return;
                }
                else
                {
                    continue;
                }
            }

        }
    }
}
