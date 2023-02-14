using System;
using System.Linq;
using System.Collections.Generic;

namespace SoftUniExamResults
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine()
                .Split('-', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            //Dictionary<string, Dictionary<string, List<int>>> results = new Dictionary<string, Dictionary<string, List<int>>>();
            //Dictionary<string, Dictionary<string, List<int>>> resultsCopy = new Dictionary<string, Dictionary<string, List<int>>>();

            Dictionary<string, int> examSubmissions = new Dictionary<string, int>();
            Dictionary<string, int> studentsPoints = new Dictionary<string, int>();

            while (true)
            {
                if (input[0] == "exam finished")
                {
                    break;
                }

                if (input.Length == 3)
                {
                    string username = input[0];
                    string language = input[1];
                    int points = Convert.ToInt32(input[2]);


                    if (!studentsPoints.ContainsKey(username))
                    {
                        studentsPoints.Add(username, points);
                        if (!examSubmissions.ContainsKey(language))
                        {
                            examSubmissions.Add(language, 1);
                        }
                        else
                        {
                            examSubmissions[language]++;
                        }
                    }
                    else
                    {
                        if (studentsPoints[username] < points)
                        {
                            studentsPoints[username] = points;
                        }

                        if (!examSubmissions.ContainsKey(language))
                        {
                            examSubmissions.Add(language, 1);
                        }
                        else
                        {
                            examSubmissions[language]++;
                        }
                    }
                }
                else if (input.Length == 2)
                {
                    string usernameRemove = input[0];
                    if (studentsPoints.ContainsKey(usernameRemove))
                    {
                        studentsPoints.Remove(usernameRemove);
                    }
                }


                /*resultsCopy.Clear();
                foreach (var item in results)
                {
                    resultsCopy.Add(item.Key, item.Value);
                }


                if (input.Length == 3)
                {
                    string username = input[0];
                    string language = input[1];
                    int points = Convert.ToInt32(input[2]);

                    if (!results.ContainsKey(language))
                    {
                        results.Add(language, new Dictionary<string, List<int>>());
                        if (!results[language].ContainsKey(username))
                        {
                            results[language].Add(username, new List<int>());
                            results[language][username].Add(points);
                        }
                        else
                        {
                            results[language][username].Add(points);
                        }
                    }
                    else
                    {
                        if (!results[language].ContainsKey(username))
                        {
                            results[language].Add(username, new List<int>());
                            results[language][username].Add(points);
                        }
                        else
                        {
                            results[language][username].Add(points);
                        }
                    }
                }
                else if (input.Length == 2)
                {
                    string usernameRemove = input[0];
                    string languageToBeAltered = null;

                    foreach (var exam in results)
                    {
                        foreach (var person in exam.Value)
                        {
                            if (person.Key == usernameRemove)
                            {
                                languageToBeAltered = exam.Key;
                                if (!results.ContainsKey("Banned users"))
                                {
                                    resultsCopy[languageToBeAltered].Add("Banned users", new List<int>());
                                    resultsCopy[languageToBeAltered]["Banned users"] = resultsCopy[languageToBeAltered][usernameRemove].ToList();
                                    resultsCopy[languageToBeAltered].Remove(usernameRemove);
                                }
                                else
                                {
                                    resultsCopy[languageToBeAltered]["Banned users"] = resultsCopy[languageToBeAltered][usernameRemove].ToList();
                                    resultsCopy[languageToBeAltered].Remove(usernameRemove);
                                }
                            }
                        }
                    }
                    results.Clear();
                    foreach (var item in resultsCopy)
                    {
                        results.Add(item.Key, item.Value);
                    }
                }*/

                input = Console.ReadLine()
                    .Split('-', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }

            Console.WriteLine("Results:");
            foreach (var student in studentsPoints.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{student.Key} | {student.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var exam in examSubmissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{exam.Key} - {exam.Value}");
            }
        }
    }
}
