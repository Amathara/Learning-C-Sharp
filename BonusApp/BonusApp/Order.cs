using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BonusApp
{
    public class Order
    {
        public Delegate.BonusProvider Bonus {  get; set; }

        public List<Product> Products { get; set; } = new List<Product>();


        public void AddProduct (Product p)
        {
            Products.Add(p);
        }

        public double GetValueOfProducts()
        {
                
                return Products.Sum(Product => Product.Value);
            
        }

        public double GetBonus()
        {
            double total = GetValueOfProducts();
            return Bonus(total);

        }

        public double GetTotalPrice()
        {
            double price = GetValueOfProducts();
            double bonus = GetBonus();
            return price - bonus;
        }





    }
}
