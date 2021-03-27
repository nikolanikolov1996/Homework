using System;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input the first number: ");
            string firstNumberInput = Console.ReadLine();
            int firstNumber;

            Console.Write("Please input the second number: ");
            string secondNumberInput = Console.ReadLine();
            int secondNumber;

            bool checkFirstNumber = int.TryParse(firstNumberInput, out firstNumber);
            bool checkSecondNumber = int.TryParse(secondNumberInput, out secondNumber);

            int swapPlace;
            if (checkFirstNumber && checkSecondNumber)
            {
                swapPlace = firstNumber;
                firstNumber = secondNumber;
                secondNumber = swapPlace;
                Console.WriteLine("First number after swapping: " + firstNumber);
                Console.WriteLine("Second number after swapping: " + secondNumber);
            }
            else
            {
                Console.WriteLine("Please enter only numbers!");
            }

            Console.ReadLine();
        }
    }
}
