using System;
using System.Linq;
using System.Collections.Generic;

namespace StoreBoxes
{
    class StoreBoxes
    {
        static void Main()
        {
            List<Box> boxes = new List<Box>();
            List<Box> descSortBox = new List<Box>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                else
                {
                    string[] inputInfo = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                    string boxSerialNumber = inputInfo[0];
                    string itemName = inputInfo[1];
                    int itemQuantity = Convert.ToInt32(inputInfo[2]);
                    double itemPrice = Convert.ToDouble(inputInfo[3]);

                    Item item = new Item(itemName, itemPrice);

                    double boxPrice = itemQuantity * itemPrice;

                    Box boxItem = new Box(boxSerialNumber, item, itemQuantity, boxPrice);
                    boxes.Add(boxItem);

                    descSortBox = boxes.OrderByDescending(x => x.PriceForBox).ToList();
                }
            }
            foreach (var box in descSortBox)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForBox:f2}");
            }
        }
    }
}
