using System;

namespace _4._5.x
{
    class Program
    {
        static void Main(string[] args)
        {
            (string name, string last_name, string login, int login_count, bool has_pet, int age, string[] fav_colors) User;


            Console.Write("Enter you'r name: ");
            User.name = Console.ReadLine();

            Console.Write("Enter you'r last name: ");
            User.last_name = Console.ReadLine();

            Console.Write("Enter you'r login: ");
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
        }
    }
}
