using System;

namespace _5._2._18
{
    class Program
    {
        static int[] GetArrayFromConsole(int num = 5)
        {
            var result = new int[num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Inter arr's elemen #{0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;
        }
        static int[] ShowArray(int[] arr, bool must_sort = false)
        {
            if (must_sort)
            {
                arr = SortArray(arr);
            }

            foreach (int num in arr)
            {
                Console.WriteLine(num);
            }
        }
        static int[] SortArray(int[] arr)
        {
            int temp;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
        static void Main(string[] args)
        {
            ShowArray(GetArrayFromConsole(10),true);
        }
    }
}
