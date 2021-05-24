using Homework02.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework02.Domain.GenericDB
{
    public class ShapeDB<T> where T : Shape
    {
        public List<T> Shapes { get; set; }

        public ShapeDB()
        {
            Shapes = new List<T>();
        }

        public void InsertShape(T shape)
        {
            Shapes.Add(shape);
        }

        public void RemoveShape(T shape)
        {
            Shapes.Remove(shape);
        }

        public void PrintAreaAndPerimeter()
        {
            foreach (T shape in Shapes)
            {
                Console.WriteLine($"Shape: {shape.GetType().Name} | Area: {shape.GetArea()} | Perimeter: {shape.GetPerimeter()}");
            }
        }
    }
}
