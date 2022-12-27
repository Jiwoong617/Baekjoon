using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Silver
{
    internal class _11403
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());
            int inf = 10001;

            int[,] graph = new int[n,n];
            for (int i = 0; i < n; i++)
            {
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                for(int j = 0; j<n; j++)
                {
                    if (arr[j] == 0)
                        arr[j] = inf;

                    graph[i,j] = arr[j];
                }
            }

            for(int k = 0; k<n; k++)
            {
                for(int i = 0; i<n; i++)
                {
                    for(int j = 0; j<n; j++)
                        graph[i,j] = Math.Min(graph[i,j], graph[i,k] + graph[k,j]);
                }
            }

            for(int i = 0; i< n; i++)
            {
                for(int j = 0; j< n; j++)
                {
                    if (graph[i, j] == inf)
                        stb.Append("0 ");
                    else
                        stb.Append("1 ");
                }
                stb.AppendLine();
            }
            Console.WriteLine(stb);
        }
    }
}
