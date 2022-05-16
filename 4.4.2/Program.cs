using System;

namespace _4._4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            (string name, int age) form;
            Console.Write("Enter your name: ");
            form.name = Console.ReadLine();
            Console.Write("Enter your age: ");
            form.age = checked((byte)int.Parse(Console.ReadLine()));
            Console.WriteLine("Your name is {0} and age is {1} ", form.name, form.age);
        }
    }
}
