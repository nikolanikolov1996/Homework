using Homework01.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework01.Domain.GenericDB
{
    public class PetStore<T> where T : Pet
    {
        public List<T> Pets { get; set; }

        public PetStore()
        {
            Pets = new List<T>();
        }

        public void PrintPets()
        {
            Console.WriteLine($"Printing pets from the {Pets[0].GetType().Name} store!");

            foreach (T pet in Pets)
            {
                Console.WriteLine(pet.PrintInfo());
            }
        }

        public void AddPet(T pet)
        {
            Pets.Add(pet);
            Console.WriteLine($"{pet.GetType().Name} was added in the {pet.GetType().Name} store!");
        }

        public void BuyPet(string name)
        {
            T pet = Pets.FirstOrDefault(pet => pet.Name.ToLower() == name.ToLower());

            if (pet == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Sorry no such animal in the store by that name {name}!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Congratulations!!! You bought your pet: {pet.Name} Age: {pet.Age} AnimalType: {pet.AnimalType}!");
                Console.ResetColor();
                Pets.Remove(pet);
            }

            
        }
    }
}
