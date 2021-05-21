using Domain.Helper;
using Domain.StaticClassDB;
using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print Vehicle
            InMemoryDatabase.ListOfVehicles.ForEach(vehicle => vehicle.PrintVehicle());

            // Validates Vehicles
            InMemoryDatabase.ListOfVehicles.ForEach(vehicle => Validator.Validate(vehicle));
        }
    }
}
