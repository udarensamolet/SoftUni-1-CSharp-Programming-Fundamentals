using System;
using System.Collections.Generic;
using System.Linq;


namespace Train
{
    class Train
    {
        static void Main()
        {
            List<int> wagons = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int capacity = int.Parse(Console.ReadLine());

            while (true)
            {
                string[] commands = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
                if (commands[0] == "end")
                {
                    Console.WriteLine(string.Join(" ", wagons));
                    break;
                }
                else if (commands[0] == "Add")
                {
                    wagons.Add(Convert.ToInt32(commands[1]));
                }
                else
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (Convert.ToInt32(commands[0]) <= capacity - wagons[i])
                        {
                            wagons[i] += Convert.ToInt32(commands[0]);
                            break;
                        }
                    }
                }
            }
        }
    }
}
