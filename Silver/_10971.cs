using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Silver
{
    internal class _10971
    {
        static int n;
        static int[][] arr;
        static int ans = int.MaxValue;
        static bool[] visited;

        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            visited = new bool[n];
            arr = new int[n][];
            for (int i = 0; i < n; i++)
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            for(int i = 0; i<n; i++)
            {
                visited[i] = true;
                DFS(0, 0, i, i);
                visited[i] = false;
            }


            Console.WriteLine(ans);
        }

        static void DFS(int count, int sum, int now, int start)
        {
            if(count >= n-1)
            {
                if (arr[now][start] != 0)
                    ans = Math.Min(ans, sum + arr[now][start]);

                return;
            }

            for(int i = 0; i<n; i++)
            {
                if (!visited[i] && arr[now][i] != 0)
                {
                    visited[i] = true;
                    DFS(count + 1, sum + arr[now][i], i, start);
                    visited[i] = false;
                }
            }
        }
    }
}
