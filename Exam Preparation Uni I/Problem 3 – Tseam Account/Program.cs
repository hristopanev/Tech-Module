using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem_3___Tseam_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputGames = Console.ReadLine().Split().ToArray();
            List<string> gameList = new List<string>(inputGames);
            string[] tockens = Console.ReadLine().Split().ToArray();
            
            while (tockens[0] != "Play!")
            {
                string commands = tockens[0];
                string game = tockens[1];

                if (commands == "Install")
                {
                    if (gameList.Contains(game) == false)
                    {
                        gameList.Add(game);
                    }
                    
                }
                else if (commands == "Uninstall")
                {
                    if (gameList.Contains(game))
                    {
                        gameList.Remove(game);
                    }
                }
                else if (commands == "Update")
                {
                    if (gameList.Contains(game) == true)
                    {
                        gameList.Remove(game);
                        gameList.Add(game);
                    }
                }
                else if (commands == "Expansion")
                {
                    string[] expansion = game.Split("-");
                    int index = gameList.IndexOf(expansion[0]);
                    if (gameList.Contains(expansion[0]))
                    {
                        gameList.Insert(index + 1, string.Join(":", expansion));
                    }
                }

                tockens = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine(string.Join(" ", gameList));
        }

        
    }
}
