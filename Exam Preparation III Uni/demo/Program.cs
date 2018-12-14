using System;
using System.Collections.Generic;
using System.Linq;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] account = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string artistAndSongs = Console.ReadLine();
            
            string input = Console.ReadLine();

            Dictionary<string, List<string>> book = new Dictionary<string, List<string>>();

            while (input != "dawn")
            {
                string[] commands = input.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                string user = commands[0];
                string artist = commands[1];
                string awards = commands[2];

                if (artistAndSongs.Contains(artist) && account.Contains(user))
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

                    foreach (var awardss in user.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"--{awardss}");
                    }
                }
                else
                {
                    Console.WriteLine("No awards");
                }
            }

        }
    }
}
