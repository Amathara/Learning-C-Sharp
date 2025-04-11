using System.Text.Json;
using System.IO;
using System.Xml;
namespace Exception_and_Persistence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;



            // Read the plants from the file, or use a default list if no file exists
            List<Plant> plants;
            if (File.Exists("plantList.json"))
            {
                // Deserialize the plants from the file
                plants = JsonFileHandler.ReadPlantsFromFile("plantList.json");
            }
            else
            {
                // If file doesn't exist, create a default list
                plants = new List<Plant>()
                {
                    new Plant("Flower", "Sunflower", 40, "🌻 "),
                    new Plant("Flower", "Tulip", 5, "🌷 "),
                    new Plant("Flower", "Rose", 12, "🌹 "),
                    new Plant("Flower", "Daisy", 11, "🌼 "),
                    new Plant("Flower", "Hibiscus", 3, "🌺 ")
                };
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to the World of Plants!");
            Console.ResetColor();

            
            // Call DisplayPlantInfoTop only once
            if (plants.Count > 0)
            {
                plants[0].DisplayPlantInfoTop(); // Call DisplayPlantInfoTop for the first plant
            }

            // Serialize and write plants to file using JsonFileHandler
            JsonFileHandler.WritePlantsToFile("plantList.json", plants);

            // Read and deserialize plants from the file using JsonFileHandler
            List<Plant> readPlants = JsonFileHandler.ReadPlantsFromFile("plantList.json");

            // Display the read plants
           
            foreach (var plant in readPlants)
            {
                plant.DisplayPlantInfo();
            }


            //planterne vokser efter userinput:
            Console.WriteLine("Nu skal planterne gro!");
            bool validinput = false; // To use in "while"

            while (!validinput) // To make it loop if the input is not valid.
            {
                Console.WriteLine("Hvor mange cm gror de?");
                try
                {
                    string growthInput = Console.ReadLine();

                    double growthAmount = Convert.ToDouble(growthInput);

                    validinput = true; // Ends the loop if the input IS valid.

                    foreach (var plant in plants)
                    {
                        plant.Height += growthAmount;
                    }



                    JsonFileHandler.WritePlantsToFile("plantList.json", plants);
                    // Call DisplayPlantInfoTop only once
                    if (plants.Count > 0)
                    {
                        plants[0].DisplayPlantInfoTop(); // Call DisplayPlantInfoTop for the first plant
                    }

                    foreach (var plant in plants)
                    {
                        plant.DisplayPlantInfo();
                    }
                }
                // if the input is NOT valid.
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fejl: Indtast venligst et gyldigt tal.");
                    Console.ResetColor();
                }
            }
            Console.ReadLine();
        }
    }
}
