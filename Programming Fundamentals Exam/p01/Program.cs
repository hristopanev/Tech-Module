using System;

namespace p01
{
    class Program
    {
        static void Main(string[] args)
        {
            int employee1 = int.Parse(Console.ReadLine());
            int employee2 = int.Parse(Console.ReadLine());
            int employee3 = int.Parse(Console.ReadLine());
            int student = int.Parse(Console.ReadLine());

            int allemployee = employee1 + employee2 + employee3;

            int count = 0;

            for (int i = 0; i < student; i+= allemployee)
            {
                count++;

                if (count % 4 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine($"Time needed: {count}h.");

        }
    }
}
