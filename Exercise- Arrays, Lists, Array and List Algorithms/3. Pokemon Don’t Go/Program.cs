using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();
            int index = int.Parse(Console.ReadLine());
            int sum = 0;
            

            while (true)
            {

                
                if (sequence.Count > 1)
                {
                    if (index < 0)
                    {
                        sum += sequence[0];
                        sequence[0] = sequence[sequence.Count - 1];
                        index = int.Parse(Console.ReadLine());
                        continue;
                    }
                    if (index >= sequence.Count)
                    {
                        sum += sequence[sequence.Count - 1];
                        sequence[0] = sequence[sequence.Count - 1];
                        for (int i = 0; i < sequence.Count; i++)
                        {
                            sequence[i] += sequence[sequence.Count - 1];
                        }
                    }
                    else
                    {
                        
                        for (int i = 0; i < sequence.Count; i++)
                        {
                            if (sequence[i] != sequence[index] && sequence[i] < sequence[index])
                            {
                                sequence[i] += sequence[index];

                            }
                            else if (sequence[i] != sequence[index] && sequence[i] > sequence[index])
                            {
                                sequence[i] = sequence[i] - sequence[index];
                            }
                           
                        }

                        sum += sequence[index];
                        sequence.Remove(sequence[index]);
                    }
                    
                }
                else
                {
                    if (sequence.Count == 1 && sequence[0] > 1)
                    {
                        sum += sequence[0] + sequence[0];
                        break;
                    }
                    sum += sequence.Count;
                    break;
                }



                index = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}
