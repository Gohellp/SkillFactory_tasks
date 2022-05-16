using System;

namespace _4._4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            (string Name, string Type, double Age, int NameCount) Pet;

            Console.Write("Enter you'r pes's name: ");
            Pet.Name = Console.ReadLine();
            Console.Write("Enter you'r pes's type: ");
            Pet.Type = Console.ReadLine();
            Console.Write("Enter you'r pet's age: ");
            Pet.Age = double.Parse(Console.ReadLine());
            Pet.NameCount = Pet.Name.Length;
        }
    }
}
