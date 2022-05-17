using System;

namespace _5._1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] favcolors = new string[3];

            static string ShowColor()
            {
                return Console.ReadLine();
            }

            Console.WriteLine("Eter 3 of your fav color:");
            for (int i = 0; i < 3; i++)
                favcolors[i] = ShowColor();
        }
    }
}
