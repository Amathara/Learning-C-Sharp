namespace BonusApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();

            order.AddProduct(new Product { Name = "Sko", Value = 10.00 });
            order.AddProduct(new Product { Name = "Hat", Value = 20.00 });

            double sum = order.GetValueOfProducts();

            order.Bonus = Bonuses.FlatTwoIfAmount; //here you choose which method to use!

            double bonus = order.GetBonus();
            double total = order.GetTotalPrice();

            Console.WriteLine(sum);
            Console.WriteLine(bonus);
            //Console.WriteLine(bonus2);
            //Console.WriteLine(bonusSum);
            Console.WriteLine("Hello!\nHere's the total price of your order:" + total);
            Console.ReadLine();


        }
    }
}
