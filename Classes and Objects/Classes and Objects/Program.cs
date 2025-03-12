using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Classes_and_Objects
{
    // følger videoen til at forstå: 
    internal class Program // Her er klassen!
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("Jurassic Park", "Michael Crichton", 448);
            Book b2 = new Book("The dark Crystal The novelization", "A.C.H. SMITH", 223);
            Book b3 = new Book("Dræb ikke en sangfugl", "Harper Lee", 333);
            Book b4 = new Book("Skæmtsomme historier", "Honoré De Balzac", 118);
            Book b5 = new Book("Frankenstein", "Mary Shelley", 265);

            /* BØGER
             Jurassic Park, Michael Crichton, 448

The dark Crystal The novelization, A.C.H. SMITH, 223

Dræb ikke en sangfugl, Harper Lee, 333
Skæmtsomme historier, Honoré De Balzac, 118
            Frankenstein, Mary Shelley, 265
            */
            Console.WriteLine(b1.GetDestription());
            Console.WriteLine(b2.GetDestription());
            Console.WriteLine(b3.GetDestription());
            Console.WriteLine(b4.GetDestription());
            Console.WriteLine(b5.GetDestription());

            Console.ReadLine();

            //Programmet burde printe navne, forfatter og sidetal.
        }
    }
     
}
