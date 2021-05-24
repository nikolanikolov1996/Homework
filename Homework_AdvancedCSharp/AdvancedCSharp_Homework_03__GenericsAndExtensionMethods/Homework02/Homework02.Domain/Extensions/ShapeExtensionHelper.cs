using Homework02.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework02.Domain.Extensions
{
    public static class ShapeExtensionHelper
    {
        public static void PrintInfo<T>(this List<T> shapes)
        {
            T first = shapes[0];
            Console.WriteLine($"This list has {shapes.Count} members and is of type {first.GetType().Name}!");
        }
    }
}
