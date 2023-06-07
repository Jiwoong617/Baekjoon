using System;
using System.Collections.Generic;
using System.Linq;

namespace Baekjoon.Gold
{
    internal class _1715
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
            while(n-- > 0)
            {
                int m = int.Parse(Console.ReadLine());
                pq.Enqueue(m, m);
            }

            int sum = 0;
            while(pq.Count > 1)
            {
                int a = pq.Dequeue();
                int b = pq.Dequeue();
                sum += a + b;
                pq.Enqueue(a+b, a+b);
            }
            Console.WriteLine(sum);
        }
    }
}
