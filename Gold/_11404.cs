using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Gold
{
    internal class _11404
    {
        const int inf = 10000000;

        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            //arr[시작, 도착] = 가중치
            int[,] arr = new int[n + 1, n + 1];

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i != j)
                        arr[i, j] = inf;
                }
            }

            for (int i = 0; i < m; i++)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                arr[input[0], input[1]] = Math.Min(arr[input[0], input[1]], input[2]);
            }

            //플로이드 워셜
            for (int i = 1; i <= n; i++) //거치는 노드
            {
                for (int j = 1; j <= n; j++) // 시작 노드
                {
                    if (i == j)
                        continue;

                    for (int k = 1; k <= n; k++) // 끝 노드
                        arr[j, k] = Math.Min(arr[j, i] + arr[i, k], arr[j, k]);
                }
            }

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (arr[i, j] == inf || i == j)
                        stb.Append("0 ");
                    else
                        stb.Append(arr[i, j].ToString()+" ");
                }
                stb.AppendLine();
            }

            Console.WriteLine(stb);
        }
    }
}
