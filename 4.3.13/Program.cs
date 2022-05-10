using System;

namespace _4._3._13
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            int sum = 0;

            for(int i = 0; i<=arr.Length-1; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine(sum);
        }
    }
}
