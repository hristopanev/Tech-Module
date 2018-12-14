using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int rowCounter = 0;
            int bestLength = 0;
            int bestIndex = 0;
            int[] bestSequence = new int[length];
            int indexOfSeuqnce = 0;


            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Clone them!")
                {
                    break;
                }
                rowCounter++;

                int[] splitted = line.Split("!").Select(int.Parse).ToArray();

                int currentLength = 0;
                int currentIndex = 0;



                for (int i = 0; i < splitted.Length; i++)
                {
                    if (splitted[i] == 1)
                    {
                        currentLength++;
                        if (currentLength >= bestLength)
                        {
                            indexOfSeuqnce = rowCounter;
                            bestLength = currentLength;
                            bestSequence = splitted;
                            bestIndex = Array.IndexOf(splitted, i - currentLength);
                        }

                        else if (currentLength == bestLength)
                        {
                            if (currentIndex == bestIndex)
                            {
                                int sumBestSequence = bestSequence.Sum();
                                int sumCurrentSequence = splitted.Sum();

                                if (sumCurrentSequence > sumBestSequence)
                                {
                                    bestLength = currentLength;
                                    bestSequence = splitted;
                                    bestIndex = Array.IndexOf(splitted, i - currentLength);
                                }
                            }
                            else
                            {
                                if (currentIndex > bestIndex)
                                {
                                    indexOfSeuqnce = rowCounter;
                                    bestLength = currentLength;
                                    bestSequence = splitted;
                                    bestIndex = Array.IndexOf(splitted, i - currentLength);
                                }
                            }
                        }
                    }
                    else
                    {
                        currentLength = 0;
                        currentIndex = 0;
                    }
                }
                
            }

            Console.WriteLine($"Best DNA sample {indexOfSeuqnce} with sum: {bestSequence.Sum()}.");
            Console.WriteLine(string.Join(" ", bestSequence));
        }
    }
}
