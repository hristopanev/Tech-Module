using System;

namespace Problem_2._Passed_or_Failed
{
    class Program
    {
        static void Main(string[] args)
        {
            double grande = double.Parse(Console.ReadLine());

            if (grande > 2.99)
            {
                Console.WriteLine("Passed!");
            }
            else
            {
                Console.WriteLine("Failed!");
            }
        }
    }
}
