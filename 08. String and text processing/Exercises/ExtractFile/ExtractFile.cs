using System;

namespace ExtractFile
{
    class ExtractFile
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string fileName = input.Substring(input.LastIndexOf('\\') + 1, input.LastIndexOf('.') - input.LastIndexOf('\\') - 1);
            string extension = input.Substring(input.IndexOf('.') + 1);
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
