using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_4._MOBA_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var players = new Dictionary<string, SortedDictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "Season end")
            {
                List<string> inputType = new List<string>();
                if (input.Contains("->"))
                {
                    inputType = input.Split(" -> ").ToList();
                }
                else if (input.Contains("vs"))
                {
                    inputType = input.Split(" vs ").ToList();
                }
                if (inputType.Count == 3)
                {
                    string playerName = inputType[0];
                    string position = inputType[1];
                    int skill = int.Parse(inputType[2]);
                    if (players.ContainsKey(playerName) == false)
                    {
                        players.Add(playerName, new SortedDictionary<string, int>());
                    }
                    if (players[playerName].ContainsKey(position) == false)
                    {
                        players[playerName].Add(position, skill);
                    }
                    else
                    {
                        if (skill > players[playerName][position])
                        {
                            players[playerName][position] = skill;
                        }
                    }
                }
                //else if (inputType.Count == 2)
                //{
                //    string firstPlayer = inputType[0];
                //    string secondPlayer = inputType[1];

                //    if (players.ContainsKey(firstPlayer) && players.ContainsKey(secondPlayer))
                //    {
                //        string[] firstPLayersPosition = players[firstPlayer].Keys.ToArray();

                //        foreach (var p in players[secondPlayer].Keys)
                //        {
                //            if (firstPLayersPosition.Contains(p))
                //            {
                //                int totalSkillsFirstPlayers = players[firstPlayer].Values.Sum();
                //                int totalSkillsSecondPlayers = players[secondPlayer].Values.Sum();
                //                if (totalSkillsFirstPlayers > totalSkillsSecondPlayers)
                //                {
                //                    players.Remove(secondPlayer);
                //                }
                //                else if(totalSkillsSecondPlayers > totalSkillsFirstPlayers)
                //                {
                //                    players.Remove(firstPlayer);
                //                }
                //            }
                //        }
                //    }
                //}

                input = Console.ReadLine();
            }
            foreach (var p in players.OrderByDescending(p => p.Value.Values.Sum()).ThenBy(n => n.Key))
            {
                Console.WriteLine($"{p.Key}: {p.Value.Values.Sum()} skill");

                foreach (var pos in p.Value.OrderByDescending(x => x.Value).ThenBy(x=>x.Key))
                {
                    Console.WriteLine($"- {pos.Key} <::> {pos.Value}");
                }
            }
        }
    }
}
