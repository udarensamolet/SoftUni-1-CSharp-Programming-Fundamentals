using System;

namespace Calculations
{
    class Calculations
    {
        static void Main()
        {
            string inputOperation = Console.ReadLine().ToLower();
            int inputNumberFirst = int.Parse(Console.ReadLine());
            int inputNumberSecond = int.Parse(Console.ReadLine());

            switch (inputOperation)
            {
                case "add":
                    Add(inputNumberFirst, inputNumberSecond);
                    break;
                case "multiply":
                    Multiply(inputNumberFirst, inputNumberSecond);
                    break;
                case "subtract":
                    Subtract(inputNumberFirst, inputNumberSecond);
                    break;
                case "divide":
                    Divide(inputNumberFirst, inputNumberSecond);
                    break;
            }
        }

        static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        static void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        static void Subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        static void Divide(int a, int b)
        {
            Console.WriteLine(a / b);
        }
    }
}
