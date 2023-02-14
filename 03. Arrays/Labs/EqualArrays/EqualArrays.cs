using System;
using System.Linq;

namespace EqualArrays
{
    class EqualArrays
    {
        static void Main()
        {
            int[] arrayFirst = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] arraySecond = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            bool identical = false;
            int index = 0;
            int sum = 0;

            if (arrayFirst.Length == arraySecond.Length)
            {
                for (int i = 0; i < arrayFirst.Length; i++)
                {
                    if (arrayFirst[i] != arraySecond[i])
                    {
                        identical = false;
                        index = i;

                        break;
                    }
                    else
                    {
                        identical = true;
                        sum += arrayFirst[i];
                    }
                }

                if (identical == true)
                {
                    Console.WriteLine($"Arrays are identical. Sum: {sum}");
                }
                else
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {index} index");
                }
            }
        }
    }
}

