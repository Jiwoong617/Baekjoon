using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Practice
{
    class _18352
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            //n[0] - 노드 개수, n[1] - 선 개수, n[2] - K, n[3] - 시작
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
            for (int i = 1; i <= n[0]; i++)
                graph[i] = new List<int>();

            for (int i = 0; i < n[1]; i++)
            {
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                graph[arr[0]].Add(arr[1]);
            }

            int[] point_num = new int[n[0] + 1];
            Queue<int> q = new Queue<int>();
            point_num[n[3]] = 1;
            q.Enqueue(n[3]);
            while (q.Count > 0)
            {
                int point = q.Dequeue();
                foreach (int i in graph[point])
                {
                    if (point_num[i] == 0)
                    {
                        point_num[i] = point_num[point] + 1;
                        q.Enqueue(i);
                    }
                }
            }

            bool flag = false;
            for (int i = 1; i <= n[0]; i++)
            {
                if (point_num[i]-1 == n[2]) 
                {
                    stb.AppendLine(i.ToString());
                    flag = true;
                }
            }

            if (flag)
                Console.WriteLine(stb);
            else
                Console.WriteLine(-1);
        }
    }
}
