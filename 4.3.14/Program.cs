using System;

namespace _4._3._14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] array = new int[3][];
            array[0] = new int[2] { 1, 2 };
            array[1] = new int[3] { 1, 2, 3 };
            array[2] = new int[5] { 1, 2, 3, 4, 5 };

            foreach(var num in array)
            {
                foreach(var i in num)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
