using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingRP.Classes;
using TestingRP.RepositoryPattern.Interfaces;

namespace TestingRP.RepositoryPattern.Classes
{
    public class InMemoryCreatureRepository : ICreatureRepository
    {
        private readonly List<Creature> _creatures = new List<Creature>(); // Make a list of creatures named "Creature"
        private int _nextId = 1; // To assign ID - starts with 1 (instead of 0)

        public Creature GetById(int id)
        {
            return _creatures.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Creature> GetAll()
        {
            return _creatures;
        }

        public void Add(Creature creature)
        {
            creature.Id = _nextId++;
            _creatures.Add(creature);
        }

        public void Update(Creature Creature)
        {
            var existingCreature = _creatures.FirstOrDefault((Func<Creature, bool>)(p => p.Id == Creature.Id));
            if (existingCreature != null)
            {
                existingCreature.Name = Creature.Name;
                existingCreature.Type = Creature.Type;
                existingCreature.Age = Creature.Age;

            }
        }

        public void Delete(int id)
        {
            _creatures.RemoveAll(p => p.Id == id);
        }
    }
}
