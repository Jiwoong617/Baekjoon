using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _14888
    {
        static int min = 2147483647;
        static int max = -217483647;
        static int n;
        static int[] arr;
        static int[] oper;

        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            oper = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            dfs(arr[0], 1);
            Console.WriteLine($"{max}\n{min}");
        }

        //깊이탐색
        static void dfs(int sum, int now)
        {
            if(now == n)
            {
                max = Math.Max(sum, max);
                min = Math.Min(sum, min);
                return;
            }

            for(int i = 0; i<4; i++)
            {
                if(oper[i] > 0)
                {
                    oper[i]--;

                    if (i == 0)
                        dfs(sum + arr[now], now+1);
                    else if (i == 1)
                        dfs(sum - arr[now], now+1);
                    else if (i == 2)
                        dfs(sum * arr[now], now+1);
                    else
                        dfs(sum / arr[now], now+1);

                    oper[i]++;
                }
            }
        }
    }
}
