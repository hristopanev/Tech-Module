using System;

namespace Problem_3._Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double mile = double.Parse(Console.ReadLine());
            double km = mile * 1.60934;

            Console.WriteLine($"{km:F2}");


        }
    }
}
