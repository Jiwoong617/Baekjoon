using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Silver
{
    internal class _11725
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int>[] list = new List<int>[n + 1];
            for (int i = 1; i <= n; i++)
                list[i] = new List<int>();

            for(int i = 0; i<n-1; i++)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                list[input[0]].Add(input[1]);
                list[input[1]].Add(input[0]);
            }

            int[] childParent = new int[n + 1];
            bool[] visited = new bool[n+1];

            Queue<int> q = new Queue<int>();
            q.Enqueue(1);
            visited[1] = true;
            while(q.Count > 0)
            {
                int parent = q.Dequeue();
                foreach(int child in list[parent])
                {
                    if (!visited[child])
                    {
                        visited[child] = true;
                        childParent[child] = parent;
                        q.Enqueue(child);
                    }
                }
            }

            Console.WriteLine(string.Join("\n", childParent[2..(n+1)]));
        }
    }
}
