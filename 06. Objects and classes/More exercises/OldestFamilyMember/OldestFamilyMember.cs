using System;
using System.Collections.Generic;

namespace OldestFamilyMember
{
    class OldestFamilyMember
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Family family = new Family();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = input[0];
                int age = Convert.ToInt32(input[1]);
                Person person = new Person(name, age);
                family.AddMember(person);
            }
            Console.WriteLine($"{family.GetOldestMember().Name} {family.GetOldestMember().Age}");
        }
    }