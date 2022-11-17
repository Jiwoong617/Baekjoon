using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Gold
{
    class _13549
    {
        static void Main(string[] args)
        {
            //n[0] 수빈 위치, n[1] 동생 위치
            int[] n = Console.ReadLine().Split().Select(x=>int.Parse(x)).ToArray();

            int[] map = Enumerable.Repeat(100000, 100001).ToArray();
            bool[] visited = new bool[100001];

            PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
            pq.Enqueue(n[0], 0);
            map[n[0]] = 0;

            while (pq.Count > 0)
            {
                int point = pq.Dequeue();
                if (!visited[point])
                    visited[point] = true;

                if (point*2 < 100001 && !visited[point * 2])
                {
                    map[point * 2] = Math.Min(map[point], map[point*2]);

                    pq.Enqueue(point*2, map[point*2]); //순간이동은 가중치 0
                }

                if(point-1 >= 0 && !visited[point - 1])
                {
                    map[point-1] = Math.Min(map[point - 1], map[point]+1);
                    pq.Enqueue(point-1, map[point-1]);
                }

                if (point + 1 <100001 && !visited[point + 1])
                {
                    map[point + 1] = Math.Min(map[point +1], map[point] + 1);
                    pq.Enqueue(point + 1, map[point + 1]);
                }
            }

            Console.WriteLine(map[n[1]]);
        }
    }
}
