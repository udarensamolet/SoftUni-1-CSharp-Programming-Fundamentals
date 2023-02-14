using System;
using System.Numerics;

namespace MultiplyBigNumber
{
    class MultiplyBigNumber
    {
        static void Main()
        {
            BigInteger input = BigInteger.Parse(Console.ReadLine());
            byte multiplier = byte.Parse(Console.ReadLine());

            Console.WriteLine(input * multiplier);
        }
    }
}
