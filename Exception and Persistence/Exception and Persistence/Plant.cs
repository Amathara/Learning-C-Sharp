using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace Exception_and_Persistence
{
    public class Plant
    {
        // Properties - because they have getters and setter, otherwise they'd be fields.
        public string Type { get; set; }
        public string Name { get; set; }
        public double Height { get; set; }
        public string Image { get; set; }

        //Constructor time
        public Plant(string type, string name, double height, string image)
        {
            Type = type;
            Name = name;
            Height = height;
            Image = image;
            
        }
        string line = new string('─', 73);//•,ꟷ, ‒, ─

        string someSpace = new string(' ', 12);
        //Method for creating colored borders
        public void GreenTop()
        {
            
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(line); // Write text in green
            Console.ResetColor();

        }

       

        // Method to display plant info
        public void DisplayPlantInfoTop()
        {
            GreenTop();
            Console.WriteLine("|" + " " + "Type".PadRight(16) + "|" + " " + "Name".PadRight(16) + "|" + " " + "Height".PadRight(16) + "|" + " " + "Image".PadRight(16) + "|");
            GreenTop();
        }
        public void DisplayPlantInfo()
        {
            Console.WriteLine("|" + " " + Type.PadRight(16) + "|" + " " + Name.PadRight(16) + "|" + " " + (Height.ToString() + " cm").PadRight(16) + "|" + " " + Image.PadRight(16) + "|" + "\n" + line);
        }
        

        List<Plant> plants { get; set; }

    }
}
