using System;
using System.Linq;

namespace RoundingNumbers
{
    class RoundingNumbers
    {
        static void Main()
        {
            double[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            int[] roundedNumbers = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                roundedNumbers[i] = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{numbers[i]} => {roundedNumbers[i]}");
                //Console.WriteLine($"{Convert.ToDecimal(numbers[i])} => {Math.Round(Convert.ToDecimal(numbers[i]), MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
