using System;


namespace PrintingTriangle
{
    class PrintingTriangle
    {
        static void Main()
        {
            PrintTriangle(int.Parse(Console.ReadLine()));
        }

        static void PrintMiddleLine(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        static void PrintTopHalf(int n)
        {
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col < row; col++)
                {
                    Console.Write($"{col} ");
                }
                Console.WriteLine();
            }
        }

        static void PrintBottomHalf(int n)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 1; col < n - row; col++)
                {
                    Console.Write($"{col} ");
                }
                Console.WriteLine();
            }
        }

        static void PrintTriangle(int n)
        {
            PrintTopHalf(n);
            PrintMiddleLine(n);
            PrintBottomHalf(n);
        }
    }
}
