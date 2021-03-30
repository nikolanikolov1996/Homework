using System;

namespace Exercise01_SumOfEven
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

            Console.Write("Please enter integer no.6: ");
            string sixthIntInput = Console.ReadLine();
            int sixthInt;

            bool checkFirstInput = int.TryParse(firstIntInput, out firstInt);
            bool checkSecondInput = int.TryParse(secondIntInput, out secondInt);
            bool checkThirdInput = int.TryParse(thirdIntInput, out thirdInt);
            bool checkFourthInput = int.TryParse(fourthIntInput, out fourthInt);
            bool checkFifthInput = int.TryParse(fifthIntInput, out fifthInt);
            bool checkSixthInput = int.TryParse(sixthIntInput, out sixthInt);



            if (checkFirstInput && checkSecondInput && checkThirdInput && checkFourthInput && checkFifthInput && checkSixthInput)
            {
                int sumOfEven = 0;
                int[] arrayOfInputs = new int[] { firstInt, secondInt, thirdInt, fourthInt, fifthInt, sixthInt };
                foreach (var arrItem in arrayOfInputs)
                {
                    if(arrItem % 2 == 0)
                    {
                        sumOfEven += arrItem;
                    }
                }
                Console.WriteLine("The sum of the even numbers you've entered is: " + sumOfEven);
            }
            else
            {
                Console.WriteLine("You must enter numbers in order the program to work!");
            }

            Console.ReadLine();
        }
    }
}
