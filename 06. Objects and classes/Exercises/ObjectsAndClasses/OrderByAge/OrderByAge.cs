using System;
using System.Linq;
using System.Collections.Generic;

namespace OrderByAge
{
    class OrderByAge
    {
        static void Main()
        {
            List<Person> people = new List<Person>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                string[] inputData = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = inputData[0];
                string id = inputData[1];
                int age = Convert.ToInt32(inputData[2]);

                Person person = new Person(name, id, age);
                people.Add(person);
            }
            List<Person> sortedByAge = people.OrderBy(x => x.Age).ToList();

            foreach (var person in sortedByAge)
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
            }

        }
    }
}
