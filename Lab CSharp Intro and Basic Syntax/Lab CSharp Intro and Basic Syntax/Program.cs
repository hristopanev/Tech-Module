using System;

namespace Lab_CSharp_Intro_and_Basic_Syntax
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 + num2;

            Console.WriteLine($"{num1} + {num2} = {sum}", num1, num2, sum);

        }
    }
}
