using System.Diagnostics.CodeAnalysis;
using System.Runtime.ExceptionServices;

namespace Arrays
{
    internal class Program
    {
      
        static void Main(string[] args)
        {

            /*// finder ramdom tal:"Min originale" metode:
           Random rng = new Random();
            int rand1 = rng.Next(1, 11);
            int rand2 = rng.Next(1, 11);
            int rand3 = rng.Next(1, 11);
            int rand4 = rng.Next(1, 11);
            int rand5 = rng.Next(1, 11);
            int rand6 = rng.Next(1, 11);
            int rand7 = rng.Next(1, 11);
            int rand8 = rng.Next(1, 11);
            int rand9 = rng.Next(1, 11);
            int rand10 = rng.Next(1, 11);

            // putter dem i et array
            int[] numbers = { rand1, rand2, rand3, rand4, rand5, rand6, rand7, rand8, rand9, rand10 };
            */

            // Lettere metode:
            // Opret et array med 10 tilfældige tal
            Random random = new Random(); // Her siger vi at vi vil have et random tal.
            int[] numbers = new int[10]; // her står der hvor mange tal der skal i
            for (int i = 0; i < numbers.Length; i++) // Her starter vi et får loop, som stopper når vi har alle tallene i arrayet.
            {
                numbers[i] = random.Next(1, 11); // Tilfældige tal mellem 1 og 10
            }

            //Presenterer tal:

            Console.WriteLine("Here's a list of random numbers between 0-10:");

            // Metode til at printe tallene fra arrayet:
            for (int i = 0; i < numbers.Length; i++) // Her starter vi et får loop, som stopper når vi har PRINTET tallene i arrayet.
            {
              
                Console.WriteLine(numbers[i]); 
            }

            // without array: Console.WriteLine($"Here's a list of random numbers between 0-10:\n{rand1}\n{rand2}\n{rand3}\n{rand4}\n{rand5}\n{rand6}\n{rand7}\n{rand8}\n{rand9}\n{rand10}");

            Console.WriteLine("\nWe are now gonna do some calculations with these random numbers.\n\n");

            // plusser tallene:
            Console.WriteLine("First we add them all together:");
            int sum = numbers.Sum();
            Console.WriteLine( numbers.Sum() );

            //bregner gennemsnit:
            Console.WriteLine("\n\nNow we find the average sum:");
            double avg = numbers.Average();
            Console.WriteLine(numbers.Average());

            //Sorterer tallene:
            Console.WriteLine("\n\nAnd lastly we arrange the numbers in acsending order:");

            //her får vi den til at sortere tallene inden vi gentager det samme som ovenfor:
            Array.Sort(numbers);

            for (int i = 0; i < numbers.Length; i++) // Her starter vi et får loop, som stopper når vi har PRINTET tallene i arrayet.
            {

                Console.WriteLine(numbers[i]);
            }

            // Vi kan tage dem modsat også, bare for at flexe:

            /*Array.Reverse(numbers);
            for (int i = 0; i < numbers.Length; i++) // Her starter vi et får loop, som stopper når vi har PRINTET tallene i arrayet.
            {

                Console.WriteLine(numbers[i]);
            }
            */

            Console.ReadLine();
        }
    }
}
