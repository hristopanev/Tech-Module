using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace Problem_1._Trainegram
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string trainpattern = @"^(<\[[\W_]*?\]\.)(\.\[[^\W_]*\]\.)*$";
            List<Match> list = new List<Match>();
            


            while (input != "Traincode!")
            {
                if (Regex.IsMatch(input, trainpattern))
                {
                    list.Add(Regex.Match(input, trainpattern));
                }
                input = Console.ReadLine();
            }

            foreach (Match m in list)
            {
                Console.WriteLine(m.Value);
            }
        }
    }
}
