using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Silver
{
    internal class _15903
    {
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            long[] card = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            PriorityQueue<long, long> pq = new PriorityQueue<long, long>();

            for(int i = 0; i < card.Length; i++)
                pq.Enqueue(card[i], card[i]);

            for(int i = 0; i< n[1]; i++)
            {
                long a = pq.Dequeue();
                long b = pq.Dequeue();
                pq.Enqueue(a + b, a + b);
                pq.Enqueue(a + b, a + b);
            }

            long sum = 0;
            while (pq.Count > 0)
                sum += pq.Dequeue();

            Console.WriteLine(sum);
        }
    }
}
