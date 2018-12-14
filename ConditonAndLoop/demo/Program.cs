using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {

            int month = int.Parse(Console.ReadLine());
            string seasson;

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    seasson = "Winter";
                    break;
                case 3:
                case 4:
                case 5:
                    seasson = "Spring";
                    break;
                case 6:
                case 7:
                case 8:
                    seasson = "Summer";
                    break;
                case 9:
                case 10:
                case 11:
                    seasson = "Autumn";
                    break;
                default:
                    seasson = "error";
                    break;
            }
        }
    }
}
