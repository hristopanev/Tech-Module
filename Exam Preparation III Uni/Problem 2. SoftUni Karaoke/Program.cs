using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2._SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] account = Console.ReadLine().Split(", ");
            string[] songs = Console.ReadLine().Split( ", " , StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<string> artistAndSongsInputLine = new List<string>();
            List<string> artistsInputLine = new List<string>();
            for (int i = 0; i < songs.Length; i++)
            {
                artistAndSongsInputLine = songs[i].Split(" - ",StringSplitOptions.RemoveEmptyEntries).ToList();
                artistsInputLine.Add(artistAndSongsInputLine[0]);
            }

            string input = Console.ReadLine();

            Dictionary<string, List<string>> book = new Dictionary<string, List<string>>();

            while (input != "dawn")
            {
                string[] commands = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string user = commands[0];
                string[] artist = commands[1].Split(" - ",StringSplitOptions.RemoveEmptyEntries);
                string awards = commands[2];

                if (artistsInputLine.Contains(artist[0]))
                {
                    if (book.ContainsKey(user) == false)
                    {
                        book.Add(user, new List<string>());
                    }
                    if (book.ContainsKey(user))
                    {
                        if (book[user].Contains(awards) == false)
                        {
                            book[user].Add(awards);
                        }

                    }
                    else if (book.ContainsKey(user))
                    {
                        book[user].Add(awards);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var user in book.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                if (user.Value.Count != 0)
                {
                    Console.WriteLine($"{user.Key}: {user.Value.Count} awards");

                    foreach (var awardss in user.Value.OrderBy(x=>x))
                    {
                        Console.WriteLine($"--{awardss}");
                    }
                }
            }

        }
    }
}
