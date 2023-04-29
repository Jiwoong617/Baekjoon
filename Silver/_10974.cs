using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Practice
{
    internal class _10974
    {
        static int n;
        static bool[] v;
        static int[] arr;
        static StringBuilder stb = new StringBuilder();

        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            v = new bool[n];
            arr = new int[n];

            BackT(0);
            Console.WriteLine(stb);
        }

        static void BackT(int count)
        {
            if(count >= n)
            {
                stb.AppendLine(string.Join(" ", arr));
                return;
            }

            for(int i = 1; i<=n; i++)
            {
                if (!v[i-1])
                {
                    v[i-1] = true;
                    arr[count] = i;
                    BackT(count+1);
                    v[i-1] = false;
                }
            }
        }
    }
}
