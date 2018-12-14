using System;

namespace Problem_4._Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            double sugar = double.Parse(Console.ReadLine());

            double kcal = (volume  * energy)/100.0;
            double sugars = (volume * sugar) / 100.0;

            Console.WriteLine($"{volume}ml {product}:\r\n{kcal}kcal, {sugars}g sugars");

        }
    }
}
