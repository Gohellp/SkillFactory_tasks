using System;

namespace _4._4._2
{
    class Program
    {
        static string ShowColor(string name, int age)
        {
            Console.WriteLine("{0} {1}\nyears old, enter your fav color", name, age);
            switch (Console.ReadLine())
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    return "red";
                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    return "green";
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    return "cyan";

                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    return "yellow";
            }
        }
        static void Main(string[] args)
        {

            (string name, int age) form;
            Console.Write("Enter your name: ");
            form.name = Console.ReadLine();
            Console.Write("Enter your age: ");
            form.age = checked((byte)int.Parse(Console.ReadLine()));
            Console.WriteLine("Your name is {0} and age is {1} ", form.name, form.age);


            var favcolors = new string[3];
            for (int i = 0; i < 3; i++)
            {
                favcolors[i] = ShowColor(form.name, form.age);
            }

            Console.WriteLine("Your favcolors:");
            foreach (string color in favcolors)
            {
                Console.WriteLine(color);
            }
        }
    }
}