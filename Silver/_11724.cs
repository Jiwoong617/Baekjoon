using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.silver
{
    internal class _11724
    {
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            List<int>[] list = new List<int>[n[0]+1];
            for (int i = 1; i <= n[0]; i++)
                list[i] = new List<int>();

            for(int i = 0; i< n[1]; i++)
            {
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                list[arr[0]].Add(arr[1]);
                list[arr[1]].Add(arr[0]);
            }

            bool[] visited = new bool[n[0]+1];
            int ans = 0;

            for(int i = 1; i<= n[0]; i++)
            {
                if (!visited[i])
                {
                    ans++;
                    Queue<int> q = new Queue<int>();
                    q.Enqueue(i);
                    visited[i] = true;

                    while(q.Count > 0)
                    {
                        int temp = q.Dequeue();
                        foreach (int v in list[temp])
                        {
                            if (!visited[v])
                            {
                                q.Enqueue(v);
                                visited[v] = true;
                            }
                        }
                    }
                }
            }

            Console.WriteLine(ans);
        }
    }
}
