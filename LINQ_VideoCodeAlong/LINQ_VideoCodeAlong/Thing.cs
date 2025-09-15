using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_VideoCodeAlong
{
    internal class Thing
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Cost { get; set; }

        public Thing()
        {

        }

        public Thing(string name, int quant, double cost)
        {
            Name = name;
            Quantity = quant;
            Cost = cost;
        }
    }
}
