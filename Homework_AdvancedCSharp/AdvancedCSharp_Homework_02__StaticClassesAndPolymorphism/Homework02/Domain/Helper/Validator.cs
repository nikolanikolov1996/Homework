using Domain.Models;
using Domain.StaticClassDB;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Helper
{
    public static class Validator
    {
        public static void Validate(Vehicle vehicle)
        {
            if (vehicle.Id == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"The ID must be bigger than 0");
                Console.ResetColor();
            }

            if (vehicle.Type == "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You must enter type!");
                Console.ResetColor();
            }
            
            if (vehicle.YearOfProduction == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The YEAR must be bigger than 0");
                Console.ResetColor();
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Vehicle with ID: {vehicle.Id} Type: {vehicle.Type} YearOfProduction: {vehicle.YearOfProduction} is okay!");
            Console.ResetColor();

        }
    }
}
