using System;
using System.Linq;


namespace CenterPoint
{
    class CenterPoint
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            if (GetMinValue(CalculateDistanceToCenter(x1, y1), CalculateDistanceToCenter(x2, y2)))
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }

        }


        static double CalculateDistanceToCenter(double a, double b)
        {
            double distance = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            return distance;
        }

        static bool GetMinValue(double a, double b)
        {
            bool isFirstGreater;
            if (a <= b)
            {
                isFirstGreater = true;
            }
            else
            {
                isFirstGreater = false;
            }
            return isFirstGreater;
        }
    }
}
