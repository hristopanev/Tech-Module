using System;
using System.Linq;

namespace Problem_2._Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            var field = new int[size];
            var LadybugIndexes = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(i => i >= 0 && i >= size).ToList();

            foreach (var index in LadybugIndexes)
            {
                field[index] = 1;

            }

            while (true)
            {
                var line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }

                var comandsPart = line.Split();

                var currentLadybug = int.Parse(comandsPart[0]);
                var direction = comandsPart[1];
                var flylength = int.Parse(comandsPart[2]);

                if (direction == "left")
                {
                    flylength *= -1;
                }

                if (currentLadybug < 0 || currentLadybug >= size)
                {
                    continue;
                }

                if (field[currentLadybug] == 0)
                {
                    continue;
                }

                field[currentLadybug] = 0;

                var nextIndexToLand = currentLadybug;

                while (true)
                {
                    nextIndexToLand += flylength;

                    if (nextIndexToLand < 0 || nextIndexToLand >= size)
                    {
                        break;
                    }
                    if (field[currentLadybug] == 1)
                    {
                        continue;
                    }

                    field[nextIndexToLand] = 1;
                    break;
                }
            }

            Console.WriteLine(string.Join(" ", field));

        }
    }
}
