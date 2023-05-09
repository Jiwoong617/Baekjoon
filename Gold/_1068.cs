using System;
using System.Collections.Generic;
using System.Linq;

namespace Baekjoon.Gold
{
    internal class _1068
    {
        static int count;
        static List<int>[] tree;
        static int del;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            tree = new List<int>[n];
            for (int i = 0; i < n; i++)
                tree[i] = new List<int>();

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int root = 0;
            for(int i = 0; i<n; i++)
            {
                if (arr[i] == -1)
                    root = i;
                else
                    tree[arr[i]].Add(i);
            }
            del = int.Parse(Console.ReadLine());
            tree[del].Clear();

            DFS(root);
            Console.WriteLine(del == root ? 0:count);
        }

        static void DFS(int n)
        {
            if (tree[n].Count == 0)
            {
                count++;
                return;
            }

            foreach(int next in tree[n])
            {
                if (next != del)
                    DFS(next);
                else
                    count = CheckBefore(n) ? count + 1 : count;
            }
        }

        static bool CheckBefore(int before)
        {
            return tree[before].Count <= 1 ? true : false;
        }
    }
}
