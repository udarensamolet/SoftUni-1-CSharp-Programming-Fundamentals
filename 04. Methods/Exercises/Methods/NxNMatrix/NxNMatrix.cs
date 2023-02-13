using System;

namespace NxNMatrix
{
    class NxNMatrix
    {
        static void Main()
        {
            PrintMatrix(int.Parse(Console.ReadLine()));
        }

        static void PrintMatrix(int n)
        {
            for (int rows = 0; rows < n; rows++)
            {
                for (int cols = 0; cols < n; cols++)
                {
                    Console.Write($"{n} ");
                }
                Console.WriteLine();
            }
        }
    }
}
