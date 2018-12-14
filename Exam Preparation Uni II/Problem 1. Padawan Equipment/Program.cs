using System;

namespace Problem_1._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsabersPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());



            double moreLightsabers = Math.Ceiling(students * 1.10);



            double neededMoneyLightsaberes = moreLightsabers * lightsabersPrice;
            double neededMoneyRobes = students * robesPrice;
            double neededMoneyBelts = (students - students / 6) * beltsPrice;

            double totalSum = neededMoneyLightsaberes + neededMoneyRobes + neededMoneyBelts;



            if (money >= totalSum)
            {
                Console.WriteLine($"The money is enough - it would cost {totalSum:f2}lv.");
            }
            else
            {
                totalSum -= money;
                Console.WriteLine($"Ivan Cho will need {totalSum:f2}lv more.");
            }
        }
    }
}
