using System;
using System.Collections.Generic;
using System.Linq;

namespace HouseParty
{
    class HouseParty
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (commands[2] == "going!")
                {
                    if (!guests.Contains(commands[0]))
                    {
                        guests.Add(commands[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{commands[0]} is already in the list!");
                    }
                }
                else if (commands[2] == "not")
                {
                    if (guests.Contains(commands[0]))
                    {
                        guests.Remove(commands[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{commands[0]} is not in the list!");
                    }
                }
            }

            foreach (string guest in guests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
