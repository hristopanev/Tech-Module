using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();
            string[] commands = Console.ReadLine().Split().ToArray();

            while (commands[0] != "3:1")
            {


                if (commands[0] == "merge")
                {
                    int start = int.Parse(commands[1]);
                    int end = int.Parse(commands[2]);
                    if (start < 0)
                    {
                        start = 0;
                    }
                    if (end >= words.Count)
                    {
                        end = words.Count - 1;
                    }

                    for (int i = start; i < end; i++)
                    {
                        words[start] = words[start] + words[start + 1];
                        words.RemoveAt(start + 1);
                    }
                }
                else if (commands[0] == "divide")
                {
                    int index = int.Parse(commands[1]);
                    int partitons = int.Parse(commands[2]);
                    int numberOfLetters = words[index].Length / partitons;
                    string current = words[index];
                    List<string> deveded = new List<string>();

                    for (int i = 0; i < partitons; i++)
                    {
                        deveded.Add(current.Substring(0, numberOfLetters));
                        current = current.Remove(0, numberOfLetters);
                    }
                    deveded[deveded.Count - 1] = deveded[deveded.Count - 1] + current;
                    words.RemoveAt(index);
                    words.InsertRange(index, deveded);

                }

                commands = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine(string.Join(" ", words));
        }
    }
}
