using System;
using System.Collections.Generic;
using System.Linq;

namespace DrumSet
{
    class DrumSet
    {
        static void Main()
        {
            double savings = double.Parse(Console.ReadLine());
            List<int> drumsInitialQuality = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> drumsQuality = drumsInitialQuality.ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Hit it again, Gabsy!")
                {
                    break;
                }
                else
                {
                    int hitPower = Convert.ToInt32(input);
                    for (int i = 0; i < drumsQuality.Count; i++)
                    {
                        drumsQuality[i] -= hitPower;
                        if (drumsQuality[i] <= 0)
                        {
                            int priceBrokenDrum = drumsInitialQuality[i] * 3;
                            if (savings >= priceBrokenDrum)
                            {
                                drumsQuality[i] = drumsInitialQuality[i];
                                savings -= priceBrokenDrum;
                            }
                            else
                            {
                                drumsQuality.Remove(drumsQuality[i]);
                                drumsInitialQuality.Remove(drumsInitialQuality[i]);
                                i--;
                            }
                        }
                    }
                }
                //Console.WriteLine(string.Join(" ", drumsQuality));
            }
            Console.WriteLine(string.Join(" ", drumsQuality));
            Console.WriteLine($"Gabsy has {savings:f2}lv.");
        }
    }
}
