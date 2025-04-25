using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingRP.Classes;

namespace TestingRP.RepositoryPattern.Interfaces
{
    public interface ICreatureRepository
    {
        Creature GetById(int id);
        IEnumerable<Creature> GetAll();
        void Add(Creature creature);
        void Update(Creature creature);
        void Delete(int id);
    }
}
