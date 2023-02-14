using System;
using System.Linq;

namespace EqualSums
{
    class EqualSums
    {
        static void Main()
        {
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int sumLeft = 0;
            int sumRight = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sumLeft = 0;
                sumRight = 0;
                if (i == 0)
                {
                    sumLeft = 0;
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        sumRight += arr[j];
                    }
                }
                else if (i == arr.Length - 1)
                {
                    sumRight = 0;
                    for (int j = 0; j < arr.Length - 1; j++)
                    {
                        sumLeft += arr[j];
                    }
                }
                else
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        sumRight += arr[j];
                    }
                    for (int j = 0; j < i; j++)
                    {
                        sumLeft += arr[j];
                    }
                }

                if (sumLeft == sumRight)
                {
                    Console.WriteLine($"{i}");
                    break;
                }
            }

            if (sumLeft != sumRight)
            {
                Console.WriteLine("no");
            }
        }
    }
}
