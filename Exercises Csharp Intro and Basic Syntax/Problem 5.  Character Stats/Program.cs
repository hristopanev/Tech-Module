using System;

namespace Problem_5.__Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());

            int currentEnergyh = int.Parse(Console.ReadLine());
            int maxHEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            int remainingHealth = maxHealth - currentHealth;
            string currentHealtsAsString = new string('|', currentHealth);
            string remainingHealthAsString = new string('.', remainingHealth);
            string healthBar = $"Health: |{currentHealtsAsString}{remainingHealthAsString}|";
            Console.WriteLine(healthBar);

            int remainingEnergy = maxHEnergy - currentEnergyh;
            string currentEnergyAsString = new string('|', currentEnergyh);
            string remainEnergyAsString = new string('.', remainingEnergy);
            string EnergyBar = $"Energy: |{currentEnergyAsString}{remainEnergyAsString}|";
            Console.WriteLine(EnergyBar);


        }
    }
}
