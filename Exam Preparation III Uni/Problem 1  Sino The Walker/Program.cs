using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_1__Sino_The_Walker
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime timeOfLeavingSoftUni = DateTime.Parse(Console.ReadLine());

            int stepsTaken = int.Parse(Console.ReadLine()) % 86400;
            int stepsPerSec = int.Parse(Console.ReadLine()) % 86400;
            int timeInTravel = stepsTaken * stepsPerSec;
            DateTime result = timeOfLeavingSoftUni.AddSeconds(timeInTravel);
     
            Console.WriteLine("Time Arrival: {0:HH:mm:ss}", result);

        }
    }
}
