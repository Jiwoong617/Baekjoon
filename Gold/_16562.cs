using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Baekjoon.Gold
{
    internal class _16562
    {
        static int[] n;
        static int[] friend;
        static int[] cost;

        static void Main(string[] args)
        {
            n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            cost = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            friend = Enumerable.Range(0, n[0]).ToArray();

            for(int i = 0; i < n[1]; i++)
            {
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                MakeUnion(arr[0] - 1, arr[1] - 1);
            }

            //Console.WriteLine(string.Join(" ", friend));
            int total = 0;
            for (int i = 0; i < n[0]; i++)
            {
                if (friend[i] == i)
                    total += cost[i];
            }
            Console.WriteLine(total <= n[2] ? total : "Oh no");
        }

        static int FindP(int n)
        {
            if (n == friend[n])
                return n;

            return friend[n] = FindP(friend[n]);
        }

        static void MakeUnion(int a, int b)
        {
            a = FindP(a);
            b = FindP(b);
            
            if(a == b) return;

            if (cost[a] < cost[b])
                friend[b] = a;
            else
                friend[a] = b;
        }
    }
}
