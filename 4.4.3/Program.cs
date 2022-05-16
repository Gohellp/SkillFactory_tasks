using System;

namespace _4._4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            var (name, age) = ("Евгения", 27);

            Console.WriteLine("Ваше имя: {0}", name);
            Console.WriteLine("Ваш возраст: {0}", age);

            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.Write("Enter your age: ");
            age = checked((byte)int.Parse(Console.ReadLine()));

            Console.WriteLine("Your name is {0} and age is {1} ", name, age);
        }
    }
}
