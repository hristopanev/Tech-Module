using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2___Snowmen
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split()
                .Select(int.Parse)
                .ToArray();

            while (sequence.Length > 1)
            {
                for (int attacker = 0; attacker < sequence.Length; attacker++)
                {
                    List<int> losers = new List<int>();

                    int target = sequence[attacker] % sequence.Length;
                    int difference = Math.Abs(attacker - target);


                    if (sequence.Length  - losers.Count == 1)
                    {
                        break;
                    }
                    if (losers.Contains(attacker) == false)
                    {
                        continue;
                    }

                    if (attacker == target)
                    {
                        Console.WriteLine($"{attacker} performed harakiri");
                        losers.Add(attacker);
                        sequence[attacker] = -1;
                    }
                    else if (difference % 2 == 0)
                    {
                        Console.WriteLine($"{attacker} x {target} -> {attacker} wins");
                        losers.Add(target);
                        sequence[target] = -1;
                    }
                    else
                    {
                        Console.WriteLine($"{attacker} x {target} -> {target} wins");
                        losers.Add(attacker);
                        sequence[attacker] = -1;

                    }

                    losers = losers.Distinct().ToList();
                }

                sequence = sequence.Where(n => n != -1).ToArray();
            }

        }
    }
}
