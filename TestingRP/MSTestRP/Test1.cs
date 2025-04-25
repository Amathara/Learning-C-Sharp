using TestingRP;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System;
using TestingRP.Classes;
using TestingRP.RepositoryPattern.Classes;
using TestingRP.RepositoryPattern.Interfaces;


namespace MSTestRP
{
    [TestClass]
    public class InMemoryCreatureRepositoryTests
    {
        [TestMethod]
        public void Add_ShouldAssignIdAndAddCreature()
        {
            // Arrange
            var repo = new InMemoryCreatureRepository();
            var creature = new Creature { Name = "Test", Type = "Test", Age = 20 };

            // Act
            repo.Add(creature);
            var result = repo.GetById(1);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Id);
            Assert.AreEqual("Test", result.Name);
            Assert.AreEqual("Test", result.Type);
            Assert.AreEqual(20, result.Age);
        }

        [TestMethod]
        public void GetAll_ShouldReturnAllCreatues()
        {
            // Arrange
            var repo = new InMemoryCreatureRepository();
            repo.Add(new Creature { Name = "Al", Type = "Phoenix", Age = 300 });
            repo.Add(new Creature { Name = "Bob", Type = "Spider", Age = 2 });

            // Act
            var result = repo.GetAll().ToList();

            // Assert
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual("Al", result[0].Name);
            Assert.AreEqual("Phoenix", result[0].Type);
            Assert.AreEqual(300, result[0].Age);
            Assert.AreEqual("Bob", result[1].Name);
            Assert.AreEqual("Spider", result[0].Type);
            Assert.AreEqual(2, result[1].Age);
        }

        [TestMethod]
        public void Update_ShouldModifyExistingCreature()
        {
            // Arrange
            var repo = new InMemoryCreatureRepository();
            var creature = new Creature { Name = "Charlie", Type = "Swan", Age = 5 };
            repo.Add(creature);

            // Act
            creature.Name = "Charles";
            creature.Type = "Swan";
            creature.Age = 5;
            repo.Update(creature);
            var updatedCreature = repo.GetById(creature.Id);

            // Assert
            Assert.IsNotNull(updatedCreature);
            Assert.AreEqual("Charles", updatedCreature.Name);
            Assert.AreEqual("Swan", updatedCreature.Type);
            Assert.AreEqual(41, updatedCreature.Age);
        }

        [TestMethod]
        public void Delete_ShouldRemoveCreatureById()
        {
            // Arrange
            var repo = new InMemoryCreatureRepository();
            var creature = new Creature { Name = "Dana", Type = "Unicorn", Age = 22 };
            repo.Add(creature);

            // Act
            repo.Delete(creature.Id);
            var deleted = repo.GetById(creature.Id);

            // Assert
            Assert.IsNull(deleted);
            Assert.AreEqual(0, repo.GetAll().Count());
        }

        [TestMethod]
        public void GetById_ShouldReturnNullIfNotFound()
        {
            // Arrange
            var repo = new InMemoryCreatureRepository();

            // Act
            var result = repo.GetById(999);

            // Assert
            Assert.IsNull(result);
        }
    }
}
