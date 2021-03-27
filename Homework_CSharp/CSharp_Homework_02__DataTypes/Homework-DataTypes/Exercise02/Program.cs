using System;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            string firstNumInput = Console.ReadLine();
            double firstNum;

            Console.Write("Enter the second number: ");
            string secondNumInput = Console.ReadLine();
            double secondNum;

            Console.Write("Enter the third number: ");
            string thirdNumInput = Console.ReadLine();
            double thirdNum;

            Console.Write("Enter the fourth number: ");
            string fourthNumInput = Console.ReadLine();
            double fourthNum;

            bool checkFirstNum = double.TryParse(firstNumInput, out firstNum);
            bool checkSecondNum = double.TryParse(secondNumInput, out secondNum);
            bool checkThirdNum = double.TryParse(thirdNumInput, out thirdNum);
            bool checkFourthNum = double.TryParse(fourthNumInput, out fourthNum);

            double averageResult;

            if (checkFirstNum && checkSecondNum && checkThirdNum && checkFourthNum)
            {
                averageResult = (firstNum + secondNum + thirdNum + fourthNum) / 4;
                Console.WriteLine("The average of " + firstNum + ", " + secondNum + ", " + thirdNum + " and " + fourthNum + " is: " + averageResult);
            }
            else
            {
                Console.WriteLine("You must enter numbers if you want to calculate the average!");
            }

            Console.ReadLine();
        }
    }
}
