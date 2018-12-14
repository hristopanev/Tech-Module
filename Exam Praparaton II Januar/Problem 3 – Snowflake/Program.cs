﻿using System;
using System.Text.RegularExpressions;

namespace Problem_3___Snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            var surface = new Regex(@"^[^A-Za-z0-9]+$");
            var mantel = new Regex(@"^[0-9_]+$");
            var middle = new Regex(@"^[^A-Za-z0-9]+[0-9_]+(?<core>[A-Za-z]+)+[0-9_]+[^A-Za-z0-9]+$");

            int length = 0;

            for (int i = 0; i < 5; i++)
            {
                string line = Console.ReadLine();

                if (i == 0 ||i == 4)
                {
                    Validate(surface, line);
                }
                else if (i == 1 || i == 3)
                {
                    Validate(mantel, line);
                }
                else
                {
                    Validate(middle, line);

                    Match match = middle.Match(line);
                    length = match.Groups["core"].Value.Length;
                    Console.WriteLine("Valid");
                    Console.WriteLine(length);
                }
            }
        }

        private static void Validate(Regex regex, string line)
        {
            if (regex.IsMatch(line) == false)
            {
                Console.WriteLine("Invalid");
                Environment.Exit(0);
            }
        }
    }
}
