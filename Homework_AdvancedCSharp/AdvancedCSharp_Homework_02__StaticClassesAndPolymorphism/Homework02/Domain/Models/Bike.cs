using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Bike : Vehicle
    {
        public string Color { get; set; }

        public Bike(int id, string type, int yearOfProduction, string batchNo, string color) : base(id, type, yearOfProduction, batchNo)
        {
            Color = color;
        }

        public override void PrintVehicle()
        {
            Console.WriteLine($"ID: {Id}, Type: {Type}, Color: {Color}");
        }
    }
}
