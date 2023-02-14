using System;
using System.Linq;
using System.Collections.Generic;

namespace SnowWhite
{
    class SnowWhite
    {
        static void Main()
        {
            List<Dwarf> dwarves = new List<Dwarf>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Once upon a time")
                {
                    break;
                }
                string[] tokens = input
                    .Split(" <:> ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string dwarfName = tokens[0];
                string dwarfHatColor = tokens[1];
                int dwarfPhysics = Convert.ToInt32(tokens[2]);

                Dwarf targetDwarf = dwarves.FirstOrDefault(x => x.Name == dwarfName && x.Color == dwarfHatColor);

                if (targetDwarf == null)
                {
                    Dwarf newDwarf = new Dwarf(dwarfName, dwarfHatColor, dwarfPhysics);
                    dwarves.Add(newDwarf);
                }
                else
                {
                    targetDwarf.Physics = Math.Max(targetDwarf.Physics, dwarfPhysics);
                }
            }

            foreach (var dwarf in dwarves
                .OrderByDescending(x => x.Physics) // order the dwarves by physics in descending order
                .ThenByDescending(x => dwarves.Count(y => y.Color == x.Color))) // and by total count of dwarves
            {
                Console.WriteLine($"({dwarf.Color}) {dwarf.Name} <-> {dwarf.Physics}");
            }
        }
    }
}
 