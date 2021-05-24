using System;
using System.Collections.Generic;
using System.Text;
using Homework01.Domain.Enums;

namespace Homework01.Domain.Models
{
    public class Fish : Pet
    {
        public string Color { get; set; }
        public Size Size { get; set; }

        public Fish(string name, int age, string color, Size size) : base(name, AnimalType.Fish, age)
        {
            Color = color;
            Size = size;
        }

        public override string PrintInfo()
        {
            return $"Name: {Name} | Age: {Age} | Color: {Color} | Size: {Size} | AnimalType: {AnimalType}";
        }
    }
}
