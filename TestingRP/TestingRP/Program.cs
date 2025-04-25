using System;
using TestingRP.Classes;
using TestingRP.RepositoryPattern;
using TestingRP.RepositoryPattern.Classes;
using TestingRP.RepositoryPattern.Interfaces;

namespace TestingRP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Opret en instans af vores konkrete repository
            ICreatureRepository creatureRepository = new InMemoryCreatureRepository();

            // Tilføj nogle personer via repository'et
            creatureRepository.Add(new Creature { Name = "Al", Type = "Phoenix", Age = 300 });
            creatureRepository.Add(new Creature { Name = "Bob", Type = "Spider", Age = 5 });

            // Hent en person baseret på ID
            Creature creature1 = creatureRepository.GetById(1);
            if (creature1 != null)
            {
                Console.WriteLine($"Found creature with ID 1: {creature1.Name},{creature1.Type}, {creature1.Age}");
            }

            // Hent alle personer
            Console.WriteLine("\nAll Creatures:");
            foreach (var creature in creatureRepository.GetAll())
            {
                Console.WriteLine($"{creature.Id}: {creature.Name}, {creature.Type}, {creature.Age}");
            }

            // Opdater en person
            Creature creatureToUpdate = creatureRepository.GetById(2);
            if (creatureToUpdate != null)
            {
                creatureToUpdate.Age = 6;
                creatureRepository.Update(creatureToUpdate);
                Console.WriteLine("\nBob has been updated.");
            }

            // Hent alle personer igen for at se ændringen
            Console.WriteLine("\nAll creatures after update:");
            foreach (var creature in creatureRepository.GetAll())
            {
                Console.WriteLine($"{creature.Id}: {creature.Name}, {creature.Type}, {creature.Age}");
            }

            // Slet en person
            creatureRepository.Delete(1);
            Console.WriteLine("\nAl has been deleted.");

            // Hent alle personer for at se sletningen
            Console.WriteLine("\nAll creatures after deletion:");
            foreach (var creature in creatureRepository.GetAll())
            {
                Console.WriteLine($"{creature.Id}: {creature.Name}, {creature.Type}, {creature.Age}");
            }

            Console.ReadLine();
        }
    }
}
