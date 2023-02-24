using System;
using System.Linq;
using System.Collections.Generic;

namespace AMinerTask
{
    class AMinerTask
    {
        static void Main()
        {

            string resource = Console.ReadLine();
            Dictionary<string, int> resources = new Dictionary<string, int>();

            while (resource != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!resources.ContainsKey(resource))
                {
                    resources.Add(resource, quantity);
                }
                else
                {
                    resources[resource] += quantity;
                }
                resource = Console.ReadLine();
            }

            foreach (var res in resources)
            {
                Console.WriteLine($"{res.Key} -> {res.Value}");
            }
        }
    }
}
