using System;

namespace _5._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            (string Name, string[] Dishes) User;
            User.Dishes = new string[5];

            Console.Write("Enter your name: ");
            User.Name = Console.ReadLine();

            Console.WriteLine("Enter your five fav dishes:");
            for (int i = 0; i < 5; i++)
                User.Dishes[i] = Console.ReadLine();
        }
    }
}
