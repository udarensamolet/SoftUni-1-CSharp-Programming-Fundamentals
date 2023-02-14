using System;
using System.Linq;
using System.Collections.Generic;

namespace Judge
{
    class Judge
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, int>> contestsUsersPoints = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> participantsPoints = new Dictionary<string, int>();

            while (true)
            {
                string[] input = Console.ReadLine()
                   .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                   .ToArray();

                if (input[0] == "no more time")
                {
                    break;
                }

                string user = input[0];
                string contest = input[1];
                int points = Convert.ToInt32(input[2]);

                if (!contestsUsersPoints.ContainsKey(contest))
                {
                    contestsUsersPoints.Add(contest, new Dictionary<string, int>());
                    contestsUsersPoints[contest].Add(user, points);
                }
                else
                {
                    if (!contestsUsersPoints[contest].ContainsKey(user))
                    {
                        contestsUsersPoints[contest].Add(user, points);
                    }
                    else
                    {
                        if (contestsUsersPoints[contest][user] < points)
                        {
                            contestsUsersPoints[contest][user] = points;
                        }
                    }
                }
            }

            foreach (var contest in contestsUsersPoints)
            {
                foreach (var participant in contest.Value)
                {
                    if (!participantsPoints.ContainsKey(participant.Key))
                    {
                        participantsPoints.Add(participant.Key, participant.Value);
                    }
                    else
                    {
                        participantsPoints[participant.Key] += participant.Value;
                    }
                }
            }

            foreach (var contest in contestsUsersPoints)
            {
                int i = 1;
                Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");
                foreach (var participant in contest.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{i}. {participant.Key} <::> {participant.Value}");
                    i++;
                }
            }

            Console.WriteLine("Individual standings:");
            int j = 1;
            foreach (var participant in participantsPoints.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{j}. {participant.Key} -> {participant.Value}");
                j++;
            }
        }
    }
}
