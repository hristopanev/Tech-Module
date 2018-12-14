using System;

namespace Problem_1._Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            long marathonDays = long.Parse(Console.ReadLine());
            long runners = long.Parse(Console.ReadLine());
            long averageLapsPerRunner = long.Parse(Console.ReadLine());
            long lenghtTrack = long.Parse(Console.ReadLine());
            long capacityTrack = long.Parse(Console.ReadLine());
            double moneyPerKilometer = double.Parse(Console.ReadLine());

            var maximalCapacity = marathonDays * capacityTrack;

            var maxRunners = Math.Min(runners, maximalCapacity);

            var totalMeters = maxRunners * averageLapsPerRunner * lenghtTrack;
            var totalKilometers = totalMeters / 1000;
            var totalMoney = totalKilometers * moneyPerKilometer;

            Console.WriteLine($"Money raised: {totalMoney:f2}");
        }
    }
}
