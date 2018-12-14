using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2___Memory_View
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();

            List<char> result = new List<char>();


            while (words != "Visual Studio crash")
            {
                int[] name = words.Split().Select(int.Parse).ToArray();

                for (int i = 0; i < name.Length; i++)
                {
                    if (name[i] >= 65 && name[i] < 122)
                    {
                        result.Add((char)name[i]);
                    }
                }

                Console.WriteLine(string.Join("", result));

                result = new List<char>();
                words = Console.ReadLine();
            }
            

        }
    }
}
