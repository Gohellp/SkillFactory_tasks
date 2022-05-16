using System;

namespace _4._5.x
{
    class Program
    {
        static void Main(string[] args)
        {
            (string name, string last_name, string login, int login_count, bool has_pet, int age, string[] fav_colors) User;


            Console.Write("Enter your name: ");
            User.name = Console.ReadLine();

            Console.Write("Enter you'r last name: ");
            User.last_name = Console.ReadLine();

            Console.Write("Enter your login: ");
            User.login = Console.ReadLine();
            User.login_count = User.login.Length;

            Console.Write("Do you have a pet? ");
            string temp_has_pet = Console.ReadLine();
            switch (temp_has_pet.ToLower())
            {
                case "да":
                    User.has_pet = true;
                    break;
                case "д":
                    User.has_pet = true;
                    break;
                case "yes":
                    User.has_pet = true;
                    break;
                case "y":
                    User.has_pet = true;
                    break;
                default:
                    User.has_pet = false;
                    break;
            }

            Console.Write("Enter yorr age: ");
            User.age= checked((byte)int.Parse(Console.ReadLine()));

            User.fav_colors = new string[3];
            Console.WriteLine("Enter 3 of your favotite colors:");
            for (int i = 0; i < User.fav_colors.Length; i++)
                User.fav_colors[i] = Console.ReadLine();
        }
    }
}
