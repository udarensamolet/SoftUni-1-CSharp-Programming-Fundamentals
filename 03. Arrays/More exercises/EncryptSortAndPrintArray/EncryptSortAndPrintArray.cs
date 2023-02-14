using System;
using System.Linq;

namespace EncryptSortAndPrintArray
{
    class EncryptSortAndPrintArray
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int[] output = new int[n];

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                sum = 0;

                for (int j = 0; j < input.Length; j++)
                {
                    //check if 'y' is a vowel
                    if (input[j] == 'a' || input[j] == 'e' || input[j] == 'i' || input[j] == 'o' || input[j] == 'u'
                        || input[j] == 'A' || input[j] == 'E' || input[j] == 'I' || input[j] == 'O' || input[j] == 'U')
                    {
                        sum += Convert.ToChar(input[j] * input.Length);

                    }
                    else
                    {
                        sum += Convert.ToChar(input[j] / input.Length);

                    }

                }
                output[i] = sum;
            }

            Array.Sort(output);
            foreach (int name in output)
            {
                Console.WriteLine(name);
            }
        }
    }
}
