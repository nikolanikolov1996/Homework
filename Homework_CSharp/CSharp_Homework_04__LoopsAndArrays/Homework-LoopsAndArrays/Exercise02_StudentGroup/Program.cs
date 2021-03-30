using System;

namespace Exercise02_StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter which group you want to open, enter 1 for group01 or 2 for Group02: ");
            string groupNumInput = Console.ReadLine();
            int groupNumInt;

            bool checkGroupNumInput = int.TryParse(groupNumInput, out groupNumInt);

            string[] studentGroup01 = new string[] { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            string[] studentGroup02 = new string[] { "Nikola", "Kristina", "Martin", "Ivan", "Slavko" };

            if (checkGroupNumInput)
            {
                switch(groupNumInt)
                {
                    case 1:
                        Console.WriteLine("The Students in G1 are: ");
                        for (int i = 0; i < studentGroup01.Length; i++)
                        {
                            Console.WriteLine(studentGroup01[i]);
                        }
                        break;
                    case 2:
                        Console.WriteLine("The Students in G2 are: ");
                        for (int i = 0; i < studentGroup02.Length; i++)
                        {
                            Console.WriteLine(studentGroup02[i]);
                        }
                        break;
                    default:
                        Console.WriteLine("Please enter 1 or 2!!!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter only numbers!");
            }

            Console.ReadLine();
        }
    }
}
