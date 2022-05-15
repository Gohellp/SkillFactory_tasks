using System;

namespace _4._3._16
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

            int count = 0;

            foreach(var num in arr)
            {
                if (num > 0)
                {
                    count++;
                }
            }

            Console.WriteLine("Pos. number count is: {0}", count);
        }
    }
}
