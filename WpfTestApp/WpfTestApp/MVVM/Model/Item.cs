using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTestApp.MVVM.Model
{
    internal class Item
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int Quantity { get; set; }

        public Item() { }
        
        public Item(string name, string id, int quantity)
        {
            Name = name;
            Id = id;
            Quantity = quantity;
        }
    }
}
