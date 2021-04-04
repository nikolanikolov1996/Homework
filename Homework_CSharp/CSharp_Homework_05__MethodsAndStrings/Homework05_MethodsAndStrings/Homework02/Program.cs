using System;

namespace Homework02
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter minutes with NUMBERS if you want to convert them in seconds: ");
                bool checkParsedNum = int.TryParse(Console.ReadLine(), out int minInput);

                if (checkParsedNum && minInput >= 0)
                {
                    ConvertToSeconds(minInput);
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter only positive numbers!");
                }
            }
        }
        public static int ConvertToSeconds(int minuteInput)
        {
            int minInSec = 60;
            int convertedMins = minuteInput * minInSec;
            Console.WriteLine($"{minuteInput}min converted in seconds are {convertedMins}s.");
            return convertedMins;
        }
    }
}

