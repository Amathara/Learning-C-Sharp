using System.IO;
namespace TestingFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string writeText = "Det her er en gemt tekst";
            File.WriteAllText("gemtTekst.txt", writeText);

            string readText = File.ReadAllText("gemtTekst.txt");
            Console.WriteLine(readText);
            Console.ReadLine();
        }
    }
}
