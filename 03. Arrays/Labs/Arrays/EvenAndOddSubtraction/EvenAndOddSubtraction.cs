using System;
using System.Linq;


namespace EvenAndOddSubtraction
{
    class EvenAndOddSubtraction
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int sumEven = 0;
            int sumOdd = 0;
            int diff = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sumEven += numbers[i];
                }
                else
                {
                    sumOdd += numbers[i];
                }
            }
            diff = sumEven - sumOdd;
            Console.WriteLine(diff);

        }
    }
}
