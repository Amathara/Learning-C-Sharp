namespace TestProjectRandom
{
    internal class Program
    {

        //Predicate
        //static bool IsOdd (int number)
        //{
        //    return number % 2 != 0;
        //}

        static void Main(string[] args)
        {

            //1.

            Func <int, int, int> add = (x, y) => x + y; 
            int result = add(2,3);

            Console.WriteLine(result);
            //2.

            Func<int, int> timesTen = x =>
            {
                int result = 0;
                for (int i = 0; i < 10; i++)
                {
                    result += x;
                }
                return result;
            };
            Console.WriteLine(timesTen(2));
            //2.2 (easier)
            Func<int, int> timesTen2 = x => x * 10;
          
            Console.WriteLine(timesTen2(2));


            //3.
            Func<int, int> multiplyBySelf = x => x * x;

            Console.WriteLine(multiplyBySelf(292809812));


           

            //3. make double
            Func<double, double> multiplyBySelfD = x => x * x;

            Console.WriteLine(multiplyBySelfD(245.212));




            //predicate stuff:
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Predicate<int> isOdd = number => number % 2 !=0;   
            List<int> oddNumbers = numbers.FindAll(isOdd);

            Console.WriteLine("Ulige tal:");
            foreach (int number in oddNumbers)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }
    }
}
