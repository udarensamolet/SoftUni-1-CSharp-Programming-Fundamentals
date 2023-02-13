using System;
using System.Linq;

namespace DataTypes
{
    class DataTypes
    {
        static void Main()
        {
            string input = Console.ReadLine();
            switch (input)
            {
                case "int":
                    IntInput();
                    break;
                case "real":
                    DoubleInput();
                    break;
                case "string":
                    StringInput();
                    break;
            }
        }

        static void IntInput()
        {
            int input = int.Parse(Console.ReadLine());
            int result = input * 2;

            Console.WriteLine(result);
        }

        static void DoubleInput()
        {
            double input = double.Parse(Console.ReadLine());
            double result = input * 1.5;
            Console.WriteLine($"{result:f2}");
        }

        static void StringInput()
        {
            string input = Console.ReadLine();
            Console.WriteLine($"${input}$");
        }
    }
}
