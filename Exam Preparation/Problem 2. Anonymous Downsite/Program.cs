using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Problem_2._Anonymous_Downsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());

            decimal totalLoss = 0;

            var securityTockens = Math.Pow(securityKey, n);
            

            for (int i = 0; i < n; i++)
            {
                List<string> line = Console.ReadLine().Split().ToList();

                string webSite = line[0];
                var siteVisit = decimal.Parse(line[1]);
                var sitePriceVisit = decimal.Parse(line[2]);
                totalLoss += siteVisit * sitePriceVisit;
                Console.WriteLine($"{webSite}");
                
            }
            Console.WriteLine($"Total Loss: {totalLoss:f20}");
            Console.WriteLine($"Security Token: {securityTockens}");
            

        }
    }
}
