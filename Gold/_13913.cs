using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Gold
{
    internal class _13913
    {
        public class Map
        {
            public int time = 0;
            public int prev = -1;
        }

        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            Map[] map = new Map[100001];
            for(int i=0;i<map.Length; i++)
                map[i] = new Map();
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            Queue<int> q = new Queue<int>();
            q.Enqueue(n[0]);
            map[n[0]].time = 1;
            while(q.Count > 0)
            {
                int t = q.Dequeue();
                Map m = map[t];
                if (t == n[1])
                    break;

                if(t * 2 < 100001 && map[t*2].time == 0)
                {
                    map[t * 2].time = m.time + 1;
                    map[t * 2].prev = t;
                    q.Enqueue(t * 2);
                }
                if (t + 1 < 100001 && map[t+1].time == 0)
                {
                    map[t+1].time = m.time + 1;
                    map[t+1].prev = t;
                    q.Enqueue(t+1);
                }
                if (t - 1 >= 0 && map[t-1].time == 0)
                {
                    map[t - 1].time = m.time + 1;
                    map[t - 1].prev = t;
                    q.Enqueue(t - 1);
                }
            }
            stb.AppendLine((map[n[1]].time - 1).ToString());
            Stack<int> s = new Stack<int>();
            s.Push(n[1]);
            while (true)
            {
                int t = s.Peek();
                if (map[t].prev != -1)
                    s.Push(map[t].prev);
                else
                    break;
            }
            while (s.Count > 0)
                stb.Append($"{s.Pop()} ");

            Console.WriteLine(stb);
        }
    }
}
