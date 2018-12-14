using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputGames = Console.ReadLine().Split().ToArray();
            List<string> gameList = new List<string>(inputGames);

            string[] tockens = Console.ReadLine().Split().ToArray();
            string expansion = " ";
            string edint = " : ";



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
                    string pattern = @"([A-Za-z]+)(-)([A-Za-z]+)";
                    Match matchs = Regex.Match(commands, pattern);


                    for (int i = 0; i < gameList.Count; i++)
                    {
                        if (Regex.IsMatch(commands, pattern))
                        {
                            expansion = gameList[i];

                            if (matchs.Groups[1].Value == expansion)
                            {

                                for (int j = 0; j < expansion.Length; j++)
                                {

                                    if (expansion[i] == '-')
                                    {

                                        expansion[i] = ':'.ToString();
                                    }
                                }
                            }
                        }
                    }
                }


                tockens = Console.ReadLine().Split().ToArray();

            }
            Console.WriteLine(string.Join(" ", gameList));
        }
    }
    }
}
