using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _15651
    {
        static int[] num;
        static int[] arr;
        static StringBuilder stb = new StringBuilder();

        static void Main(string[] args)
        {
            num = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            arr = new int[num[1]];

            dfs(0);
            Console.WriteLine(stb);
        }

        //깊이 탐색
        static void dfs(int deep)
        {
            if (deep == num[1])
            {
                foreach (int i in arr)
                    stb.Append($"{i} ");
                stb.AppendLine();
                return;
            }

            for (int i = 0; i < num[0]; i++)
            {
                arr[deep] = i + 1;
                dfs(deep+1);
            }
        }
    }
}
