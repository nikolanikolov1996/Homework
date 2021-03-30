using System;

namespace ClassExercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter integer no.1: ");
            string firstIntInput = Console.ReadLine();
            int firstInt;

            Console.Write("Please enter integer no.2: ");
            string secondIntInput = Console.ReadLine();
            int secondInt;

            Console.Write("Please enter integer no.3: ");
            string thirdIntInput = Console.ReadLine();
            int thirdInt;

            Console.Write("Please enter integer no.4: ");
            string fourthIntInput = Console.ReadLine();
            int fourthInt;

            Console.Write("Please enter integer no.5: ");
            string fifthIntInput = Console.ReadLine();
            int fifthInt;

            bool checkFirstInput = int.TryParse(firstIntInput, out firstInt);
            bool checkSecondInput = int.TryParse(secondIntInput, out secondInt);
            bool checkThirdInput = int.TryParse(thirdIntInput, out thirdInt);
            bool checkFourthInput = int.TryParse(fourthIntInput, out fourthInt);
            bool checkFifthInput = int.TryParse(fifthIntInput, out fifthInt);

            if (checkFirstInput && checkSecondInput && checkThirdInput && checkFourthInput && checkFifthInput)
            {
                int sumOfArrItems = 0;
                int[] arrayOfInputs = new int[] { firstInt, secondInt, thirdInt, fourthInt, fifthInt };
                for (int i = 0; i < arrayOfInputs.Length; i++)
                {
                    sumOfArrItems += arrayOfInputs[i];
                }
                Console.WriteLine("The result of the numbers you've entered is: " + sumOfArrItems);
            }
            else
            {
                Console.WriteLine("Please enter numbers!!!");
            }

            Console.ReadLine();
        }
    }
}
