using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _11051
    {
        static void Main(string[] args)
        {
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            //11050 처럼 풀시 n이 커지면 범위를 벗어나 nzec 런타임이 남
            //파스칼 삼각형으로 풀어야됨.
            int[,] arr = new int[1001,1001];
            
            for(int i = 1; i<=a[0]; i++)
            {
                for(int j = 0; j<=a[0]; j++)
                {
                    if (i == j || j == 0)
                        arr[i,j] = 1;
                    else
                        arr[i,j] = (arr[i - 1,j] + arr[i - 1,j - 1]) % 10007;
                }
            }
            Console.WriteLine(arr[a[0],a[1]]);
        }
    }
}
