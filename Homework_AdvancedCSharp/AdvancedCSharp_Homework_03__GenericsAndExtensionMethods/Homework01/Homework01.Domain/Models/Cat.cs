using System;
using System.Collections.Generic;
using System.Text;
using Homework01.Domain.Enums;

namespace Homework01.Domain.Models
{
    public class Cat : Pet
    {
        public bool Lazy { get; set; }
        public int LivesLeft { get; set; }

        public Cat(string name, int age, bool lazy, int livesLeft) : base(name, AnimalType.Cat, age)
        {
            Lazy = lazy;
            LivesLeft = livesLeft;
        }

        public override string PrintInfo()
        {
            return $"Name: {Name} | Age: {Age} | LivesLeft: {LivesLeft} | AnimalType: {AnimalType}";
        }
    }
}
