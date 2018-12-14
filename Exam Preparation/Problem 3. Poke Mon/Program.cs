using System;

namespace Problem_3._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distace = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int count = 0;
            int remained = pokePower;

            while (remained > distace)
            {
                remained -= distace;

                if (remained == pokePower/2 &&  pokePower % 2 == 0 && exhaustionFactor != 0)
                {
                    remained /= exhaustionFactor;
                   
                }
                count++;
            }
            Console.WriteLine(remained);
            Console.WriteLine(count);
        }
    }
}
