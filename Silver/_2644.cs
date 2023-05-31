using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.silver
{
    internal class _2644
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] find = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int t = int.Parse(Console.ReadLine());

            int[] chon = Enumerable.Repeat(-1, n+1).ToArray();
            List<int>[] link = new List<int>[n+1];
            for (int i = 1; i <= n; i++)
                link[i] = new List<int>();
            while(t-- > 0)
            {
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                link[arr[0]].Add(arr[1]);
                link[arr[1]].Add(arr[0]);
            }

            Queue<int> q = new Queue<int>();
            q.Enqueue(find[0]);
            chon[find[0]] = 0;
            while(q.Count > 0)
            {
                int temp = q.Dequeue();
                foreach(int next in link[temp])
                {
                    if (chon[next] == -1)
                    {
                        chon[next] = chon[temp]+1;
                        q.Enqueue(next);
                    }
                }
            }

            Console.WriteLine(chon[find[1]]);
        }
    }
}
