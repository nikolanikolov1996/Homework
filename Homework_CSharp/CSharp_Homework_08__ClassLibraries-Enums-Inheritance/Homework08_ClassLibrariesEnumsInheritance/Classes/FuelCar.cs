using System;
using System.Collections.Generic;
using System.Text;
using Classes.Enums;

namespace Classes
{
    public class FuelCar : Car
    {
        public int FuelCapacity { get; set; }
        public int CurrentFuel { get; set; }

        public FuelCar()
        {
            EngineType = EngineType.Diesel;
            FuelCapacity = 75;
        }

        public void Drive(int distance)
        {
            int usedFuel = (distance * (int)Consumption) / 10;
            CurrentFuel = FuelCapacity - usedFuel;

            if (usedFuel > FuelCapacity)
            {
                Console.WriteLine($"The car can't drive and use more then {FuelCapacity} litres.");
            }
            else
            {
                Console.WriteLine($"You can drive the car {distance} km, fuel used for the trip {usedFuel} litres.");
            }
        }

        public void Refuel(int fuel)
        {
            int litresToRefuel = FuelCapacity - CurrentFuel;

            if (fuel > litresToRefuel)
            {
                Console.WriteLine($"Can't refuel more than {litresToRefuel} litres.");
            }
            else
            {
                Console.WriteLine($"Your car's tank is refueled with {fuel} litres.");
            }
        }
    }
}
