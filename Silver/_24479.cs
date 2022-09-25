using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _24479
    {
        static int[] n;
        static Dictionary<int, List<int>> arr;
        static bool[] visited;
        static int[] visit_num;
        static int temp;

        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            arr = new Dictionary<int, List<int>>();

            for (int i = 1; i <= n[0]; i++)
                arr[i] = new List<int>();

            //그래프 구현
            for (int i = 0; i < n[1]; i++)
            {
                int[] point = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                arr[point[0]].Add(point[1]);
                arr[point[1]].Add(point[0]);
            }

            //정렬
            foreach (int k in arr.Keys)
                arr[k].Sort();

            visited = new bool[n[0] + 1];
            visit_num = new int[n[0] + 1];
            temp = 1;
            dfs(n[2]);

            for (int i = 1; i <= n[0]; i++)
                stb.AppendLine(visit_num[i].ToString());

            Console.WriteLine(stb);
        }

        static void dfs(int point)
        {
            visited[point] = true;
            visit_num[point] = temp;
            temp++;

            foreach(int a in arr[point])
            {
                if (!visited[a])
                    dfs(a);
            }
        }
    }
}
