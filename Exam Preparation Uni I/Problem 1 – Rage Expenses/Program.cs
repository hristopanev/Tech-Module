using System;

namespace Problem_1___Rage_Expenses
{
    class Program
    {
     

        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double headsets = lostGames / 2;
            double moussets = lostGames / 3;
            int keyboards = lostGames / 3 / 2;
            int displas = keyboards / 2;

            double sum = (headsetPrice * headsets) + (mousePrice * moussets) + (keyboardPrice * keyboards)
                + (displas * displayPrice);

            Console.WriteLine($"Rage expenses: {sum:f2} lv.");

        }
        
    }
}
