using System;


namespace ReverseStrings
{
    class ReverseStrings
    {
        static void Main()
        {
            string input = Console.ReadLine();
            while (true)
            {
                if (input == "end")
                {
                    break;
                }
                string reversedString = null;
                char[] charArray = input.ToCharArray();

                for (int i = charArray.Length - 1; i >= 0; i--)
                {
                    reversedString += charArray[i];
                }

                Console.WriteLine($"{input} = {reversedString}");
                input = Console.ReadLine();
            }
        }
    }
}
