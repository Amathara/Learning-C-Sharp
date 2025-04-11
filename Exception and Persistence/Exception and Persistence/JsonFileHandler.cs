using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Exception_and_Persistence
{
    public static class JsonFileHandler
    {
        // Method to serialize and write the list of plants to a file
        public static void WritePlantsToFile(string fileName, List<Plant> plants)
        {
            // Serialize the list of plants to a JSON string
            string json = JsonSerializer.Serialize(plants, new JsonSerializerOptions { WriteIndented = true });

            // Write the JSON string to a file
            File.WriteAllText(fileName, json);
        }

        // Method to read and deserialize plants from a file
        public static List<Plant> ReadPlantsFromFile(string fileName)
        {
            // Read the JSON string back from the file
            string readText = File.ReadAllText(fileName);

            // Deserialize the JSON string back into a list of plants
            List<Plant> readPlants = JsonSerializer.Deserialize<List<Plant>>(readText);
            return readPlants;
        }

       
    }
}
