using System;
using System.Linq;
using System.Collections.Generic;

namespace CompanyUsers
{
    class CompanyUsers
    {
        static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Dictionary<string, List<string>> companiesEmployeesLists = new Dictionary<string, List<string>>();

            while (true)
            {
                if (input[0] == "End")
                {
                    break;
                }

                string company = input[0];
                string employee = input[1];

                if (!companiesEmployeesLists.ContainsKey(company))
                {
                    companiesEmployeesLists.Add(company, new List<string>());
                    companiesEmployeesLists[company].Add(employee);
                }
                else
                {
                    if (!companiesEmployeesLists[company].Contains(employee))
                    {
                        companiesEmployeesLists[company].Add(employee);
                    }
                }

                input = Console.ReadLine()
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }

            foreach (var company in companiesEmployeesLists)
            {
                Console.WriteLine($"{company.Key}");
                foreach (var id in company.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }

            /*foreach (var company in companiesEmployeesLists.OrderBy(c => c.Key))
            {
                Console.WriteLine($"{company.Key}");
                foreach (var id in company.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }*/
        }
    }
}
