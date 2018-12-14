using System;

namespace Problem_8._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 1;
            int current = 0;
            int result = 0;


            while (current < n)
            {

                result += sum;
                Console.WriteLine(sum);
                sum += 2;
                current++;
                
            }
            Console.WriteLine($"Sum: {result}");
           
        }
    }
}
