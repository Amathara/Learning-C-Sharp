using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WpfTestApp.MVVM.Model.RP.IRepo;

namespace WpfTestApp.MVVM.Model.RP.Repo
{
    public class JsonItemRepo : IItemRepo
    {
        private readonly string _filePath;
        private readonly JsonSerializerOptions _jsonOptions = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        public JsonItemRepo(string filePath)
        {
            _filePath = filePath;

            // Ensure file exists and contains valid JSON (an empty list)
            if (!File.Exists(_filePath))
            {
                File.WriteAllText(_filePath, "[]");
            }
        }

        public List<Item> GetAllItems()
        {
            try
            {
                string json = File.ReadAllText(_filePath);
                List<Item>? items = JsonSerializer.Deserialize<List<Item>>(json, _jsonOptions);
                return items ?? new List<Item>();
            }
            catch (IOException ex)
            {
                Console.WriteLine($"There was an error reading the file: {ex.Message}");
                return new List<Item>();
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"Invalid JSON format: {ex.Message}");
                return new List<Item>();
            }
        }

        public void AddItem(Item item)
        {
            List<Item> items = GetAllItems();
            items.Add(item);
            SaveItems(items);
        }

        public void DeleteItem(int id)
        {
            List<Item> items = GetAllItems();
            items.RemoveAll(i => i.Id == id);
            SaveItems(items);
        }

        public void SaveItems(List<Item> items)
        {
            try
            {
                string json = JsonSerializer.Serialize(items, _jsonOptions);
                File.WriteAllText(_filePath, json);
            }
            catch (IOException ex)
            {
                Console.WriteLine($"There was an error writing to the file: {ex.Message}");
            }
        }
    }
}
