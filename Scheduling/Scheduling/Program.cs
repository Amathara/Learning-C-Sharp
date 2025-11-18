using System.Threading;
namespace Scheduling

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(MethodThread);
            thread.Start("Hello, Method!");

            Thread thread2 = new Thread((object message) => {
                string text = (string)message;
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine(text);
                    Thread.Sleep(100);
                }
            });
            thread2.Start("Hello, Lambda!");
            Thread thread3 = new Thread(delegate (object message) {
                string text = (string)message;
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine(text);
                    Thread.Sleep(100);
                }
            });
            thread3.Start("Hello, Anon!");


            Console.ReadLine();

        }

        static void MethodThread(object message)
        {
            string text = (string)message;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(text);
                Thread.Sleep(100);
            }
        }

      
        
    }
}
