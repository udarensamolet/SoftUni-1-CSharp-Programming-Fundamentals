using System;

namespace FloatingEquality
{
    class FloatingEquality
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double eps = 0.000001;

            if (Math.Abs(Math.Abs(a) - Math.Abs(b)) < eps)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
