using System;
using System.Numerics;

namespace FromLeftToRight
{
    class FromLeftToRight
    {
        static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            string input;

            for (int i = 0; i < lines; i++)
            {
                input = Console.ReadLine();
                string[] numbers = input.Split(' ');
                BigInteger numberLeft = BigInteger.Parse(numbers[0]);
                BigInteger numberRight = BigInteger.Parse(numbers[1]);

                BigInteger sum = 0;
                if (numberLeft > numberRight)
                {
                    numberLeft = BigInteger.Abs(numberLeft);
                    while (numberLeft > 0)
                    {
                        sum += (numberLeft % 10);
                        numberLeft /= 10;
                    }
                    Console.WriteLine(BigInteger.Abs(sum));
                }
                else
                {
                    numberRight = BigInteger.Abs(numberRight);
                    while (numberRight > 0)
                    {
                        sum += (numberRight % 10);
                        numberRight /= 10;
                    }
                    Console.WriteLine(BigInteger.Abs(sum));
                }
            }
        }
    }
}