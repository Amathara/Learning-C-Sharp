

using System.Net.NetworkInformation;
using System;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // En "List" er en dymanisk version af et array. Du behøver ikke specificere antal fra starten af.
            // Man kan adde en liste ved at tilføje "System.Collections.Generic;" 

          List <string> animals = new List <string> (); // Her starter man listen. <string> viser hvilken type data der er i listen.

            animals.Add("Tiger");
            animals.Add("Lion");
            animals.Add("    ^---^\nFox  * *\n      U "); //Leger bare med at tegne i ASCII
            animals.Add("Otter");
            animals.Add("Bird (o)>"); //Samme her


            // Man kan gøre flere ting med lister:
           // animals.Remove("Otter"); //Fjerner "Otter" fra den udskrevne liste.
            //animals.Insert(0, "Frog"); //Indsætter "Frog" på listen - 0 viser pladsen.
            Console.WriteLine (animals.Count); //tæller hvor mange der er på listen.
            Console.WriteLine(animals.IndexOf("Tiger")); // Viser hvad nr "Tiger" er på listen.
            Console.WriteLine(animals.LastIndexOf("Otter")); //Viser "sidste" plads Otter er på.
            Console.WriteLine(animals.Contains("Otter")); // tjekker om listen indeholder "Otter" og giver en bool "true/false"
            animals.Sort(); // Sorterer listen
                            //animals.Reverse(); // Sætter dem i modsat rækkefølge.
                            //animals.Clear(); //Fjerner alle items fra listen


            //Convert list to array:
            String[] animalsArray = animals.ToArray(); // Det virkede bare ikke som i videoen?


            // Vis liste:

            foreach (String item in animals) // Siger at den skal indeholde alle på listen. 
            {
                Console.WriteLine(item); //Skriver navnet på dyret.
            }

            // Using for-loop with index - Her sætter den tal foran.
for (int i = 0; i < animals.Count; i++)
                {
                    Console.WriteLine($"{i}: {animals[i]}");
                }


            Console.ReadLine();


        }
    }
}
