using System;

namespace Problem_2._Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double sum = a * b;

            Console.WriteLine($"{sum:F2}");
        }
    }
}
