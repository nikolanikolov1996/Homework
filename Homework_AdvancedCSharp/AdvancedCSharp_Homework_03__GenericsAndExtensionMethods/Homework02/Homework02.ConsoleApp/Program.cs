using System;
using Homework02.Domain.Entities;
using Homework02.Domain.Extensions;
using Homework02.Domain.GenericDB;

namespace Homework02.ConsoleApp
{
    class Program
    {
        public static ShapeDB<Circle> CircleDB = new ShapeDB<Circle>();
        public static ShapeDB<Rectangle> RectangleDB = new ShapeDB<Rectangle>();

        static void Main(string[] args)
        {
            CircleDB.InsertShape(new Circle(2));
            CircleDB.InsertShape(new Circle(4));
            CircleDB.InsertShape(new Circle(6));
            CircleDB.InsertShape(new Circle(8));
            CircleDB.InsertShape(new Circle(10));

            RectangleDB.InsertShape(new Rectangle(2, 2));
            RectangleDB.InsertShape(new Rectangle(2, 3));
            RectangleDB.InsertShape(new Rectangle(2, 4));
            RectangleDB.InsertShape(new Rectangle(2, 5));
            RectangleDB.InsertShape(new Rectangle(2, 7));

            CircleDB.PrintAreaAndPerimeter();
            RectangleDB.PrintAreaAndPerimeter();

            CircleDB.Shapes.PrintInfo();
            RectangleDB.Shapes.PrintInfo();
        }
    }
}
