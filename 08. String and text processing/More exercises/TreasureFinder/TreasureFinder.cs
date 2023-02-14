using System;
using System.Linq;
using System.Collections.Generic;

namespace TreasureFinder
{
    class TreasureFinder
    {
        static void Main()
        {
            List<int> key = Console.ReadLine()
                  .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse)
                  .ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "find")
                {
                    break;
                }

                List<int> newKey = new List<int>();
                if (key.Count < input.Length)
                {
                    int countKeyFullRepeat = input.Length / key.Count;
                    int countKeyPartRepeat = input.Length - key.Count * countKeyFullRepeat;
                    for (int i = 0; i < countKeyFullRepeat; i++)
                    {
                        newKey.AddRange(key);
                    }
                    for (int i = 0; i < countKeyPartRepeat; i++)
                    {
                        newKey.Add(key[i]);
                    }
                }
                else
                {
                    newKey = key;
                }

                string alteredInput = null;
                for (int i = 0; i < input.Length; i++)
                {
                    int result = (int)input[i] - newKey[i];
                    alteredInput += (char)result;
                }

                int typeStart = alteredInput.IndexOf('&') + 1;
                int typeEnd = alteredInput.LastIndexOf('&');
                int typeLength = typeEnd - typeStart;
                string type = alteredInput.Substring(typeStart, typeLength);

                int coordinatesStart = alteredInput.IndexOf('<') + 1;
                int coordinatesEnd = alteredInput.IndexOf('>');
                int coordinatesLength = coordinatesEnd - coordinatesStart;
                string coordinates = alteredInput.Substring(coordinatesStart, coordinatesLength);

                Console.WriteLine($"Found {type} at {coordinates}");
            }
        }
    }
}
