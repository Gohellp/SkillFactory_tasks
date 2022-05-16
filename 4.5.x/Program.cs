using System;

namespace _4._5.x
{
    class Program
    {
        static void Main(string[] args)
        {
            (string name, string last_name, string login, string count_login, bool has_pet, int age, string[] fav_colors) User;

            Console.Write("Enter you'r name: ");
            User.name = Console.ReadLine();

            Console.Write("Enter you'r last name: ");
            User.last_name = Console.ReadLine();

            Console.Write("Enter you'r login: ");
            User.login = Console.ReadLine();
        }
    }
}
