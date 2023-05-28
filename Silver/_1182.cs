using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.silver
{
    internal class _1182
    {
        static int[] n;
        static int[] arr;
        static int count = 0;
        static int temp = 0;

        static void Main(string[] args)
        {
            n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            BackT(0);
            Console.WriteLine(count);
        }

        static void BackT(int now)
        {
            if(temp == n[1] && now != 0)
                count++;

            for(int i = now ; i < n[0]; i++)
            {
                temp += arr[i];
                BackT(i + 1);
                temp -= arr[i];
            }
        }
    }
}
