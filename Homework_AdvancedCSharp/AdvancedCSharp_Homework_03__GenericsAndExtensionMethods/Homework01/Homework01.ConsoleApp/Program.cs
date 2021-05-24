using Homework01.Domain.Enums;
using Homework01.Domain.GenericDB;
using Homework01.Domain.Models;
using System;
using System.Threading;

namespace Homework01.ConsoleApp
{
    class Program
    {
        public static PetStore<Dog> DogStore = new PetStore<Dog>();
        public static PetStore<Cat> CatStore = new PetStore<Cat>();
        public static PetStore<Fish> FishStore = new PetStore<Fish>();

        static void Main(string[] args)
        {
            DogStore.AddPet(new Dog("Marley", 3, "pork"));
            DogStore.AddPet(new Dog("Melo", 3, "chicken"));
            ///////////////////////////////////////////////
            CatStore.AddPet(new Cat("Macho", 7, false, 10));
            CatStore.AddPet(new Cat("Mica", 3, false, 10));
            ////////////////////////////////////////////////
            FishStore.AddPet(new Fish("Djole", 1, "golden", Size.Big));
            FishStore.AddPet(new Fish("Bole", 1, "golden", Size.Medium));
            ///////////////////////////////////////////////

            Console.Clear();

            DogStore.PrintPets();
            CatStore.PrintPets();
            FishStore.PrintPets();

            Console.WriteLine("Please enter the name of the dog you want to buy:");
            string inputNameDog = Console.ReadLine();
            DogStore.BuyPet(inputNameDog);

            Console.WriteLine("Please enter the name of the cat you want to buy:");
            string inputNameCat = Console.ReadLine();
            CatStore.BuyPet(inputNameCat);

            DogStore.PrintPets();
            CatStore.PrintPets();
            FishStore.PrintPets();

        }
    }
}
