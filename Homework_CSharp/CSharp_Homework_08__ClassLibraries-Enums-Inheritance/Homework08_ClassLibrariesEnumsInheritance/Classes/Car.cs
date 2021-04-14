using System;
using System.Collections.Generic;
using System.Text;
using Classes.Enums;

namespace Classes
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Doors { get; set; }
        public int TopSpeed { get; set; }
        public Consumption Consumption { get; set; }
        public EngineType EngineType { get; set; }
        public Car()
        {
            Id = GenerateId();
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Car Id: {Id}, Brand: {Brand}, Model: {Model}, Doors: {Doors},\n" +
                $"TopSpeed: {TopSpeed}, Consumption: {Consumption}, EngineType: {EngineType}");
        }

        public static int GenerateId()
        {
            int id = new Random().Next(1, 100);
            return id;
        }
    }
}
