using System;

namespace Homework01
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter your age if you want to convert your years to days: ");
                bool checkParsedNumber = int.TryParse(Console.ReadLine(), out int ageInput);

                if (checkParsedNumber && ageInput >= 0)
                {
                    CalcAge(ageInput);
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter age written with numbers,ONLY positive numbers!");
                };
            }
        }
        public static int CalcAge(int ageNumber)
        {
            int daysOfYear = 365;
            int yearsToDays = ageNumber * daysOfYear;
            Console.WriteLine($"Your {ageNumber} years converted in days are {yearsToDays}.");
            return yearsToDays;
        }
    }
}
