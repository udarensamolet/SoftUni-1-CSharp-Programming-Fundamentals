using System;
using System.Numerics;

namespace BigFactorial
{
    class BigFactorial
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;

            while (n > 0)
            {
                factorial *= n;
                n--;
            }

            Console.WriteLine(factorial);
        }
    }
}
