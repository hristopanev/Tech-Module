using System;
using System.Numerics;

namespace Problem_1___Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            BigInteger maxValue = -1;
            string result = "";

            for (int i = 0; i < input; i++)
            {
                int snowballShow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger currentSnowballValue = BigInteger.Pow(snowballShow/snowballTime, snowballQuality);


                if (currentSnowballValue > maxValue)
                {
                    maxValue = currentSnowballValue;
                    result = $"{snowballShow} : {snowballTime} = {maxValue} ({snowballQuality})";
                }
            }

            Console.WriteLine(result);
        }
    }
}
