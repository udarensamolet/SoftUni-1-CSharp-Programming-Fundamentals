using System;

namespace TribonacciSequnce
{
    class TribonacciSequence
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            Trinonacci(num);
        }

        static void Trinonacci(int n)
        {
            int[] arr = new int[n];

            if (n == 1)
            {
                arr[0] = 1;
                Console.WriteLine(string.Join(" ", arr));
            }
            else if (n == 2)
            {
                arr[0] = 1;
                arr[1] = 1;
                Console.WriteLine(string.Join(" ", arr));
            }
            else if (n == 3)
            {
                arr[0] = 1;
                arr[1] = 1;
                arr[2] = 2;
                Console.WriteLine(string.Join(" ", arr));
            }
            else
            {
                arr[0] = 1;
                arr[1] = 1;
                arr[2] = 2;
                for (int i = 3; i < n; i++)
                {
                    arr[i] = arr[i - 1] + arr[i - 2] + arr[i - 3];
                }
                Console.WriteLine(string.Join(" ", arr));
            }
        }
    }
}
