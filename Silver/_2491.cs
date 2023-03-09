using System;
using System.Collections.Generic;
using System.Linq;

namespace Baekjoon.silver
{
    internal class _2491
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            if(n == 2 || n == 1)
            {
                Console.WriteLine(n==1?1:2);
                return;
            }

            bool isAsc = arr[0]==arr[1] ? true: (arr[0] < arr[1] ? true : false);
            int asc = 2;
            int countAsc = 2;
            for(int i = 2; i< n; i++)
            {
                bool temp = arr[i - 1] == arr[i] ? true : (arr[i - 1] < arr[i] ? true:false);
                if (temp == isAsc)
                    countAsc++;
                else
                {
                    isAsc = temp;
                    countAsc = 2;
                }
                asc = Math.Max(countAsc, asc);
            }

            bool isDesc = arr[0] == arr[1] ? true : (arr[0] > arr[1] ? true : false);
            int desc = 2;
            int countDesc = 2;
            for (int i = 2; i < n; i++)
            {
                bool temp = arr[i - 1] == arr[i] ? true : (arr[i - 1] > arr[i] ? true : false);
                if (temp == isDesc)
                    countDesc++;
                else
                {
                    isDesc = temp;
                    countDesc = 2;
                }
                desc = Math.Max(countDesc, desc);
            }

            Console.WriteLine(Math.Max(asc,desc));
        }
    }
}
