using System;

namespace Problem_6._Theatre_Promotions
{
    class Program
    {
        static void Main(string[] args)
        {
            string days = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            int price = 0;

            if (age >= 0 && age <= 18)
            {
                if (days == "Weekday")
                {
                    price = 12;
                }else if(days == "Weekend")
                {
                    price = 15;
                }
                else
                {
                    price = 5;
                }
                Console.WriteLine($"{price}$");
            }
            else if (age > 18 && age <= 64)
            {
                if (days == "Weekday")
                {
                    price = 18;
                }
                else if (days == "Weekend")
                {
                    price = 20;
                }
                else
                {
                    price = 12;
                }
                Console.WriteLine($"{price}$");
            }
            else if (age > 64 && age <= 122)
            {
                if (days == "Weekday")
                {
                    price = 12;
                }
                else if (days == "Weekend")
                {
                    price = 15;
                }
                else
                {
                    price = 10;
                }
                Console.WriteLine($"{price}$");
            }
            else
            {
                Console.WriteLine("Error!");
            }
            
        }
    }
}
