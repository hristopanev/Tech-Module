using System;

namespace Problem_10._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            while (true)
            {
                Console.WriteLine($"{a} X {b} = {a * b}");
                b++;
                if (b > 10)
                {
                    break;
                }
            }
        }
    }
}
