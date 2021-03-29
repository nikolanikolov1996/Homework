using System;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the first number: ");
            string firstNumInput = Console.ReadLine();
            int firstNum;

            Console.Write("Please enter the second number: ");
            string secondNumInput = Console.ReadLine();
            int secondNum;

            bool checkFirstInput = int.TryParse(firstNumInput, out firstNum);
            bool checkSecondInput = int.TryParse(secondNumInput, out secondNum);

            int sumOfTwo;

            if (checkFirstInput && checkSecondInput)
            {

                if (firstNum == secondNum)
                {
                    sumOfTwo = firstNum + secondNum;
                    int sumMultiplied3 = sumOfTwo * 3;
                    Console.WriteLine(sumMultiplied3);
                }
                else
                {
                    sumOfTwo = firstNum + secondNum;
                    Console.WriteLine(sumOfTwo);
                }
            }
            else
            {
                Console.WriteLine("Please enter numbers in order to compute their sum!!!");
            }
            Console.ReadLine();
        }
    }
}
