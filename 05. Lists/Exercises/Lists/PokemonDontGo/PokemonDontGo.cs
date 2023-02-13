using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonDontGo
{
    class PokemonDontGo
    {
        static void Main()
        {
            List<int> distances = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();
            int sumRemovedElements = 0;

            while (distances.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());

                if (index >= 0 && index < distances.Count)
                {
                    for (int i = 0; i < distances.Count; i++)
                    {
                        if (index != i)
                        {
                            if (distances[i] <= distances[index])
                            {
                                distances[i] += distances[index];
                            }
                            else if (distances[i] > distances[index])
                            {
                                distances[i] -= distances[index];
                            }
                        }
                    }
                    sumRemovedElements += distances[index];
                    distances.RemoveAt(index);
                }

                else if (index < 0)
                {
                    for (int i = 0; i < distances.Count; i++)
                    {
                        if (i != 0)
                        {
                            if (distances[i] <= distances[0])
                            {
                                distances[i] += distances[0];
                            }
                            else if (distances[i] > distances[0])
                            {
                                distances[i] -= distances[0];
                            }
                        }
                    }
                    sumRemovedElements += distances[0];
                    distances[0] = distances[distances.Count - 1];
                }

                else if (index > distances.Count - 1)
                {
                    for (int i = 0; i < distances.Count; i++)
                    {
                        if (i != distances.Count - 1)
                        {
                            if (distances[i] <= distances[distances.Count - 1])
                            {
                                distances[i] += distances[distances.Count - 1];
                            }
                            else if (distances[i] > distances[distances.Count - 1])
                            {
                                distances[i] -= distances[distances.Count - 1];
                            }
                        }
                    }
                    sumRemovedElements += distances[distances.Count - 1];
                    distances[distances.Count - 1] = distances[0];
                }
            }
            Console.WriteLine(sumRemovedElements);
        }
    }
}
