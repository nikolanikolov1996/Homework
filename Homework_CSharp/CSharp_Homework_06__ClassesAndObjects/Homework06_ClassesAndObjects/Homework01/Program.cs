using System;
using Homework01.Classes;

namespace Homework01
{
    class Program
    {
        static void Main(string[] args)
        {
            GameSolution();
        }
        // [ RaceCars Method ]
        public static void RaceCars(Car firstCar, Car secondCar)
        {
            if (firstCar.CalculateSpeed() > secondCar.CalculateSpeed())
            {
                Console.WriteLine($"Car no.1 model {firstCar.Model} whose driver was {firstCar.Driver.Name} was driving with speed of {firstCar.CalculateSpeed()}km/h and won the race.");
            }
            else
            {
                Console.WriteLine($"Car no.2 model {secondCar.Model} whose driver was {secondCar.Driver.Name} was driving with speed of {secondCar.CalculateSpeed()}km/h and won the race.");
            }
        }
        // GameSolution
        public static void GameSolution()
        {
            while (true)
            {
                Console.WriteLine("Choose car no.1: " +
                    "\n*If you want to choose Hyundai please enter 1 " +
                    "\n*If you want to choose Mazda please enter 2 " +
                    "\n*If you want to choose Ferrari please enter 3 " +
                    "\n*If you want to choose Porsche please enter 4");
                bool checkCarInput01 = int.TryParse(Console.ReadLine(), out int carInput01);

                Console.WriteLine("Choose driver no.1: " +
                    "\n*If you want to choose Bob please enter 1 " +
                    "\n*If you want to choose Greg please enter 2 " +
                    "\n*If you want to choose Jill please enter 3 " +
                    "\n*If you want to choose Anne please enter 4");
                bool checkDriverInput01 = int.TryParse(Console.ReadLine(), out int driverInput01);

                Console.WriteLine("Choose car no.2: " +
                    "\n*If you want to choose Hyundai please enter 1 " +
                    "\n*If you want to choose Mazda please enter 2 " +
                    "\n*If you want to choose Ferrari please enter 3 " +
                    "\n*If you want to choose Porsche please enter 4");
                bool checkCarInput02 = int.TryParse(Console.ReadLine(), out int carInput02);

                Console.WriteLine($"Choose driver no.2: " +
                    $"\n*If you want to choose Bob please enter 1 " +
                    $"\n*If you want to choose Greg please enter 2 " +
                    $"\n*If you want to choose Jill please enter 3 " +
                    $"\n*If you want to choose Anne please enter 4");
                bool checkDriverInput02 = int.TryParse(Console.ReadLine(), out int driverInput02);


                if (checkCarInput01 && checkCarInput02 && checkDriverInput01 && checkDriverInput02)
                {
                    PlayAGame(carInput01, driverInput01, carInput02, driverInput02);
                    Console.WriteLine("Do you want to race again? enter Y/N: ");
                    string userAnswer = Console.ReadLine();
                    if (userAnswer.ToLower() == "y")
                    {
                        continue;
                    }
                    else if (userAnswer.ToLower() == "n")
                    {
                        break;
                    }
                    else
                    {
                        while (true)
                        {
                            Console.Write("Wrong input, please enter Y or N !!!");
                            string userChoise = Console.ReadLine();
                            if (userChoise.ToLower() == "y")
                            {
                                break;
                            }
                            else if (userChoise.ToLower() == "n")
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
                    Console.WriteLine("Please select one of the options below!");
                }
            }
        }
        // PlayAGame
        public static void PlayAGame(int carInput01, int driverInput01, int carInput02, int driverInput02)
        {
            // [ Driver objects ]
            Driver driver01 = new Driver("Bob", 100);
            Driver driver02 = new Driver("Greg", 95);
            Driver driver03 = new Driver("Jill", 90);
            Driver driver04 = new Driver("Anne", 85);

            // Combinations starting with 1
            // [ 1 - 1 ]
            if (carInput01 == 1 && driverInput01 == 1 && carInput02 == 2 && driverInput02 == 2)
            {
                Car car01 = new Car("Hyundai", 310, driver01);
                Car car02 = new Car("Mazda", 320, driver02);
                RaceCars(car01, car02);
            }
            else if (carInput01 == 1 && driverInput01 == 1 && carInput02 == 2 && driverInput02 == 3)
            {
                Car car01 = new Car("Hyundai", 310, driver01);
                Car car02 = new Car("Mazda", 320, driver03);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 1 && driverInput01 == 1 && carInput02 == 2 && driverInput02 == 4)
            {
                Car car01 = new Car("Hyundai", 310, driver01);
                Car car02 = new Car("Mazda", 320, driver04);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 1 && driverInput01 == 1 && carInput02 == 3 && driverInput02 == 2)
            {
                Car car01 = new Car("Hyundai", 310, driver01);
                Car car02 = new Car("Ferrari", 350, driver02);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 1 && driverInput01 == 1 && carInput02 == 3 && driverInput02 == 3)
            {
                Car car01 = new Car("Hyundai", 310, driver01);
                Car car02 = new Car("Ferrari", 350, driver03);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 1 && driverInput01 == 1 && carInput02 == 3 && driverInput02 == 4)
            {
                Car car01 = new Car("Hyundai", 310, driver01);
                Car car02 = new Car("Ferrari", 350, driver04);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 1 && driverInput01 == 1 && carInput02 == 4 && driverInput02 == 2)
            {
                Car car01 = new Car("Hyundai", 310, driver01);
                Car car02 = new Car("Porsche", 340, driver02);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 1 && driverInput01 == 1 && carInput02 == 4 && driverInput02 == 3)
            {
                Car car01 = new Car("Hyundai", 310, driver01);
                Car car02 = new Car("Porsche", 340, driver03);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 1 && driverInput01 == 1 && carInput02 == 4 && driverInput02 == 4)
            {
                Car car01 = new Car("Hyundai", 310, driver01);
                Car car02 = new Car("Porsche", 340, driver04);
                RaceCars(car01, car02);

            }
            // [ 1 - 2 ]
            else if (carInput01 == 1 && driverInput01 == 2 && carInput02 == 2 && driverInput02 == 1)
            {
                Car car01 = new Car("Hyundai", 310, driver02);
                Car car02 = new Car("Mazda", 320, driver01);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 1 && driverInput01 == 2 && carInput02 == 2 && driverInput02 == 3)
            {
                Car car01 = new Car("Hyundai", 310, driver02);
                Car car02 = new Car("Mazda", 320, driver03);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 1 && driverInput01 == 2 && carInput02 == 2 && driverInput02 == 4)
            {
                Car car01 = new Car("Hyundai", 310, driver02);
                Car car02 = new Car("Mazda", 320, driver04);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 1 && driverInput01 == 2 && carInput02 == 3 && driverInput02 == 1)
            {
                Car car01 = new Car("Hyundai", 310, driver02);
                Car car02 = new Car("Ferrari", 350, driver01);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 1 && driverInput01 == 2 && carInput02 == 3 && driverInput02 == 3)
            {
                Car car01 = new Car("Hyundai", 310, driver02);
                Car car02 = new Car("Ferrari", 350, driver03);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 1 && driverInput01 == 2 && carInput02 == 3 && driverInput02 == 4)
            {
                Car car01 = new Car("Hyundai", 310, driver02);
                Car car02 = new Car("Ferrari", 350, driver04);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 1 && driverInput01 == 2 && carInput02 == 4 && driverInput02 == 1)
            {
                Car car02 = new Car("Hyundai", 310, driver02);
                Car car01 = new Car("Porsche", 340, driver01);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 1 && driverInput01 == 2 && carInput02 == 4 && driverInput02 == 3)
            {
                Car car02 = new Car("Hyundai", 310, driver02);
                Car car01 = new Car("Porsche", 340, driver03);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 1 && driverInput01 == 2 && carInput02 == 4 && driverInput02 == 4)
            {
                Car car01 = new Car("Hyundai", 310, driver02);
                Car car02 = new Car("Porsche", 340, driver04);
                RaceCars(car01, car02);

            }
            // [ 1 - 3 ]
            else if (carInput01 == 1 && driverInput01 == 3 && carInput02 == 2 && driverInput02 == 1)
            {
                Car car01 = new Car("Hyundai", 310, driver03);
                Car car02 = new Car("Mazda", 320, driver01);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 1 && driverInput01 == 3 && carInput02 == 2 && driverInput02 == 2)
            {
                Car car01 = new Car("Hyundai", 310, driver03);
                Car car02 = new Car("Mazda", 320, driver02);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 1 && driverInput01 == 3 && carInput02 == 2 && driverInput02 == 4)
            {
                Car car02 = new Car("Hyundai", 310, driver03);
                Car car01 = new Car("Mazda", 320, driver04);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 1 && driverInput01 == 3 && carInput02 == 3 && driverInput02 == 1)
            {
                Car car02 = new Car("Hyundai", 310, driver03);
                Car car01 = new Car("Ferrari", 350, driver01);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 1 && driverInput01 == 3 && carInput02 == 3 && driverInput02 == 2)
            {
                Car car01 = new Car("Hyundai", 310, driver03);
                Car car02 = new Car("Ferrari", 350, driver02);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 1 && driverInput01 == 3 && carInput02 == 3 && driverInput02 == 4)
            {
                Car car02 = new Car("Hyundai", 310, driver03);
                Car car01 = new Car("Ferrari", 350, driver04);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 1 && driverInput01 == 3 && carInput02 == 4 && driverInput02 == 1)
            {
                Car car01 = new Car("Hyundai", 310, driver03);
                Car car02 = new Car("Porsche", 340, driver01);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 1 && driverInput01 == 3 && carInput02 == 4 && driverInput02 == 2)
            {
                Car car01 = new Car("Hyundai", 310, driver03);
                Car car02 = new Car("Porsche", 340, driver02);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 1 && driverInput01 == 3 && carInput02 == 4 && driverInput02 == 4)
            {
                Car car01 = new Car("Hyundai", 310, driver03);
                Car car02 = new Car("Porsche", 340, driver04);
                RaceCars(car01, car02);

            }
            // [ 1 - 4 ]
            else if (carInput01 == 1 && driverInput01 == 4 && carInput02 == 2 && driverInput02 == 1)
            {
                Car car01 = new Car("Hyundai", 310, driver04);
                Car car02 = new Car("Mazda", 320, driver01);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 1 && driverInput01 == 4 && carInput02 == 2 && driverInput02 == 2)
            {
                Car car01 = new Car("Hyundai", 310, driver04);
                Car car02 = new Car("Mazda", 320, driver02);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 1 && driverInput01 == 4 && carInput02 == 2 && driverInput02 == 3)
            {
                Car car01 = new Car("Hyundai", 310, driver04);
                Car car02 = new Car("Mazda", 320, driver03);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 1 && driverInput01 == 4 && carInput02 == 3 && driverInput02 == 1)
            {
                Car car01 = new Car("Hyundai", 310, driver04);
                Car car02 = new Car("Ferrari", 350, driver01);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 1 && driverInput01 == 4 && carInput02 == 3 && driverInput02 == 2)
            {
                Car car01 = new Car("Hyundai", 310, driver04);
                Car car02 = new Car("Ferrari", 350, driver02);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 1 && driverInput01 == 4 && carInput02 == 3 && driverInput02 == 3)
            {
                Car car01 = new Car("Hyundai", 310, driver04);
                Car car02 = new Car("Ferrari", 350, driver03);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 1 && driverInput01 == 4 && carInput02 == 4 && driverInput02 == 1)
            {
                Car car01 = new Car("Hyundai", 310, driver04);
                Car car02 = new Car("Porsche", 340, driver01);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 1 && driverInput01 == 4 && carInput02 == 4 && driverInput02 == 2)
            {
                Car car01 = new Car("Hyundai", 310, driver04);
                Car car02 = new Car("Porsche", 340, driver02);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 1 && driverInput01 == 4 && carInput02 == 4 && driverInput02 == 3)
            {
                Car car01 = new Car("Hyundai", 310, driver04);
                Car car02 = new Car("Porsche", 340, driver03);
                RaceCars(car01, car02);

            }
            // [ Combinations starting with 2 ]
            // [ 2 - 1 ]
            else if (carInput01 == 2 && driverInput01 == 1 && carInput02 == 1 && driverInput02 == 2)
            {
                Car car01 = new Car("Mazda", 320, driver01);
                Car car02 = new Car("Hyundai", 310, driver02);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 2 && driverInput01 == 1 && carInput02 == 1 && driverInput02 == 3)
            {
                Car car01 = new Car("Mazda", 320, driver01);
                Car car02 = new Car("Hyundai", 310, driver03);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 2 && driverInput01 == 1 && carInput02 == 1 && driverInput02 == 4)
            {
                Car car01 = new Car("Mazda", 320, driver01);
                Car car02 = new Car("Hyundai", 310, driver04);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 2 && driverInput01 == 1 && carInput02 == 3 && driverInput02 == 2)
            {
                Car car01 = new Car("Mazda", 320, driver01);
                Car car02 = new Car("Ferrari", 350, driver02);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 2 && driverInput01 == 1 && carInput02 == 3 && driverInput02 == 3)
            {
                Car car01 = new Car("Mazda", 320, driver01);
                Car car02 = new Car("Ferrari", 350, driver03);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 2 && driverInput01 == 1 && carInput02 == 3 && driverInput02 == 4)
            {
                Car car01 = new Car("Mazda", 320, driver01);
                Car car02 = new Car("Ferrari", 350, driver04);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 2 && driverInput01 == 1 && carInput02 == 4 && driverInput02 == 2)
            {
                Car car01 = new Car("Mazda", 320, driver01);
                Car car02 = new Car("Porsche", 340, driver02);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 2 && driverInput01 == 1 && carInput02 == 4 && driverInput02 == 3)
            {
                Car car01 = new Car("Mazda", 320, driver01);
                Car car02 = new Car("Porsche", 340, driver03);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 2 && driverInput01 == 1 && carInput02 == 4 && driverInput02 == 4)
            {
                Car car01 = new Car("Mazda", 320, driver01);
                Car car02 = new Car("Porsche", 340, driver04);
                RaceCars(car01, car02);

            }
            // [ 2 - 2 ]
            else if (carInput01 == 2 && driverInput01 == 2 && carInput02 == 1 && driverInput02 == 1)
            {
                Car car01 = new Car("Mazda", 320, driver02);
                Car car02 = new Car("Hyundai", 310, driver01);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 2 && driverInput01 == 2 && carInput02 == 1 && driverInput02 == 3)
            {
                Car car01 = new Car("Mazda", 320, driver02);
                Car car02 = new Car("Hyundai", 310, driver03);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 2 && driverInput01 == 2 && carInput02 == 1 && driverInput02 == 4)
            {
                Car car01 = new Car("Mazda", 320, driver02);
                Car car02 = new Car("Hyundai", 310, driver04);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 2 && driverInput01 == 2 && carInput02 == 3 && driverInput02 == 1)
            {
                Car car01 = new Car("Mazda", 320, driver02);
                Car car02 = new Car("Ferrari", 350, driver01);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 2 && driverInput01 == 2 && carInput02 == 3 && driverInput02 == 3)
            {
                Car car01 = new Car("Mazda", 320, driver02);
                Car car02 = new Car("Ferrari", 350, driver03);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 2 && driverInput01 == 2 && carInput02 == 3 && driverInput02 == 4)
            {
                Car car01 = new Car("Mazda", 320, driver02);
                Car car02 = new Car("Ferrari", 350, driver04);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 2 && driverInput01 == 2 && carInput02 == 4 && driverInput02 == 1)
            {
                Car car01 = new Car("Mazda", 320, driver02);
                Car car02 = new Car("Porsche", 340, driver01);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 2 && driverInput01 == 2 && carInput02 == 4 && driverInput02 == 3)
            {
                Car car01 = new Car("Mazda", 320, driver02);
                Car car02 = new Car("Porsche", 340, driver03);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 2 && driverInput01 == 2 && carInput02 == 4 && driverInput02 == 4)
            {
                Car car01 = new Car("Mazda", 320, driver02);
                Car car02 = new Car("Porsche", 340, driver04);
                RaceCars(car01, car02);

            }
            // [ 2 - 3 ]
            else if (carInput01 == 2 && driverInput01 == 3 && carInput02 == 1 && driverInput02 == 1)
            {
                Car car01 = new Car("Mazda", 320, driver03);
                Car car02 = new Car("Hyundai", 310, driver01);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 2 && driverInput01 == 3 && carInput02 == 1 && driverInput02 == 2)
            {
                Car car01 = new Car("Mazda", 320, driver03);
                Car car02 = new Car("Hyundai", 310, driver02);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 2 && driverInput01 == 3 && carInput02 == 1 && driverInput02 == 4)
            {
                Car car01 = new Car("Mazda", 320, driver03);
                Car car02 = new Car("Hyundai", 310, driver04);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 2 && driverInput01 == 3 && carInput02 == 3 && driverInput02 == 1)
            {
                Car car01 = new Car("Mazda", 320, driver03);
                Car car02 = new Car("Ferrari", 350, driver01);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 2 && driverInput01 == 3 && carInput02 == 3 && driverInput02 == 2)
            {
                Car car01 = new Car("Mazda", 320, driver03);
                Car car02 = new Car("Ferrari", 350, driver02);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 2 && driverInput01 == 3 && carInput02 == 3 && driverInput02 == 4)
            {
                Car car01 = new Car("Mazda", 320, driver03);
                Car car02 = new Car("Ferrari", 350, driver04);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 2 && driverInput01 == 3 && carInput02 == 4 && driverInput02 == 1)
            {
                Car car01 = new Car("Mazda", 320, driver03);
                Car car02 = new Car("Porsche", 340, driver01);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 2 && driverInput01 == 3 && carInput02 == 4 && driverInput02 == 2)
            {
                Car car01 = new Car("Mazda", 320, driver03);
                Car car02 = new Car("Porsche", 340, driver02);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 2 && driverInput01 == 3 && carInput02 == 4 && driverInput02 == 4)
            {
                Car car01 = new Car("Mazda", 320, driver03);
                Car car02 = new Car("Porsche", 340, driver04);
                RaceCars(car01, car02);

            }
            // [ 2 - 4 ]
            else if (carInput01 == 2 && driverInput01 == 4 && carInput02 == 1 && driverInput02 == 1)
            {
                Car car01 = new Car("Mazda", 320, driver04);
                Car car02 = new Car("Hyundai", 310, driver01);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 2 && driverInput01 == 4 && carInput02 == 1 && driverInput02 == 2)
            {
                Car car01 = new Car("Mazda", 320, driver04);
                Car car02 = new Car("Hyundai", 310, driver02);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 2 && driverInput01 == 4 && carInput02 == 1 && driverInput02 == 3)
            {
                Car car01 = new Car("Mazda", 320, driver04);
                Car car02 = new Car("Hyundai", 310, driver03);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 2 && driverInput01 == 4 && carInput02 == 3 && driverInput02 == 1)
            {
                Car car01 = new Car("Mazda", 320, driver04);
                Car car02 = new Car("Ferrari", 350, driver01);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 2 && driverInput01 == 4 && carInput02 == 3 && driverInput02 == 2)
            {
                Car car01 = new Car("Mazda", 320, driver04);
                Car car02 = new Car("Ferrari", 350, driver02);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 2 && driverInput01 == 4 && carInput02 == 3 && driverInput02 == 3)
            {
                Car car01 = new Car("Mazda", 320, driver04);
                Car car02 = new Car("Ferrari", 350, driver03);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 2 && driverInput01 == 4 && carInput02 == 4 && driverInput02 == 1)
            {
                Car car01 = new Car("Mazda", 320, driver04);
                Car car02 = new Car("Porsche", 340, driver01);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 2 && driverInput01 == 4 && carInput02 == 4 && driverInput02 == 2)
            {
                Car car01 = new Car("Mazda", 320, driver04);
                Car car02 = new Car("Porsche", 340, driver02);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 2 && driverInput01 == 4 && carInput02 == 4 && driverInput02 == 3)
            {
                Car car01 = new Car("Mazda", 320, driver04);
                Car car02 = new Car("Porsche", 340, driver03);
                RaceCars(car01, car02);

            }
            // [ Combinations starting with 3 ]
            // [ 3 - 1 ]
            else if (carInput01 == 3 && driverInput01 == 1 && carInput02 == 1 && driverInput02 == 2)
            {
                Car car01 = new Car("Ferrari", 350, driver01);
                Car car02 = new Car("Hyundai", 310, driver02);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 3 && driverInput01 == 1 && carInput02 == 1 && driverInput02 == 3)
            {
                Car car01 = new Car("Ferrari", 350, driver01);
                Car car02 = new Car("Hyundai", 310, driver03);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 3 && driverInput01 == 1 && carInput02 == 1 && driverInput02 == 4)
            {
                Car car01 = new Car("Ferrari", 350, driver01);
                Car car02 = new Car("Hyundai", 310, driver04);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 3 && driverInput01 == 1 && carInput02 == 2 && driverInput02 == 2)
            {
                Car car01 = new Car("Ferrari", 350, driver01);
                Car car02 = new Car("Mazda", 320, driver02);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 3 && driverInput01 == 1 && carInput02 == 2 && driverInput02 == 3)
            {
                Car car01 = new Car("Ferrari", 350, driver01);
                Car car02 = new Car("Mazda", 320, driver03);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 3 && driverInput01 == 1 && carInput02 == 2 && driverInput02 == 4)
            {
                Car car01 = new Car("Ferrari", 350, driver01);
                Car car02 = new Car("Mazda", 320, driver04);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 3 && driverInput01 == 1 && carInput02 == 4 && driverInput02 == 2)
            {
                Car car01 = new Car("Ferrari", 350, driver01);
                Car car02 = new Car("Porsche", 340, driver02);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 3 && driverInput01 == 1 && carInput02 == 4 && driverInput02 == 3)
            {
                Car car01 = new Car("Ferrari", 350, driver01);
                Car car02 = new Car("Porsche", 340, driver03);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 3 && driverInput01 == 1 && carInput02 == 4 && driverInput02 == 4)
            {
                Car car01 = new Car("Ferrari", 350, driver01);
                Car car02 = new Car("Porsche", 340, driver04);
                RaceCars(car01, car02);

            }
            // [ 3 - 2 ]
            else if (carInput01 == 3 && driverInput01 == 2 && carInput02 == 1 && driverInput02 == 1)
            {
                Car car01 = new Car("Ferrari", 350, driver02);
                Car car02 = new Car("Hyundai", 310, driver01);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 3 && driverInput01 == 2 && carInput02 == 1 && driverInput02 == 3)
            {
                Car car01 = new Car("Ferrari", 350, driver02);
                Car car02 = new Car("Hyundai", 310, driver03);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 3 && driverInput01 == 2 && carInput02 == 1 && driverInput02 == 4)
            {
                Car car01 = new Car("Ferrari", 350, driver02);
                Car car02 = new Car("Hyundai", 310, driver04);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 3 && driverInput01 == 2 && carInput02 == 2 && driverInput02 == 1)
            {
                Car car01 = new Car("Ferrari", 350, driver02);
                Car car02 = new Car("Mazda", 320, driver01);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 3 && driverInput01 == 2 && carInput02 == 2 && driverInput02 == 3)
            {
                Car car01 = new Car("Ferrari", 350, driver02);
                Car car02 = new Car("Mazda", 320, driver03);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 3 && driverInput01 == 2 && carInput02 == 2 && driverInput02 == 4)
            {
                Car car01 = new Car("Ferrari", 350, driver02);
                Car car02 = new Car("Mazda", 320, driver04);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 3 && driverInput01 == 2 && carInput02 == 4 && driverInput02 == 1)
            {
                Car car01 = new Car("Ferrari", 350, driver02);
                Car car02 = new Car("Porsche", 340, driver01);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 3 && driverInput01 == 2 && carInput02 == 4 && driverInput02 == 3)
            {
                Car car01 = new Car("Ferrari", 350, driver02);
                Car car02 = new Car("Porsche", 340, driver03);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 3 && driverInput01 == 2 && carInput02 == 4 && driverInput02 == 4)
            {
                Car car01 = new Car("Ferrari", 350, driver02);
                Car car02 = new Car("Porsche", 340, driver04);
                RaceCars(car01, car02);

            }
            // [ 3 - 3 ]
            else if (carInput01 == 3 && driverInput01 == 3 && carInput02 == 1 && driverInput02 == 1)
            {
                Car car01 = new Car("Ferrari", 350, driver03);
                Car car02 = new Car("Hyundai", 310, driver01);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 3 && driverInput01 == 3 && carInput02 == 1 && driverInput02 == 2)
            {
                Car car01 = new Car("Ferrari", 350, driver03);
                Car car02 = new Car("Hyundai", 310, driver02);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 3 && driverInput01 == 3 && carInput02 == 1 && driverInput02 == 4)
            {
                Car car01 = new Car("Ferrari", 350, driver03);
                Car car02 = new Car("Hyundai", 310, driver04);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 3 && driverInput01 == 3 && carInput02 == 2 && driverInput02 == 1)
            {
                Car car01 = new Car("Ferrari", 350, driver03);
                Car car02 = new Car("Mazda", 320, driver01);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 3 && driverInput01 == 3 && carInput02 == 2 && driverInput02 == 2)
            {
                Car car01 = new Car("Ferrari", 350, driver03);
                Car car02 = new Car("Mazda", 320, driver02);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 3 && driverInput01 == 3 && carInput02 == 2 && driverInput02 == 4)
            {
                Car car01 = new Car("Ferrari", 350, driver03);
                Car car02 = new Car("Mazda", 320, driver04);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 3 && driverInput01 == 3 && carInput02 == 4 && driverInput02 == 1)
            {
                Car car01 = new Car("Ferrari", 350, driver03);
                Car car02 = new Car("Porsche", 340, driver01);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 3 && driverInput01 == 3 && carInput02 == 4 && driverInput02 == 2)
            {
                Car car01 = new Car("Ferrari", 350, driver03);
                Car car02 = new Car("Porsche", 340, driver02);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 3 && driverInput01 == 3 && carInput02 == 4 && driverInput02 == 4)
            {
                Car car01 = new Car("Ferrari", 350, driver03);
                Car car02 = new Car("Porsche", 340, driver04);
                RaceCars(car01, car02);

            }
            // [ 3 - 4 ]
            else if (carInput01 == 3 && driverInput01 == 4 && carInput02 == 1 && driverInput02 == 1)
            {
                Car car01 = new Car("Ferrari", 350, driver04);
                Car car02 = new Car("Hyundai", 310, driver01);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 3 && driverInput01 == 4 && carInput02 == 1 && driverInput02 == 2)
            {
                Car car01 = new Car("Ferrari", 350, driver04);
                Car car02 = new Car("Hyundai", 310, driver02);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 3 && driverInput01 == 4 && carInput02 == 1 && driverInput02 == 3)
            {
                Car car01 = new Car("Ferrari", 350, driver04);
                Car car02 = new Car("Hyundai", 310, driver03);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 3 && driverInput01 == 4 && carInput02 == 2 && driverInput02 == 1)
            {
                Car car01 = new Car("Ferrari", 350, driver04);
                Car car02 = new Car("Mazda", 320, driver01);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 3 && driverInput01 == 4 && carInput02 == 2 && driverInput02 == 2)
            {
                Car car01 = new Car("Ferrari", 350, driver04);
                Car car02 = new Car("Mazda", 320, driver02);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 3 && driverInput01 == 4 && carInput02 == 2 && driverInput02 == 3)
            {
                Car car01 = new Car("Ferrari", 350, driver04);
                Car car02 = new Car("Mazda", 320, driver03);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 3 && driverInput01 == 4 && carInput02 == 4 && driverInput02 == 1)
            {
                Car car01 = new Car("Ferrari", 350, driver04);
                Car car02 = new Car("Porsche", 340, driver01);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 3 && driverInput01 == 4 && carInput02 == 4 && driverInput02 == 2)
            {
                Car car01 = new Car("Ferrari", 350, driver04);
                Car car02 = new Car("Porsche", 340, driver02);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 3 && driverInput01 == 4 && carInput02 == 4 && driverInput02 == 3)
            {
                Car car01 = new Car("Ferrari", 350, driver04);
                Car car02 = new Car("Porsche", 340, driver03);
                RaceCars(car01, car02);

            }
            // [ Combinations starting with 4 ]
            // [ 4 - 1 ]
            else if (carInput01 == 4 && driverInput01 == 1 && carInput02 == 1 && driverInput02 == 2)
            {
                Car car01 = new Car("Porsche", 340, driver01);
                Car car02 = new Car("Hyundai", 310, driver02);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 4 && driverInput01 == 1 && carInput02 == 1 && driverInput02 == 3)
            {
                Car car01 = new Car("Porsche", 340, driver01);
                Car car02 = new Car("Hyundai", 310, driver03);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 4 && driverInput01 == 1 && carInput02 == 1 && driverInput02 == 4)
            {
                Car car01 = new Car("Porsche", 340, driver01);
                Car car02 = new Car("Hyundai", 310, driver04);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 4 && driverInput01 == 1 && carInput02 == 2 && driverInput02 == 2)
            {
                Car car01 = new Car("Porsche", 340, driver01);
                Car car02 = new Car("Mazda", 320, driver02);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 4 && driverInput01 == 1 && carInput02 == 2 && driverInput02 == 3)
            {
                Car car01 = new Car("Porsche", 340, driver01);
                Car car02 = new Car("Mazda", 320, driver03);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 4 && driverInput01 == 1 && carInput02 == 2 && driverInput02 == 4)
            {
                Car car01 = new Car("Porsche", 340, driver01);
                Car car02 = new Car("Mazda", 320, driver04);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 4 && driverInput01 == 1 && carInput02 == 3 && driverInput02 == 2)
            {
                Car car01 = new Car("Porsche", 340, driver01);
                Car car02 = new Car("Ferrari", 350, driver02);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 4 && driverInput01 == 1 && carInput02 == 3 && driverInput02 == 3)
            {
                Car car01 = new Car("Porsche", 340, driver01);
                Car car02 = new Car("Ferrari", 350, driver03);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 4 && driverInput01 == 1 && carInput02 == 3 && driverInput02 == 4)
            {
                Car car01 = new Car("Porsche", 340, driver01);
                Car car02 = new Car("Ferrari", 350, driver04);
                RaceCars(car01, car02);

            }
            // [ 4 - 2 ]
            else if (carInput01 == 4 && driverInput01 == 2 && carInput02 == 1 && driverInput02 == 1)
            {
                Car car01 = new Car("Porsche", 340, driver02);
                Car car02 = new Car("Hyundai", 310, driver01);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 4 && driverInput01 == 2 && carInput02 == 1 && driverInput02 == 3)
            {
                Car car01 = new Car("Porsche", 340, driver02);
                Car car02 = new Car("Hyundai", 310, driver03);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 4 && driverInput01 == 2 && carInput02 == 1 && driverInput02 == 4)
            {
                Car car01 = new Car("Porsche", 340, driver02);
                Car car02 = new Car("Hyundai", 310, driver04);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 4 && driverInput01 == 2 && carInput02 == 2 && driverInput02 == 1)
            {
                Car car01 = new Car("Porsche", 340, driver02);
                Car car02 = new Car("Mazda", 320, driver01);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 4 && driverInput01 == 2 && carInput02 == 2 && driverInput02 == 3)
            {
                Car car01 = new Car("Porsche", 340, driver02);
                Car car02 = new Car("Mazda", 320, driver03);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 4 && driverInput01 == 2 && carInput02 == 2 && driverInput02 == 4)
            {
                Car car01 = new Car("Porsche", 340, driver02);
                Car car02 = new Car("Mazda", 320, driver04);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 4 && driverInput01 == 2 && carInput02 == 3 && driverInput02 == 1)
            {
                Car car01 = new Car("Porsche", 340, driver02);
                Car car02 = new Car("Ferrari", 350, driver01);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 4 && driverInput01 == 2 && carInput02 == 3 && driverInput02 == 3)
            {
                Car car01 = new Car("Porsche", 340, driver02);
                Car car02 = new Car("Ferrari", 350, driver03);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 4 && driverInput01 == 2 && carInput02 == 3 && driverInput02 == 4)
            {
                Car car01 = new Car("Porsche", 340, driver02);
                Car car02 = new Car("Ferrari", 350, driver04);
                RaceCars(car01, car02);

            }
            // [ 4 - 3 ]
            else if (carInput01 == 4 && driverInput01 == 3 && carInput02 == 1 && driverInput02 == 1)
            {
                Car car01 = new Car("Porsche", 340, driver03);
                Car car02 = new Car("Hyundai", 310, driver01);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 4 && driverInput01 == 3 && carInput02 == 1 && driverInput02 == 2)
            {
                Car car01 = new Car("Porsche", 340, driver03);
                Car car02 = new Car("Hyundai", 310, driver02);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 4 && driverInput01 == 3 && carInput02 == 1 && driverInput02 == 4)
            {
                Car car01 = new Car("Porsche", 340, driver03);
                Car car02 = new Car("Hyundai", 310, driver04);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 4 && driverInput01 == 3 && carInput02 == 2 && driverInput02 == 1)
            {
                Car car01 = new Car("Porsche", 340, driver03);
                Car car02 = new Car("Mazda", 320, driver01);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 4 && driverInput01 == 3 && carInput02 == 2 && driverInput02 == 2)
            {
                Car car01 = new Car("Porsche", 340, driver03);
                Car car02 = new Car("Mazda", 320, driver02);
                RaceCars(car01, car02);
            }
            else if (carInput01 == 4 && driverInput01 == 3 && carInput02 == 2 && driverInput02 == 4)
            {
                Car car01 = new Car("Porsche", 340, driver03);
                Car car02 = new Car("Mazda", 320, driver04);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 4 && driverInput01 == 3 && carInput02 == 3 && driverInput02 == 1)
            {
                Car car01 = new Car("Porsche", 340, driver03);
                Car car02 = new Car("Ferrari", 350, driver01);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 4 && driverInput01 == 3 && carInput02 == 3 && driverInput02 == 2)
            {
                Car car01 = new Car("Porsche", 340, driver03);
                Car car02 = new Car("Ferrari", 350, driver02);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 4 && driverInput01 == 3 && carInput02 == 3 && driverInput02 == 4)
            {
                Car car01 = new Car("Porsche", 340, driver03);
                Car car02 = new Car("Ferrari", 350, driver04);
                RaceCars(car01, car02);
            }
            // [ 4 - 4 ]
            else if (carInput01 == 4 && driverInput01 == 4 && carInput02 == 1 && driverInput02 == 1)
            {
                Car car01 = new Car("Porsche", 340, driver04);
                Car car02 = new Car("Hyundai", 310, driver01);
                RaceCars(car01, car02);
            }
            else if (carInput01 == 4 && driverInput01 == 4 && carInput02 == 1 && driverInput02 == 2)
            {
                Car car01 = new Car("Porsche", 340, driver04);
                Car car02 = new Car("Hyundai", 310, driver02);
                RaceCars(car01, car02);
            }
            else if (carInput01 == 4 && driverInput01 == 4 && carInput02 == 1 && driverInput02 == 3)
            {
                Car car01 = new Car("Porsche", 340, driver04);
                Car car02 = new Car("Hyundai", 310, driver03);
                RaceCars(car01, car02);
            }
            else if (carInput01 == 4 && driverInput01 == 4 && carInput02 == 2 && driverInput02 == 1)
            {
                Car car01 = new Car("Porsche", 340, driver04);
                Car car02 = new Car("Mazda", 320, driver01);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 4 && driverInput01 == 4 && carInput02 == 2 && driverInput02 == 2)
            {
                Car car01 = new Car("Porsche", 340, driver04);
                Car car02 = new Car("Mazda", 320, driver02);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 4 && driverInput01 == 4 && carInput02 == 2 && driverInput02 == 3)
            {
                Car car01 = new Car("Porsche", 340, driver04);
                Car car02 = new Car("Mazda", 320, driver03);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 4 && driverInput01 == 4 && carInput02 == 3 && driverInput02 == 1)
            {
                Car car01 = new Car("Porsche", 340, driver04);
                Car car02 = new Car("Ferrari", 350, driver01);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 4 && driverInput01 == 4 && carInput02 == 3 && driverInput02 == 2)
            {
                Car car01 = new Car("Porsche", 340, driver04);
                Car car02 = new Car("Ferrari", 350, driver02);
                RaceCars(car01, car02);

            }
            else if (carInput01 == 4 && driverInput01 == 4 && carInput02 == 3 && driverInput02 == 3)
            {
                Car car01 = new Car("Porsche", 340, driver04);
                Car car02 = new Car("Ferrari", 350, driver03);
                RaceCars(car01, car02);

            }
            else if ((carInput01 < 1 || carInput01 > 4) || (carInput02 < 1 || carInput02 > 4) || (driverInput01 < 1 || driverInput01 > 4) || (driverInput02 < 1 || driverInput01 > 2))
            {
                Console.WriteLine("Please enter a number 1 , 2 , 3 or 4!");
            }
            else
            {
                Console.WriteLine("You can not pick same car and driver!!!");
            }
        }
    }
}
