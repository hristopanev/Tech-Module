using System;
using System.Text.RegularExpressions;

namespace Problem_2._Anonymous_Vox
{
    class Program
    {
        static void Main(string[] args)
        {
            string playsholder = Console.ReadLine();
            string playsholderpattern = @"([A-Za-z]+)(.+)(\1)";
            string values = Console.ReadLine();
            string valuespattern = @"({)(.*?)(})";

            MatchCollection playsholderCollection = Regex.Matches(playsholder, playsholderpattern);
            MatchCollection valuesCollection = Regex.Matches(values, valuespattern);

            for (int i = 0; i < Math.Min(playsholderCollection.Count, valuesCollection.Count); i++)
            {
                string toChange = playsholderCollection[i].Groups[2].Value;
                string toPut = valuesCollection[i].Groups[2].Value;
                int index = playsholder.IndexOf(toChange);
                playsholder = playsholder.Remove(index, toChange.Length);
                playsholder = playsholder.Insert(index, toPut);
            }

            Console.WriteLine(playsholder);
        }
    }
}
