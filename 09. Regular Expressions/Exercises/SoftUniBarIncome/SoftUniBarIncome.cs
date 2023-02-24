using System;
using System.Text.RegularExpressions;


namespace SoftUniBarIncome
{
    class SoftUniBarIncome
    {
        static void Main()
        {
            string pattern = @"[^|$%.]*?%[^|$%.]*?(?<name>[A-Z][a-z]+)%[^|$%.]*?\<[^|$%.]*?(?<product>\w+)[^|$%.]*?\>[^|$%.]*?\|[^|$%.]*?(?<count>[0-9]+)[^|$%.]*?\|[^|$%.]*?(?<price>[-+]?[0-9]*\.?[0-9]+([eE][-+]?[0-9]+)?)[^|$%.]*?\$";
            Regex regex = new Regex(pattern);
            double totalPrice = 0;
            string input = Console.ReadLine();


            while (input != "end of shift")
            {
                MatchCollection matches = regex.Matches(input);
                
                foreach (Match match in matches)
                {
                    string customerName = match.Groups["name"].Value;
                    string productName = match.Groups["product"].Value;
                    int quantity = Convert.ToInt32(match.Groups["count"].Value);
                    double price = Convert.ToDouble(match.Groups["price"].Value);
                    totalPrice += (quantity * price);
                    Console.WriteLine($"{customerName}: {productName} - {(price * quantity):f2}");
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {totalPrice:f2}");
        }
    }
}
