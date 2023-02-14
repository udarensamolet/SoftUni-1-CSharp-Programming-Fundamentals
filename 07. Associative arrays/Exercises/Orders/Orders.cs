using System;
using System.Linq;
using System.Collections.Generic;

namespace Orders
{
    class Orders
    {
        static void Main()
        {
            Dictionary<string, double> orders = new Dictionary<string, double>();
            Dictionary<string, double> prices = new Dictionary<string, double>();
            Dictionary<string, double> quantities = new Dictionary<string, double>();

            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (true)
            {
                if (input[0] == "buy")
                {
                    break;
                }

                string product = input[0];
                double price = Convert.ToDouble(input[1]);
                int quantity = Convert.ToInt32(input[2]);

                if (!orders.ContainsKey(product))
                {
                    orders.Add(product, price * quantity);
                    prices.Add(product, price);
                    quantities.Add(product, quantity);
                }
                else
                {
                    if (price == prices[product])
                    {
                        orders[product] += (price * quantity);
                        quantities[product] += quantity;
                    }
                    else
                    {
                        prices[product] = price;
                        quantities[product] += quantity;
                        orders[product] = prices[product] * quantities[product];
                    }
                }

                input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }

            foreach (var order in orders)
            {
                Console.WriteLine($"{order.Key} -> {order.Value:f2}");
            }
        }
    }
}
