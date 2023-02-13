using System;

namespace MultiplyEvensByOdds
{
    class MultiplyEvensByOdds
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMultiple(GetSumEvens(n), GetSumOdds(n)));

        }
        static int GetSumEvens(int n)
        {
            int nAbs = Math.Abs(n);
            int sum = 0;
            int lastDigit = 0;

            while (nAbs > 0)
            {
                lastDigit = nAbs % 10;
                nAbs /= 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
            }
            return sum;
        }

        static int GetSumOdds(int n)
        {
            int nAbs = Math.Abs(n);
            int sum = 0;
            int lastDigit = 0;

            while (nAbs > 0)
            {
                lastDigit = nAbs % 10;
                nAbs /= 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }
            }
            return sum;
        }

        static int GetMultiple(int evens, int odds)
        {
            return evens * odds;
        }
    }
}
