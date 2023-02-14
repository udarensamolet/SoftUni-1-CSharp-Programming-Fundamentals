using System;
using System.Collections.Generic;
using System.Text;

namespace StoreBoxes
{
    class Box
    {
        public string SerialNumber { get; set; }
        public Item Item { get; set; }

        public int ItemQuantity { get; set; }

        public double PriceForBox { get; set; }

        public Box(string serialNumber, Item item, int itemQuantity, double priceForBox)
        {
            SerialNumber = serialNumber;
            Item = item;
            ItemQuantity = itemQuantity;
            PriceForBox = priceForBox;
        }
    }
}
