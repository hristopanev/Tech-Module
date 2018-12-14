using System;
using System.Numerics;

namespace Problem_2._2._Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            long wingsFlaps = long.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());

            double metersTraveled = 0;
            long secondsPassed = 0;
            long totalPassed = 0;

            metersTraveled = (wingsFlaps / 1000) * distance;

            long flapsPerSeconds = wingsFlaps / 100;

            secondsPassed = (wingsFlaps / endurance) * 5;
            totalPassed = secondsPassed + flapsPerSeconds;

            Console.WriteLine($"{metersTraveled:f2} m.");
            Console.WriteLine($"{totalPassed} s.");





        }
    }
}
