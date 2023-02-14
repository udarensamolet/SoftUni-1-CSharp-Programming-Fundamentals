using System;

namespace RecursiveFibonacci
{
    class RecursiveFibonacci
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] sequence = new int[n];


            for (int i = 0; i < n; i++)
            {
                sequence[i] = GetFibonacci(n);
            }

            Console.WriteLine(sequence[n - 1]);
        }

        static int GetFibonacci(int n)
        {
            if (n <= 2)
            {
                return 1;
            }
            else
            {
                return GetFibonacci(n - 1) + GetFibonacci(n - 2);
            }
        }
    }
}
