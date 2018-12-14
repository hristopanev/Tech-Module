using System;
using System.Numerics;

namespace Problem_1___Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            

            BigInteger maxValue = -1;
            string result = "";

            for (int i = 0; i < n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);

                if (snowballValue > maxValue)
                {
                    maxValue = snowballValue;
                    result = $"{snowballSnow} : {snowballTime} = {maxValue} ({snowballQuality})";
                }
            }
            Console.WriteLine(result);
        }
    }
}
