using System;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the temperature in Celsius expressed in numbers: ");
            string tempInput = Console.ReadLine();
            double temperature;

            bool checkTempInput = double.TryParse(tempInput, out temperature);

            if(checkTempInput)
            {
                if(temperature < 0)
                {
                    Console.WriteLine("It's freezing weather!");
                }
                else if(temperature >= 0 && temperature < 10)
                {
                    Console.WriteLine("It's very cold weather!");
                }
                else if(temperature >= 10 && temperature <20)
                {
                    Console.WriteLine("It's cold weather!");
                }
                else if (temperature >= 20 && temperature < 30)
                {
                    Console.WriteLine("It's normal in Temp!");
                }
                else if (temperature >= 30 && temperature < 40)
                {
                    Console.WriteLine("It's hot weather!");
                }
                else if (temperature >= 40)
                {
                    Console.WriteLine("It's very hot weather!");
                }
                else
                {
                    Console.WriteLine("Something went wrong. Please try again!");
                }
            }
            else
            {
                Console.WriteLine("You must enter celsius expressed in numbers in order to continue!");
            }
            Console.ReadLine();
        }
    }
}
