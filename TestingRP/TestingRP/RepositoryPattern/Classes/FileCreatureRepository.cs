using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;  // Importing System.Text.Json
using TestingRP.Classes;
using TestingRP.RepositoryPattern.Interfaces;

namespace TestingRP.RepositoryPattern.Classes
{
    public class FileCreatureRepository : ICreatureRepository
    {
        private readonly string _filePath;  // File path can now be provided as a parameter

        // Constructor now takes a file path parameter
        public FileCreatureRepository(string filePath)
        {
            _filePath = filePath;

            // If the file doesn't exist, create it with an empty list of creatures
            {
                var initialData = new
                {
                    nextId = 1,
                    creatures = new List<Creature>()
                };
                File.WriteAllText(_filePath, JsonSerializer.Serialize(initialData));
            }
        }

        // Here we use the interface:
        public Creature GetById(int id)
        {
            var creatures = GetCreaturesFromFile();
            return creatures.FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Creature> GetAll()
        {
            return GetCreaturesFromFile();
        }

        public void Add(Creature creature)
        {
            var creatures = GetCreaturesFromFile();
            if (creatures.Any(c => c.Name == creature.Name))
            {
                return;  // Skip adding the duplicate creature
            }

            creature.Id = creatures.Any() ? creatures.Max(c => c.Id) + 1 : 1;  // Generate next ID
            creatures.Add(creature);
            SaveCreaturesToFile(creatures);
        }

        public void Update(Creature creature)
        {
            var creatures = GetCreaturesFromFile();
            var existingCreature = creatures.FirstOrDefault(c => c.Id == creature.Id);
            if (existingCreature != null)
            {
                existingCreature.Name = creature.Name;
                existingCreature.Type = creature.Type;
                existingCreature.Age = creature.Age;
                SaveCreaturesToFile(creatures);
            }
        }

        public void Delete(int id)
        {
            var creatures = GetCreaturesFromFile();
            var creatureToRemove = creatures.FirstOrDefault(c => c.Id == id);
            if (creatureToRemove != null)
            {
                creatures.Remove(creatureToRemove);
                SaveCreaturesToFile(creatures);
            }
        }

        private List<Creature> GetCreaturesFromFile()
        {
            var json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<Creature>>(json) ?? new List<Creature>();
        }

        private void SaveCreaturesToFile(List<Creature> creatures)
        {
            var json = JsonSerializer.Serialize(creatures, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, json);
        }
    }
}