using System;

namespace TopNumber
{
    class TopNumber
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i < input; i++)
            {
                PrintTopNumber(CheckSumDigits(i), CheckOddDigits(i), i);
            }

        }

        static bool CheckSumDigits(int n)
        {
            bool isSumDivisibleBy8 = true;
            int sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }

            if (sum % 8 != 0)
            {
                isSumDivisibleBy8 = false;
            }
            return isSumDivisibleBy8;
        }

        static bool CheckOddDigits(int n)
        {
            bool areOddDigits = true;
            int lastDigit = 0;
            int countOddDigits = 0;
            while (n > 0)
            {
                lastDigit = n % 10;
                if (lastDigit % 2 != 0)
                {
                    countOddDigits++;
                }
                n /= 10;
            }

            if (countOddDigits == 0)
            {
                areOddDigits = false;
            }

            return areOddDigits;
        }

        static void PrintTopNumber(bool a, bool b, int n)
        {
            if (a && b)
            {
                Console.WriteLine(n);
            }
        }
    }
}
