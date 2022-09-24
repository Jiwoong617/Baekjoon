using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Baekjoon.Silver
{
    class _24445
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Dictionary<int, List<int>> arr = new Dictionary<int, List<int>>();

            //그래프 구현
            for (int i = 0; i < n[1]; i++)
            {
                int[] point = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                if (!arr.ContainsKey(point[0]))
                {
                    arr.Add(point[0], new List<int>());
                    arr[point[0]].Add(point[1]);
                }
                else
                    arr[point[0]].Add(point[1]);

                if (!arr.ContainsKey(point[1]))
                {
                    arr.Add(point[1], new List<int>());
                    arr[point[1]].Add(point[0]);
                }
                else
                    arr[point[1]].Add(point[0]);
            }

            //정렬
            foreach (int k in arr.Keys.ToArray().OrderBy(x => x))
            {
                arr[k].Sort();
                arr[k].Reverse();
                //Console.Write(k + " : ");
                //Console.WriteLine(string.Join(" ", arr[k]));
            }

            bool[] visited = new bool[n[0] + 1];
            int[] visit_num = new int[n[0] + 1];
            visit_num[n[2]] = 1;
            int temp = 1;
            Queue<int> que = new Queue<int>();

            que.Enqueue(n[2]);
            visited[n[2]] = true;

            //bfs
            while (que.Count > 0)
            {
                int num = que.Dequeue();
                foreach (int a in arr[num])
                {
                    if (!visited[a])
                    {
                        visited[a] = true;
                        que.Enqueue(a);
                        temp++;
                        visit_num[a] = temp;
                    }
                }
            }

            for (int i = 1; i <= n[0]; i++)
                stb.AppendLine(visit_num[i].ToString());

            Console.WriteLine(stb);
        }
    }
}
