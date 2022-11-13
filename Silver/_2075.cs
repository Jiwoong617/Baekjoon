using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.silver
{
    class _2075
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PriorityQueue<int, int> pq = new PriorityQueue<int, int>();

            for(int i = 0; i < n; i++)
            {
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                for (int j = 0; j < n; j++)
                {
                    pq.Enqueue(arr[j], arr[j]);
                    if (pq.Count > n)
                        pq.Dequeue();
                }
            }

            Console.WriteLine(pq.Dequeue());
        }
    }
}
