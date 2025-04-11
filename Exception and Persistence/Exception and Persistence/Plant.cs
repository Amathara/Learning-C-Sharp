using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace Exception_and_Persistence
{
    public class Plant
    {
        // Properties - because they have getters and setter, otherwise they'd be fields.
        string _type { get; set; }
        string _name { get; set; }
        string _image { get; set; }

        //Constructor time
        public Plant(string type, string name, string image)
        {
            _type = type;
            _name = name;
            _image = image;
        }

        string top = "_ * 35";
        // Method to display plant info
        public void DisplayPlantInfo()
        {
            Console.WriteLine($"{top}");
        }

    }
}
