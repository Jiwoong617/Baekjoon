using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Gold
{
    class _1806
    {
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] sum = new int[n[0] + 1];
            //누적합
            for(int i = 1; i <= n[0]; i++)
                sum[i] = arr[i - 1] + sum[i-1];

            int min = 0; //왼쪽
            int max = 1; //오른쪽

            int temp = sum[1];
            int ans = n[0];
            bool can = false; //가능한지 아닌지
            while(max - min > 0 && max <= n[0])
            {
                //합이 더 크면 가능하고, 길이 조절
                if (temp >= n[1])
                {
                    if (ans > max - min)
                        ans = max - min;
                    min++;
                    can = true;
                }
                else
                    max++;

                if (max > n[0]) //인덱스 넘어갈수 있어서
                    temp = sum[max - 1] - sum[min];
                else
                    temp = sum[max] - sum[min];
            }

            if (can)
                Console.WriteLine(ans);
            else
                Console.WriteLine(0);
        }
    }
}
