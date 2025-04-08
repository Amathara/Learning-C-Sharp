using System;
namespace HejDateTime
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DateTime date1 = DateTime.Now;
            Console.WriteLine(date1.ToString());

            // Get date-only portion of date, without its time.
            DateTime dateOnly = date1.Date;
            // Display date using short date string.
            Console.WriteLine(dateOnly.ToString("d"));
            // Display date using 24-hour clock.
            Console.WriteLine(dateOnly.ToString("g"));
            Console.WriteLine(dateOnly.ToString("MM/dd/yyyy HH:mm"));

            Console.ReadLine();
        }
    }
}
