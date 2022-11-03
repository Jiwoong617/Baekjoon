using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Practice
{
    class _1417
    {
        static void Main_1417(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for(int i = 0; i< n; i++)
                arr[i] = int.Parse(Console.ReadLine());

            int count = 0;
            while (true)
            {
                int max = arr.Max();
                int idx = Array.LastIndexOf(arr, max);
                if (idx == 0)
                    break;

                if (arr[0] <= arr[idx])
                {
                    count++;
                    arr[0]++;
                    arr[idx]--;
                }
                else
                    break;

            }

            Console.WriteLine(count);
        }
    }
}
