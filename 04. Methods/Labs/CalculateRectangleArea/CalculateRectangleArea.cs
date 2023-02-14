using System;

namespace CalculateRectangleArea
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine(CalculateRectangleArea(a, b));
        }

        static double CalculateRectangleArea(double a, double b)
        {
            double area = a * b;
            return area;
        }
    }
}
