using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Gold
{
    internal class _1976
    {
        static int[] cityParent;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            cityParent = Enumerable.Range(0, n).ToArray();
            for(int i = 0; i<n; i++)
            {
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                for(int j = 0; j < n; j++)
                {
                    if (arr[j] == 1)
                        MakeUnion(i, j);
                }
            }

            int[] plan = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int ans = cityParent[plan[0] - 1];
            for (int i = 1; i < m; i++)
            {
                if (cityParent[plan[i]-1] != ans)
                {
                    Console.WriteLine("NO");
                    return;
                }
            }
            Console.WriteLine("YES");
            //Console.WriteLine(string.Join(" ", cityParent));
        }

        static void MakeUnion(int a, int b)
        {
            a = FindParent(a);
            b = FindParent(b);

            if (a == b)
                return;

            if(a>b)
                cityParent[a] = b;
            else
                cityParent[b] = a;
        }

        static int FindParent(int n)
        {
            if (n == cityParent[n])
                return n;

            cityParent[n] = FindParent(cityParent[n]);

            return cityParent[n];
        }
    }
}
