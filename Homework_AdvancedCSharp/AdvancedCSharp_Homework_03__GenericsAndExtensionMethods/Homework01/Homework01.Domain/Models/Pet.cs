using System;
using System.Collections.Generic;
using System.Text;
using Homework01.Domain.Enums;

namespace Homework01.Domain.Models
{
    public abstract class Pet
    {
        public string Name { get; set; }
        public AnimalType AnimalType { get; set; }
        public int Age { get; set; }

        public Pet(string name, AnimalType animalType, int age)
        {
            Name = name;
            AnimalType = animalType;
            Age = age;
        }

        public abstract string PrintInfo();
    }
}
