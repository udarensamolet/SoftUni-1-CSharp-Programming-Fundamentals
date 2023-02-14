using System;

namespace LongerLine
{
    class LongerLine
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            if (GetLongerLine(CalculateLineLength(x1, y1, x2, y2), CalculateLineLength(x3, y3, x4, y4)))
            {
                if (GetMinValue(CalculateDistanceToCenter(x1, y1), CalculateDistanceToCenter(x2, y2)))
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else
            {
                if (GetMinValue(CalculateDistanceToCenter(x3, y3), CalculateDistanceToCenter(x4, y4)))
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
        }

        static double CalculateLineLength(double a, double b, double c, double d)
        {
            double length = Math.Sqrt(Math.Pow((c - a), 2) + Math.Pow((d - b), 2));
            return length;
        }

        static bool GetLongerLine(double a, double b)
        {
            bool isFirstGreater = false;
            if (a > b)
            {
                isFirstGreater = true;
            }
            return isFirstGreater;
        }

        static double CalculateDistanceToCenter(double a, double b)
        {
            double distance = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            return distance;
        }

        static bool GetMinValue(double a, double b)
        {
            bool isFirstGreater = false;
            if (a <= b)
            {
                isFirstGreater = true;
            }
            return isFirstGreater;
        }

    }
}
