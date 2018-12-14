using System;

namespace Problem_4._Resurrection
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           
            decimal totalYears = 0;
            

            for (int i = 0; i < n; i++)
            {
                long totalLength = long.Parse(Console.ReadLine());
                decimal totalWidth = decimal.Parse(Console.ReadLine());
                long lengthOfwings = long.Parse(Console.ReadLine());

                totalYears = (totalLength * totalLength) * (totalWidth + 2 * lengthOfwings);

                Console.WriteLine(totalYears);
            }




        }
    }
}
