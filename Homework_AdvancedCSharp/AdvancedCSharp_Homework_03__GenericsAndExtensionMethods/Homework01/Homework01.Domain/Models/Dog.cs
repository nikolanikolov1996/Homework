using Homework01.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework01.Domain.Models
{
    public class Dog : Pet
    {
        public string FavouriteFood { get; set; }

        public Dog(string name, int age, string favouriteFood) : base(name, AnimalType.Dog, age)
        {
            FavouriteFood = favouriteFood;
        }

        public override string PrintInfo()
        {
            return $"Name: {Name} | Age: {Age} | FavouriteFood: {FavouriteFood} | AnimalType: {AnimalType}";
        }
    }
}
