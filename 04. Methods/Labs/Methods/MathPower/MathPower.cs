using System;

namespace MathPower
{
    class MathPower
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine(CalculateMathPower(a, b));
        }

        static double CalculateMathPower(double a, double b)
        {
            return Math.Pow(a, b);
        }
    }
}
