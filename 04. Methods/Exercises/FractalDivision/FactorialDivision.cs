using System;

namespace FactorialDivision
{
    class FactorialDivision
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"{(CalculateFactorial(a) / CalculateFactorial(b)):f2}");

        }

        static double CalculateFactorial(int n)
        {
            double fact = 1;
            while (n > 1)
            {
                fact *= n;
                n--;
            }
            return fact;
        }
    }
}
