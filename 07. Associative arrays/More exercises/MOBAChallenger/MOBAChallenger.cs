using System;
using System.Linq;
using System.Collections.Generic;

namespace MOBAChallenger
{
    class MOBAChallenger
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, int>> playersPositionsSkills = new Dictionary<string, Dictionary<string, int>>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Season end")
                {
                    break;
                }

                string[] tokens = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (tokens.Length == 5)
                {
                    string playerName = tokens[0];
                    string playerPosition = tokens[2];
                    int playerSkill = Convert.ToInt32(tokens[4]);

                    if (!playersPositionsSkills.ContainsKey(playerName))
                    {
                        playersPositionsSkills.Add(playerName, new Dictionary<string, int>());
                        playersPositionsSkills[playerName].Add(playerPosition, playerSkill);
                    }
                    else
                    {
                        if (!playersPositionsSkills[playerName].ContainsKey(playerPosition))
                        {
                            playersPositionsSkills[playerName].Add(playerPosition, playerSkill);
                        }
                        else
                        {
                            if (playersPositionsSkills[playerName][playerPosition] < playerSkill)
                            {
                                playersPositionsSkills[playerName][playerPosition] = playerSkill;
                            }
                        }
                    }
                }
                else if (tokens.Length == 3)
                {
                    string playerOne = tokens[0];
                    string playerTwo = tokens[2];

                    int playerOneSkill = 0;
                    int playerTwoSkill = 0;

                    bool isRemoved = false;

                    if (playersPositionsSkills.ContainsKey(playerOne) && playersPositionsSkills.ContainsKey(playerTwo))
                    {
                        foreach (var skill in playersPositionsSkills[playerOne].Values)
                        {
                            playerOneSkill += skill;
                        }
                        foreach (var skill in playersPositionsSkills[playerTwo].Values)
                        {
                            playerTwoSkill += skill;
                        }

                        foreach (var position in playersPositionsSkills[playerOne])
                        {
                            string pos = position.Key;
                            if (playersPositionsSkills[playerTwo].ContainsKey(pos))
                            {
                                if (playerOneSkill > playerTwoSkill)
                                {
                                    playersPositionsSkills.Remove(playerTwo);
                                    isRemoved = true;
                                    break;
                                }
                                else if (playerOneSkill < playerTwoSkill)
                                {
                                    playersPositionsSkills.Remove(playerOne);
                                    isRemoved = true;
                                    break;
                                }
                            }
                            if (isRemoved)
                            {
                                break;
                            }
                        }
                    }
                }
            }
            Dictionary<string, int> playersTotalSkill = new Dictionary<string, int>();
            foreach (var player in playersPositionsSkills)
            {
                int totalSkill = 0;
                foreach (var position in player.Value)
                {
                    totalSkill += position.Value;
                }
                playersTotalSkill.Add(player.Key, totalSkill);
            }

            foreach (var player in playersTotalSkill.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value} skill");
                foreach (var playerPosition in playersPositionsSkills)
                {
                    foreach (var position in playerPosition.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                    {
                        if (player.Key == playerPosition.Key)
                        {
                            Console.WriteLine($"- {position.Key} <::> {position.Value}");
                        }
                    }
                }
            }
        }
    }
}
