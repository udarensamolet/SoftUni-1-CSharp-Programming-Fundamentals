using System;
using System.Collections.Generic;
using System.Text;

namespace StoreBoxes
{
    class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Item(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
