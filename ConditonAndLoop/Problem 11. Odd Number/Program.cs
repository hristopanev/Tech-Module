using System;

namespace Problem_11._Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {
           
            

            int sum = 0;
            while (sum <= 10)
            {
                int n = int.Parse(Console.ReadLine());

                if ((n % 2 == 1) || (n % 2 == -1) )
                {
                    
                    Console.WriteLine($"The number is: {Math.Abs(n)}");
                    break;
                }
                Console.WriteLine("Please write an odd number.");

                sum++;
            }
        }
    }
}
