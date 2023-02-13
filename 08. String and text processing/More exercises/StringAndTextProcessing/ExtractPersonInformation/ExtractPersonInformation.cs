using System;

namespace ExtractPersonInformation
{
    class ExtractPersonInformation
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                int nameStart = input.IndexOf('@') + 1;
                int nameEnd = input.IndexOf('|');
                int nameLength = nameEnd - nameStart;
                string name = input.Substring(nameStart, nameLength);

                int ageStart = input.IndexOf('#') + 1;
                int ageEnd = input.IndexOf('*');
                int ageLength = ageEnd - ageStart;
                int age = Convert.ToInt32(input.Substring(ageStart, ageLength));

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
