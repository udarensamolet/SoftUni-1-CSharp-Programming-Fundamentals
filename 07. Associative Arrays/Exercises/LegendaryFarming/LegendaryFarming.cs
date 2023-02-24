using System;
using System.Linq;
using System.Collections.Generic;

namespace LegendaryFarming
{
    class LegendaryFarming
    {
        static void Main()
        {
            Dictionary<string, int> materials = new Dictionary<string, int>();
            Dictionary<string, int> junks = new Dictionary<string, int>();

            string obtainedMaterial = null;
            bool isObtained = false;

            string[] input = Console.ReadLine()
                    .ToLower()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.ToLower())
                    .ToArray();

            while (true)
            {
                for (int i = 1; i < input.Length; i += 2)
                {
                    if (input[i] == "shards" || input[i] == "fragments" || input[i] == "motes")
                    {
                        if (!materials.ContainsKey(input[i]))
                        {
                            materials.Add(input[i], Convert.ToInt32(input[i - 1]));
                        }
                        else
                        {
                            materials[input[i]] += Convert.ToInt32(input[i - 1]);
                        }
                    }
                    else
                    {
                        if (!junks.ContainsKey(input[i]))
                        {
                            junks.Add(input[i], Convert.ToInt32(input[i - 1]));
                        }
                        else
                        {
                            junks[input[i]] += Convert.ToInt32(input[i - 1]);
                        }
                    }

                    foreach (var material in materials)
                    {
                        if (material.Value >= 250)
                        {
                            if (material.Key == "shards")
                            {
                                obtainedMaterial = "shards";
                                isObtained = true;
                                Console.WriteLine($"Shadowmourne obtained!");
                                break;
                            }
                            else if (material.Key == "fragments")
                            {
                                obtainedMaterial = "fragments";
                                isObtained = true;
                                Console.WriteLine($"Valanyr obtained!");
                                break;
                            }
                            else if (material.Key == "motes")
                            {
                                obtainedMaterial = "motes";
                                isObtained = true;
                                Console.WriteLine($"Dragonwrath obtained!");
                                break;
                            }                               
                        }
                    }
                    if (isObtained)
                    {
                        break;
                    }
                }
                if (isObtained)
                {
                    break;
                }
                input = Console.ReadLine()
                    .ToLower()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }

            materials[obtainedMaterial] -= 250;
            foreach (var material in materials)
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }

            foreach (var junk in junks)
            {
                Console.WriteLine($"{junk.Key}: {junk.Value}");
            }
        }
    }
}
