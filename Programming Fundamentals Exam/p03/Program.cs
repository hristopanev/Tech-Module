using System;
using System.Text.RegularExpressions;

namespace p03
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            

            while (input != "end of shift")
            {
                string pattern = @"\%(?<name>[A-Z][a-z]+)\%\<(?<product>[A-Za-z]+)\>\|(?<count>[\d]+)\|(?<price>[\d.\d]+)\$";

                MatchCollection matches = Regex.Matches(input, pattern);

                if (Regex.IsMatch(input, pattern))
                {
                    

                }

                input = Console.ReadLine();
            }
        }
    }
}
