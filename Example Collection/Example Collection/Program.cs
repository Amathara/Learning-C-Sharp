namespace Example_Collection
{
    internal class Program
    {

        class Animal
        {
            public string Type { get; set; }
        }

        class Zoo
        {
            public string Title { get; set; }
            // Association - a list of animals in zoo
            public List<Animal> Participants { get; set; }

            // Constructor to initialize the list
            public Zoo()
            {
                Participants = new List<Animal>();
            }

            // Method to add an animal to the zoo
            public void AddAnimal(Animal animal)
            {
                Participants.Add(animal);
            }

            // Method to display all students in the course
            public void DisplayStudents()
            {
                Console.WriteLine($"Animals at {Title}:");
                foreach (var animal in Participants)
                {
                    Console.WriteLine($"- {animal.Type}");
                }
            }
        }

        class Program1
        {
            static void Main(string[] args)
            {
                // Create a Zoo
                Zoo nameOfZoo = new Zoo
                {
                    Title = "Zoo of Jitters"
                };

                // Create some Animals (objects)
                Animal animal1 = new Animal { Type = "Tiger" };
                Animal animal3 = new Animal { Type = "Monkey" };
                Animal animal2 = new Animal { Type = "Polarbear" };

                // Add students to the course
                nameOfZoo.AddAnimal(animal1);
                nameOfZoo.AddAnimal(animal2);
                nameOfZoo.AddAnimal(animal3);

                // Display all students in the course
                nameOfZoo.DisplayStudents();

                Console.ReadLine();
            }
        }

    }
}
