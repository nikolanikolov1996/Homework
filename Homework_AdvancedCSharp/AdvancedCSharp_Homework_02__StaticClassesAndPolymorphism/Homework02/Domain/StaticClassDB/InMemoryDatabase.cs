using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.StaticClassDB
{
    public static class InMemoryDatabase
    {
        public static List<Vehicle> ListOfVehicles;

        static InMemoryDatabase()
        {
            ListOfVehicles = new List<Vehicle>()
            {
                new Vehicle(01, "Motorbike", 2020, "111A1"),
                new Vehicle(02, "Yacht", 2010, "222C2"),
                new Car(03, "Sedan", 2004, "333C3", 75, new List<string> { "Germany ", "China ", "Japan" }),
                new Car(04, "Cabrio", 2018, "444FC", 75, new List<string> { "Taiwan ", "USA ", "France" }),
                new Bike(03, "CityBike", 2010, "555C3", "blue"),
                new Bike(03, "MountainBike", 2010, "666C3", "gray")
            };
        }
    }
}
