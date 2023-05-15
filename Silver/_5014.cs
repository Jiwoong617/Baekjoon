using System;
using System.Collections.Generic;
using System.Linq;

namespace Baekjoon.silver
{
    internal class _5014
    {
        static void Main(string[] args)
        {
            int[] fsgud = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = fsgud[0]; int u = fsgud[3]; int d = fsgud[4];
            int[] floor = Enumerable.Repeat(-1, fsgud[0]+1).ToArray();
            floor[fsgud[1]] = 0;
            Queue<int> q = new Queue<int>();
            q.Enqueue(fsgud[1]);
            while (q.Count > 0)
            {
                int t = q.Dequeue();

                if (t+u <= n && floor[t + u] == -1)
                {
                    q.Enqueue(t+u);
                    floor[t + u] = floor[t]+1;
                }
                if(t-d > 0 && floor[t-d] == -1)
                {
                    q.Enqueue(t - d);
                    floor[t - d] = floor[t]+1;
                }
            }
            Console.WriteLine(floor[fsgud[2]] != -1 ? floor[fsgud[2]] : "use the stairs");
        }
    }
}
