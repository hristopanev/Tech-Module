using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = File.ReadAllText("Program.cs");
            var lines = File.ReadAllLines("Program.cs");

            Console.WriteLine(text);
            Console.WriteLine(lines[0]);


        }
    }
}
