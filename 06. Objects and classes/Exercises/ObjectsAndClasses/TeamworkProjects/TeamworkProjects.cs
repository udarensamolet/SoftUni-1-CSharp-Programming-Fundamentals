using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamworkProjects
{
    class TeamworkProjects
    {
        static void Main()
        {
            int teamsCount = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < teamsCount; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split('-', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string creator = tokens[0];
                string name = tokens[1];

                bool isCreatorExistent = false;
                foreach (var team in teams)
                {
                    if (team.Creator == creator)
                    {
                        Console.WriteLine($"{creator} cannot create another team!");
                        isCreatorExistent = true;
                        break;
                    }
                }

                bool isTeamExistent = false;
                foreach (var team in teams)
                {
                    if (team.Name == name)
                    {
                        Console.WriteLine($"Team {name} was already created!");
                        isTeamExistent = true;
                        break;
                    }
                }

                if (!isCreatorExistent && !isTeamExistent)
                {
                    Team team = new Team(name, creator);
                    teams.Add(team);
                    Console.WriteLine($"Team {name} has been created by {creator}!");
                }
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of assignment")
                {
                    break;
                }

                string[] tokens = input
                    .Split("->", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string member = tokens[0];
                string teamName = tokens[1];

                bool isTeamExistent = false;
                foreach (var team in teams)
                {
                    if (team.Name == teamName)
                    {
                        isTeamExistent = true;
                        break;
                    }
                }
                if (!isTeamExistent)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }

                bool isMemberCreator = false;
                foreach (var team in teams)
                {
                    if (team.Creator == member)
                    {
                        Console.WriteLine($"Member {member} cannot join team {teamName}!");
                        isMemberCreator = true;
                        break;
                    }
                }

                bool isMemberInAnotherTeam = false;
                foreach (var team in teams)
                {
                    foreach (var memberName in team.Members)
                    {
                        if (memberName == member)
                        {
                            Console.WriteLine($"Member {member} cannot join team {teamName}!");
                            isMemberInAnotherTeam = true;
                            break;
                        }
                    }
                }

                if (isTeamExistent && !isMemberCreator && !isMemberInAnotherTeam)
                {
                    var targetTeam = teams.FirstOrDefault(x => x.Name == teamName);
                    targetTeam.Members.Add(member);
                }
            }

            foreach (var team in teams
                .OrderByDescending(x => x.Members.Count)
                .ThenBy(x => x.Name)
                .Where(x => x.Members.Any()))
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.Creator}");
                foreach (var member in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
            Console.WriteLine("Teams to disband:");
            foreach (var team in teams.OrderBy(x => x.Name).Where(x => !x.Members.Any()))
            {
                Console.WriteLine($"{team.Name}");
            }
        }
    }
}