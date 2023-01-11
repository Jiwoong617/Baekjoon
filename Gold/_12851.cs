using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Gold
{
    internal class _12851
    {
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] arr = new int[100001];
            bool[] visited = new bool[100001];
            int[] visitedCount = new int[100001];

            if (n[0] == n[1])
            {
                Console.WriteLine(0);
                Console.WriteLine(1);
                return;
            }

            Queue<int> q = new Queue<int>();
            visited[n[0]] = true;
            q.Enqueue(n[0]);

            while(q.Count > 0)
            {
                int p = q.Dequeue();
                
                if(p-1 >= 0 && p-1 < 100001)
                {
                    if (!visited[p-1])
                    {
                        q.Enqueue(p - 1);
                        arr[p-1] = arr[p]+1;
                        visited[p-1] = true;
                        visitedCount[p - 1]++;
                    }
                    else if (arr[p]+1 <= arr[p-1])
                    {
                        q.Enqueue(p - 1);
                        arr[p - 1] = arr[p] + 1;
                        visitedCount[p - 1]++;
                    }
                }
                if(p+1 >= 0 && p+1 < 100001)
                {
                    if (!visited[p + 1])
                    {
                        q.Enqueue(p + 1);
                        arr[p + 1] = arr[p] + 1;
                        visited[p + 1] = true;
                        visitedCount[p + 1]++;
                    }
                    else if (arr[p] + 1 <= arr[p + 1])
                    {
                        q.Enqueue(p + 1);
                        arr[p + 1] = arr[p] + 1;
                        visitedCount[p + 1]++;
                    }
                }
                if(p*2 >= 0 && p*2 < 100001)
                {
                    if (!visited[p*2])
                    {
                        q.Enqueue(p*2);
                        arr[p*2] = arr[p] + 1;
                        visited[p*2] = true;
                        visitedCount[p*2]++;
                    }
                    else if (arr[p]+1 <= arr[p*2])
                    {
                        q.Enqueue(p*2);
                        arr[p * 2] = arr[p] + 1;
                        visitedCount[p*2]++;
                    }
                }
            }

            Console.WriteLine(arr[n[1]]);
            Console.WriteLine(visitedCount[n[1]]);
        }
    }
}
