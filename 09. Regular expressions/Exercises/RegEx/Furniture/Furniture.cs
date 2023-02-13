using System;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Furniture
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @">>(?<furnitureType>[A-z]+)<<(?<price>[0-9]+[\.]?([0-9]+)?)!(?<quantity>[0-9]+)";
            double totalPrice = 0;

            Console.WriteLine("Bought furniture:");
            while (input != "Purchase")
            {
                Regex regex = new Regex(pattern);
                MatchCollection matches = regex.Matches(input);
                foreach (Match match in matches)
                {
                    string furnitureType = match.Groups["furnitureType"].Value;
                    double price = Convert.ToDouble(match.Groups["price"].Value);
                    int quantity = Convert.ToInt32(match.Groups["quantity"].Value);
                    totalPrice += price * quantity;
                    Console.WriteLine($"{furnitureType}");
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total money spend: {totalPrice:f2}");


        }
    }
}
