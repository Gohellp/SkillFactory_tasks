using System;

namespace _4._3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            string name_rev="";
            for(int i = name.Length-1; i >= 0; i--)
            {
                name_rev += name[i];
            }
            Console.WriteLine(name_rev);
        }
    }
}
