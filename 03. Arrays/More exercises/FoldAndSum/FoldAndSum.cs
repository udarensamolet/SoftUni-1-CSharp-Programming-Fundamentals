using System;
using System.Linq;


namespace FoldAndSum
{
    class FoldAndSum
    {
        static void Main()
        {
            //reading input array
            int[] input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            //calculating length for each array
            int kInput = input.Length;
            int k = kInput / 4;
            int kLeft = k;
            int kRight = k;
            int kMiddle = 2 * k;
            int kOutput = 2 * k;

            //creating new arrays
            int[] left = new int[kLeft];
            int[] right = new int[kLeft];
            int[] middle = new int[kMiddle];
            int[] output = new int[kOutput];

            //filling in left array
            for (int i = 0; i < kLeft; i++)
            {
                left[i] = input[kLeft - i - 1];
            }

            //filling in right array
            for (int i = 0; i < kRight; i++)
            {
                right[i] = input[4 * kRight - i - 1];
            }

            //filling in middle array
            for (int i = 0; i < kMiddle; i++)
            {
                middle[i] = input[kInput - kMiddle - kRight + i];
            }

            //summing the partial arrays into the new one
            for (int i = 0; i < kOutput; i++)
            {
                if (i < kOutput / 2)
                {
                    output[i] = left[i] + middle[i];
                }
                else
                {
                    output[i] = right[i - kRight] + middle[i];
                }

            }

            //printing the new output array
            Console.WriteLine(string.Join(" ", output));

            /*foreach (int number in left)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            foreach (int number in right)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            foreach (int number in middle)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            foreach (int number in output)
            {
                Console.Write(number + " ");
            }*/
        }
    }
}

