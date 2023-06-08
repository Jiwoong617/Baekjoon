using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.silver
{
    internal class _10819
    {
        static int n;
        static int[] arr;
        static bool[] visited;
        static int ans;
        static List<int> list = new List<int>();

        static void Main(string[] atgs)
        {
            n = int.Parse(Console.ReadLine());
            arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            visited = new bool[n];

            BackT();
            Console.WriteLine(ans);
        }

        static int Cal()
        {
            int sum = 0;
            for(int i = 1; i<n; i++)
            {
                sum += Math.Abs(list[i - 1] - list[i]);
            }
            return sum;
        }
        
        static void BackT()
        {
            if(list.Count >= n)
            {
                ans = Math.Max(ans, Cal());
                return;
            }

            for(int i = 0; i<n; i++)
            {
                if (!visited[i])
                {
                    visited[i] = true;
                    list.Add(arr[i]);
                    BackT();
                    visited[i] = false;
                    list.RemoveAt(list.Count-1);
                }
            }
        }
    }
}
