using System;
using System.Linq;
using System.Collections.Generic;

namespace SoftUniParking
{
    class SoftUniParking
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> registeredUsers = new Dictionary<string, string>();
           
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = input[0];
                string user = input[1];
               

                if (command == "register")
                {
                    string licensePlate = input[2];
                    if (!registeredUsers.ContainsKey(user))
                    {
                        registeredUsers.Add(user, licensePlate);
                        Console.WriteLine($"{user} registered {licensePlate} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlate}");
                    }
                }
                else if (command == "unregister")
                {
                    if (!registeredUsers.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                    }
                    else
                    {
                        registeredUsers.Remove(user);
                        Console.WriteLine($"{user} unregistered successfully");
                    }
                }
            }
            foreach (var user in registeredUsers)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
