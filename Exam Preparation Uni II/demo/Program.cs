using System;
using System.Collections.Generic;
using System.Linq;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string inputLine = Console.ReadLine();
            List<int> bestDNA = new List<int>();

            int sumDNALine = 0;
            int countDNA = 0;
            int bestSumLine = 0;
            int bestCount = 0;
            int count = 0;
            int bestLoop = 0;

            while (inputLine != "Clone them!")
            {
                int[] dna = inputLine.Split("!").Where(x => x != "").Select(int.Parse).ToArray();

                if (dna[0] == 0)
                {
                    sumDNALine = 0;
                    countDNA = 0;
                    count++;
                    for (int i = 1; i < dna.Length; i++)
                    {

                        sumDNALine += dna[i];

                        if (dna[i] == dna[i - 1] && dna[i] > 0)
                        {

                            countDNA++;
                        }
                    }
                    if (sumDNALine > bestSumLine && countDNA > bestCount)
                    {
                        bestLoop = count;
                        bestSumLine = sumDNALine;
                        bestCount = countDNA;
                        sumDNALine = 0;
                        countDNA = 0;
                        bestDNA = new List<int>();
                        for (int i = 0; i < dna.Length; i++)
                        {
                            bestDNA.Add(dna[i]);
                        }
                    }
                    else if (dna[0] > 0)
                    {
                        sumDNALine = 0;
                        countDNA = 0;
                        count++;
                        for (int i = 1; i < dna.Length; i++)
                        {
                            if (i == 1)
                            {
                                sumDNALine += dna[i - 1];
                            }
                            sumDNALine += dna[i];

                            if (dna[i] == dna[i - 1] && dna[i] > 0)
                            {

                                countDNA++;
                            }
                        }
                        if (sumDNALine > bestSumLine && countDNA > bestCount)
                        {
                            bestLoop = count;
                            bestSumLine = sumDNALine;
                            bestCount = countDNA;
                            sumDNALine = 0;
                            countDNA = 0;
                            bestDNA = new List<int>();
                            for (int i = 0; i < dna.Length; i++)
                            {
                                bestDNA.Add(dna[i]);
                            }
                        }

                    }



                    inputLine = Console.ReadLine();
                }

                Console.WriteLine($"Best DNA sample {bestLoop} with sum: {bestSumLine}.");
                Console.WriteLine(string.Join(" ", bestDNA));
            }
        }
    }
}
