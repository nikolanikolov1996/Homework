using System;
using Classes;
using Classes.Enums;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            var electricCar = new ElectricCar()
            {
                Brand = "Tesla",
                Model = "S",
                Doors = 5,
                TopSpeed = 270,
                Consumption = Consumption.Medium
            };

            var fuelCar = new FuelCar()
            {
                Brand = "A2",
                Model = "Audi",
                Doors = 5,
                TopSpeed = 220,
                Consumption = Consumption.Economic
            };

            electricCar.PrintInfo();
            electricCar.Drive(500);
            electricCar.Recharge(500);

            fuelCar.PrintInfo();
            fuelCar.Drive(300);
            fuelCar.Refuel(40);
        }
    }
}
