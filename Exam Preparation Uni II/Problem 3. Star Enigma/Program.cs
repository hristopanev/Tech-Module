using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;


namespace Problem_3._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Regex starRegex = new Regex(@"[sSTtAaRr]");
            Regex messegeRegex = new Regex(@"[^@\-:!>]*@(?<name>[A-Za-z]+)[^@\-:!>]*:(\d+)[^@\-:!>]*!(?<type>A|D)![^@\-:!>]*->(\d+)[^@\-:!>]*");

            List<string> attacked = new List<string>();
            List<string> destroit = new List<string>();


            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();

                MatchCollection starMatches = starRegex.Matches(line);
                int step = starMatches.Count;
                StringBuilder decMessege = new StringBuilder();

                for (int j = 0; j < line.Length; j++)
                {
                    char current = (char)(line[j] - step);
                    decMessege.Append(current);
                }

                if (messegeRegex.IsMatch(decMessege.ToString()))
                {

                    Match match = messegeRegex.Match(decMessege.ToString());
                    string type = match.Groups["type"].Value;
                    string name = match.Groups["name"].Value;

                    if (type == "D")
                    {
                        destroit.Add(name);
                    }
                    else if (type == "A")
                    {
                        attacked.Add(name);
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attacked.Count}");

            foreach (var planet in attacked.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }
            Console.WriteLine($"Destroyed planets: {destroit.Count}");

            foreach (var planet in destroit.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
