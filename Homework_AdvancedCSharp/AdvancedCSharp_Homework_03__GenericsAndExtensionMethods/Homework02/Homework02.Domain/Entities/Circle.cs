using System;
using System.Collections.Generic;
using System.Text;

namespace Homework02.Domain.Entities
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public double PI { get; set; } = 3.14159;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return PI * Radius * Radius;
        }

        public override double GetPerimeter()
        {
            return 2 * PI * Radius;
        }
    }
}
