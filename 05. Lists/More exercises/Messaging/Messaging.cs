using System;
using System.Collections.Generic;
using System.Linq;

namespace Messaging
{
    class Messaging
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string text = Console.ReadLine();

            int sum = 0;
            string result = "";


            for (int i = 0; i < numbers.Count; i++)
            {
                while (numbers[i] > 0)
                {
                    int lastDigit = numbers[i] % 10;
                    sum += lastDigit;
                    numbers[i] /= 10;
                }

                //while (sum >= numbers.Count)
                if (sum >= text.Length)
                {
                    sum -= text.Length;
                }
                result += text[sum];
                text = text.Remove(sum, 1);
                sum = 0;

            }
            Console.WriteLine($"{result}");
        }
    }
}
