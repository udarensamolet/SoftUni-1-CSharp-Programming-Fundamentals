using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main()
        {
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int counter = 1;
            int number = 0;

            int maxCounter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                counter = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        counter++;

                        if (counter > maxCounter)
                        {
                            maxCounter = counter;
                            number = arr[i];
                        }
                    }
                    else
                    {
                        counter = 1;
                        break;
                    }
                }
            }

            for (int i = 0; i < maxCounter; i++)
            {
                Console.Write($"{number} ");
            }


        }
    }
}
