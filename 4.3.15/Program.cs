using System;

namespace _4._3._15
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1,-5,3,-123,4,74,234,-4,-21,23};
            int count = 0;

            for(int i = 0; i < arr.Length;i++)
            {
                if (arr[i]>0)
                {
                    count += 1;
                }
            }
            Console.WriteLine("Pos. number count is: {0}", count);
        }
    }
}
