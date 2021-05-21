using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int YearOfProduction { get; set; }
        public string BatchNo { get; set; }

        public Vehicle(int id, string type, int yearOfProduction, string batchNo)
        {
            Id = id;
            Type = type;
            YearOfProduction = yearOfProduction;
            BatchNo = batchNo;
        }

        public virtual void PrintVehicle()
        {
            Console.WriteLine($"ID: {Id}, Type: {Type}, YearOfProduction: {YearOfProduction}");
        } 
    }
}
