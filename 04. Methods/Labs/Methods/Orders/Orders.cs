using System;

namespace Orders
{
    class Orders
    {
        static void Main()
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            CalculateOrder(product, quantity);
        }

        static void CalculateOrder(string str, int n)
        {
            switch (str)
            {
                case "coffee":
                    Console.WriteLine($"{(n * 1.50):f2}");
                    break;
                case "water":
                    Console.WriteLine($"{(n * 1.00):f2}");
                    break;
                case "coke":
                    Console.WriteLine($"{(n * 1.40):f2}");
                    break;
                case "snacks":
                    Console.WriteLine($"{(n * 2.00):f2}");
                    break;
            }
        }
    }
}
