using System;

namespace DataTypeFinder
{
    class DataTypeFinder
    {
        static void Main()
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input.ToString() == "END")
                {
                    break;
                }

                int integerValue;
                double doubleValue;
                char charValue;
                bool boolValue;


                if (Int32.TryParse(input, out integerValue))
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (Double.TryParse(input, out doubleValue))
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (Char.TryParse(input, out charValue))
                {
                    Console.WriteLine($"{input} is character type");
                }
                else if (Boolean.TryParse(input, out boolValue))
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }

            }
        }
    }
}
