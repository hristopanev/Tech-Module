using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace p03
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Match> messeges = new List<Match>();
            List<Match> broadcasts = new List<Match>();

            string messegesPattern = @"^([0-9]+) <-> ([A-ZAa-z0-9]+)$";
            string broadcastsPattern = @"^([^0-9]+) <-> ([A-ZAa-z0-9]+)$";


            while (input != "Hornet is Green")
            {
                if (Regex.IsMatch(input, messegesPattern))
                {
                    messeges.Add(Regex.Match(input, messegesPattern));
                }
                else if (Regex.IsMatch(input, broadcastsPattern))
                {
                    broadcasts.Add(Regex.Match(input, broadcastsPattern));
                }

                input = Console.ReadLine();
            }
            Console.WriteLine("Broadcasts:");
            if (broadcasts.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (Match m in broadcasts)
                {

                    string frequency = m.Groups[2].Value;
                    frequency = UpdateLetters(frequency);
                    Console.WriteLine($"{frequency} -> {m.Groups[1].Value}");
                }
            }
            
            Console.WriteLine("Messages:");
            if (messeges.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var m in messeges)
                {
                    string code = m.Groups[1].Value;
                    code = ReverceCode(code);
                    Console.WriteLine($"{code} -> {m.Groups[2]}");
                }
            }
            
           
        }

        private static string ReverceCode(string code)
        {
            string result = "";

            for (int i = code.Length - 1; i >= 0; i--)
            {
                result += code[i];
            }
            return result;
        }

        private static string UpdateLetters(string frequency)
        {
            string result = "";
            for (int i = 0; i < frequency.Length; i++)
            {
                if (char.IsUpper(frequency[i]))
                {
                    result += char.ToLower(frequency[i]);
                }
                else if (char.IsLower(frequency[i]))
                {
                    result += char.ToUpper(frequency[i]);
                }
                else
                {
                    result += frequency[i];
                }
            }
            return result;
        }
    }
}
