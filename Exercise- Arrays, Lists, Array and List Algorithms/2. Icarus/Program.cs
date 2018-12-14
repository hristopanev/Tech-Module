using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Icarus
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();
            int damage = 1;
            int startPosition = int.Parse(Console.ReadLine());
            string[] commands = Console.ReadLine().Split().ToArray();

            while (commands[0] != "Supernova")
            {
                string direction = commands[0];
                int steps = int.Parse(commands[1]);

                if (commands[0] == "left")
                {
                    for (int i = 0; i < steps; i++)
                    {
                        if (startPosition == 0)
                        {
                            startPosition = sequence.Count - 1;
                            damage++;
                        }
                        else
                        {
                            startPosition--;
                        }
                        sequence[startPosition] -= damage;
                    }
                 
                }
                else if (commands[0] == "right")
                {
                    for (int i = 0; i < steps; i++)
                    {
                        if (startPosition == sequence.Count - 1)
                        {
                            startPosition = 0;
                            damage++;
                        }
                        else
                        {
                            startPosition++;
                        }
                        sequence[startPosition] -= damage;
                    }
                    

                }

                commands = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}
