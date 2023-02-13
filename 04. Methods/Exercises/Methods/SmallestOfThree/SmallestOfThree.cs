using System;

namespace SmallestOfThreeNumbers
{
    class SmallestOfThreeNumbers
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(FindSmallestOfThreeNumbers(a, b, c));
        }

        static int FindSmallestOfThreeNumbers(int a, int b, int c)
        {
            int smallest = 0;

            if (a <= b && a <= c)
            {
                smallest = a;
            }
            else if (b <= a && b <= c)
            {
                smallest = b;
            }
            else if (c <= a && c <= b)
            {
                smallest = c;
            }

            return smallest;
        }
    }
}
