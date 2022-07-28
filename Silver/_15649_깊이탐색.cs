using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Baekjoon.Silver
{
    class _15649
    {
        static int[] arr;
        static bool[] visit;
        static StringBuilder stb = new StringBuilder();

        static void Main(string[] args)
        {
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            arr = new int[a[1]];
            visit = Enumerable.Repeat(false, a[0]).ToArray();

            dfs(0, a[0], a[1]);
            Console.WriteLine(stb);
        }

        //깊이 탐색
        static void dfs(int deep, int a, int b)
        {
            if (deep == b)
            {
                foreach (int i in arr)
                    stb.Append($"{i} ");
                stb.AppendLine();
                return;
            }

            for (int i = 0;i < a; i++)
            {
                if (!visit[i])
                {
                    visit[i] = true;
                    arr[deep] = i + 1;
                    dfs(deep + 1, a, b);
                    visit[i] = false;
                }
            }
        }
    }
}
