using System;
using System.Collections.Generic;
using animals.AnimalTypes;

namespace animals.Services
{
    public class AnimalService
    {
        private List<Animal> animals;

        public AnimalService()
        {
            animals = new List<Animal>();

            InitAnimals();
        }

        private void InitAnimals()
        {
            Pig ghita = new Pig("Ghita");
            Cat puffy = new Cat("Puffy");
            Horse patrick = new Horse("Patrick");
            Dog spike = new Dog("Spike");

            animals.Add(ghita);
            animals.Add(puffy);
            animals.Add(patrick);
            animals.Add(spike);
        }

        public void ShowAnimals()
        {
            foreach (Animal animal in animals)
            {
                Console.WriteLine($"{animal.GetType().Name} {animal.Name} makes {animal.MakeSound()}!");
            }
        }
    }
}