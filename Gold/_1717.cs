using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Gold
{
    internal class _1717
    {
        static int[] n;
        static int[] parent;
        static StringBuilder stb = new StringBuilder();

        static void Main(string[] args)
        {
            n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            parent = Enumerable.Range(0, n[0]+1).ToArray();

            while (n[1]-- > 0)
            {
                int[] m = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                if (m[0] == 0)
                    Union_Merge(m[1], m[2]);
                else
                    IsUnion(m[1], m[2]);
            }

            Console.WriteLine(stb);
        }

        //Find
        static int FindParent(int n)
        {
            if (n == parent[n])
                return n;

            parent[n] = FindParent(parent[n]);

            return parent[n];
        }

        //Union-Merge
        static void Union_Merge(int a, int b)
        {
            int x = FindParent(a);
            int y = FindParent(b);
            if (x == y)
                return;

            //큰값의 부모를 작은 값으로
            if(x > y)
                parent[x] = y;
            else
                parent[y] = x;
        }

        static void IsUnion(int a, int b)
        {
            int x = FindParent(a);
            int y = FindParent(b);

            stb.AppendLine(x == y ? "YES" : "NO");
        }
    }
}
