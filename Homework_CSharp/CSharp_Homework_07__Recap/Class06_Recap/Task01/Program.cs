using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter a number: ");
                bool checkNumber = double.TryParse(Console.ReadLine(), out double parsedNumber);

                if (checkNumber)
                {
                    NumberStats(parsedNumber);
                    Console.Write("Press Y if you want to TRY AGAIN or X if you want to EXIT: ");
                    string userOpinion = Console.ReadLine();
                    if(userOpinion.ToLower() == "y")
                    {
                        continue;
                    }
                    else if(userOpinion.ToLower() == "x")
                    {
                        break;
                    }
                    else
                    {
                        while (true)
                        {
                            Console.Write("Wrong input, please enter Y or X !!!");
                            string userChoise = Console.ReadLine();
                            if (userChoise.ToLower() == "y")
                            {
                                break;
                            }
                            else if (userChoise.ToLower() == "x")
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
                else
                {
                    Console.WriteLine("Please enter number!");
                }
            }
        }
        public static void NumberStats(double number)
        {
            if (number > 0)
            {
                Console.WriteLine("Positive");
            }
            else
            {
                Console.WriteLine("Negative");
            }

            if (number % 1 != 0)
            {
                Console.WriteLine("Decimal");
            }
            else
            {
                Console.WriteLine("Integer");
            }

            if (number % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }
}
