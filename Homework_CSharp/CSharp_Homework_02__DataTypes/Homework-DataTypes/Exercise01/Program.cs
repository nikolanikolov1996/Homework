using System;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            string firstNumInput = Console.ReadLine();
            int firstNum;

            Console.Write("Enter the second number: ");
            string secondNumInput = Console.ReadLine();
            int secondNum;

            bool checkFirstNum = int.TryParse(firstNumInput, out firstNum);
            bool checkSecondNum = int.TryParse(secondNumInput, out secondNum);

            Console.Write("Select the Operation, posible '+', '-', '*', '/' : ");
            string operatorSign = Console.ReadLine();
            int operationResult;

            if (checkFirstNum && checkSecondNum)
            {
                switch (operatorSign)
                {
                    case "+":
                        operationResult = firstNum + secondNum;
                        Console.WriteLine("The result is: " + operationResult);
                        break;
                    case "-":
                        operationResult = firstNum - secondNum;
                        Console.WriteLine("The result is: " + operationResult);
                        break;
                    case "*":
                        operationResult = firstNum * secondNum;
                        Console.WriteLine("The result is: " + operationResult);
                        break;
                    case "/":
                        operationResult = firstNum / secondNum;
                        Console.WriteLine("The result is: " + operationResult);
                        break;
                    default:
                        Console.WriteLine("Something went wrong! Please try again!");
                        break;

                }
            }
            else
            {
                Console.WriteLine("You must enter numbers in the calculator!");
            }

            Console.ReadLine();
        }
    }
}
