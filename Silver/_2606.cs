using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Baekjoon.silver
{
    class _2606
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            Dictionary<int, List<int>> line = new Dictionary<int, List<int>>();
            for(int i = 1; i<= n; i++)
                line[i] = new List<int>();

            for(int i= 0; i<m; i++)
            {
                int[] l = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                line[l[0]].Add(l[1]);
                line[l[1]].Add(l[0]);
            }

            bool[] visit = new bool[n + 1];
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            visit[1] = true;
            int count = 0;

            while(queue.Count > 0)
            {
                int dot = queue.Dequeue();
                foreach(int i in line[dot])
                {
                    if (!visit[i])
                    {
                        count++;
                        visit[i] = true;
                        queue.Enqueue(i);
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
