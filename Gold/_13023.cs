using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Gold
{
    internal class _13023
    {
        static int[] n;
        static List<int>[] person;
        static bool[] visited;
        static int ans = 0;

        static void Main(string[] args)
        {
            n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            person = new List<int>[n[0]];
            for (int i = 0; i < n[0]; i++)
                person[i] = new List<int>();
            for (int i = 0; i < n[1]; i++)
            {
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                person[arr[0]].Add(arr[1]);
                person[arr[1]].Add(arr[0]);
            }

            for (int i = 0; i < n[0]; i++)
            {
                visited = Enumerable.Repeat(false, n[0]).ToArray();
                Dfs(i, 1);
                if (ans == 1)
                    break;
            }

            Console.WriteLine(ans);
        }

        static void Dfs(int n, int count)
        {
            visited[n] = true;
            if (count >= 5)
            {
                ans = 1;
                return;
            }

            foreach (int next in person[n])
            {
                if (!visited[next])
                {
                    Dfs(next, count + 1);
                    visited[next] = false;
                }
            }
        }
    }
}
