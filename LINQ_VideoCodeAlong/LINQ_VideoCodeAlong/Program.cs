using System;
using System.Linq;
namespace LINQ_VideoCodeAlong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Making array
            string[] names = { "Adrian", "Emma", "Kassandra", "Emilie", "Julie" };

            //bulding the dataset? of type IEnumerable<string> aka selecting things from the Array.
            var query1 = from name in names
                         select name;

            //Filtering the dataset
            /*Alternative 1 (select):

            select name[0]; <-Show only first letter of each name.

            Alternative 2 (select):

            select name.ToUpper(); <- Show names in ALL CAPS

            Alternative 3 (where):
            var query1 = from name in names
            where name.Length == 4 <- Select only names that are 4 letters long.
            select name;

            Alternative 4 (where):
            var query1 = from name in names
            where name.Contains("a") <- Select only names that contain the letter "a"
            select name;

             Alternative 5 (where):
            var query1 = from name in names
            where name !="Adrian" <- Don't show the name Adrian.
            select name;

            Alternative 6 (where):
            var query1 = from name in names
            where name !="Adrian" && name.Length > 5 <- Don't show the name Adrian & show only names above 5 letters.
            select name;

            Alternative 7 (orderby): sorts the list.
            var query1 = from name in names
                         where name != "Adrian" && name.Length > 5
                         orderby name descending <-- sorts the list by descending. 
                         select name;


            */

            // Printing what is in the dataset.
            foreach (var item in query1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            List<Thing> cart = new List<Thing>();

            cart.Add(new Thing("Ball", 100, 0.99));
            cart.Add(new Thing("Brush", 20, 2.50));
            cart.Add(new Thing("Book", 60, 7.99));

            var query2 = from item in cart
                         where item.Name.Length == 4
                         select item.Quantity;
            foreach (var thing in query2)
            {
                Console.WriteLine(thing);
            }

            // try to write a LINQ query to extract the total cost of all inventory:
            //(quanitity * cost) for each item

            var query3 = from item in cart
                         select item.Quantity * item.Cost; 

            Console.WriteLine("The total cost of inventory is {0:C}", query3.Sum()); // 99 + 50 + 479,4 = 628,40 kr? 

            Console.Write("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
