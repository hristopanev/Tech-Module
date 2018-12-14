using System;

namespace Problem_5._Wormtest
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double remainder = length * 100;

            if (remainder % width == 0 || width == 0)
            {
                remainder *= width;
                Console.WriteLine($"{remainder:F2}");
            }
            else
            {
                remainder /= width;
                Console.WriteLine($"{remainder*100:f2}");
            }
        }
    }
}
