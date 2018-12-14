using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_4._ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            var user = new Dictionary<string, List<string>>();

            while (inputLine != "Lumpawaroo")
            {
                

                if (inputLine.Contains("|"))
                {
                    string[] tockens = inputLine.Split(" | " ).ToArray();
                    string forceSide = tockens[0];
                    string forceUser = tockens[1];

                    if (user.ContainsKey(forceSide) == false)
                    {
                        user.Add(forceSide, new List<string>());
                    }
                    if (user.ContainsKey(forceUser) == false)
                    {
                        user[forceSide].Add(forceUser);
                    }
                    else
                    {
                        user[forceSide].Add(forceUser);
                    }


                }
                else if (inputLine.Contains(" -> "))
                {
                    string[] tockens = inputLine.Split(" -> ").ToArray();
                    string forceUser = tockens[0];
                    string forceSide = tockens[1];

                    if (user.ContainsKey(forceUser) == false)
                    {
                        if (user.ContainsKey(forceUser))
                        {
                            user.Remove(forceUser);
                        }

                        if (user.ContainsKey(forceSide)== false)
                        {
                            user.Add(forceSide, new List<string>());
                        }
                        user[forceSide].Add(forceUser);
                    }

                    Console.WriteLine($"{forceUser} joins the Lighter side!");
                }


                inputLine = Console.ReadLine();
            }

            foreach (var kvp in user.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                if (kvp.Value.Count != 0)
                {
                    Console.WriteLine($"Side: {kvp.Key}, Members: {kvp.Value.Count}");

                    foreach (string users in kvp.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"! {users}");
                    }
                }


            }
        }
    }
}
