using System;
using System.Collections.Generic;
using System.Linq;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();
            int position = int.Parse(Console.ReadLine());
            int damage = 1;
            string[] commands = Console.ReadLine().Split().ToArray();

            while (commands[0] != "Supernova")
            {

                int steps = int.Parse(commands[1]);

                if (commands[0] == "left")
                {
                    for (int i = 0; i < steps; i++)
                    {
                        if (position == 0)
                        {
                            position = sequence.Count - 1;
                            damage++;
                        }
                        else
                        {
                            position--;
                        }
                        sequence[position] -= damage;
                    }
                }
                else if (commands[0] == "right")
                {
                    for (int i = 0; i < steps; i++)
                    {
                        if (position == sequence.Count - 1)
                        {
                            position = 0;
                            damage++;
                        }
                        else
                        {
                            position++;
                        }
                        sequence[position] -= damage;
                    }
                }
                commands = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}
