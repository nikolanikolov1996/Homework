using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Car : Vehicle
    {
        public int FuelTank { get; set; }
        public List<string> Countries { get; set; } = new List<string>();

        public Car(int id, string type, int yearOfProduction, string batchNo, int fuelTank, List<string> countries) : base(id, type, yearOfProduction, batchNo)
        {
            FuelTank = FuelTank;
            Countries = countries;
        }

        private string PrintCountries()
        {
            string country = "";

            foreach (string item in Countries)
            {
               country += item;
            }

            return country;
        }

        public override void PrintVehicle()
        {
            Console.WriteLine($"ID: {Id}, Type: {Type}, Countries: {PrintCountries()}");
        }
    }
}
