using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Baekjoon.Gold
{
    class _11054
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] leftsum = Enumerable.Repeat(1, n).ToArray();
            int[] rightsum = Enumerable.Repeat(1, n).ToArray();

            //왼쪽에서 증가
            for(int i = 1; i<n; i++)
            {
                for(int j = 0; j<i; j++)
                {
                    if (arr[i] > arr[j])
                        leftsum[i] = Math.Max(leftsum[i], leftsum[j] + 1);
                }
            }
            //오른쪽에서 증가
            for(int i = n-2; i>=0; i--)
            {
                for(int j = n-1; j> i; j--)
                {
                    if (arr[i] > arr[j])
                        rightsum[i] = Math.Max(rightsum[i], rightsum[j] + 1);
                }
            }

            int ans = leftsum[0] + rightsum[0];
            for (int i = 1; i< n; i++)
            {
                if (leftsum[i] + rightsum[i] > ans)
                    ans = leftsum[i] + rightsum[i];
            }

            //Console.WriteLine(string.Join(" ", leftsum));
            //Console.WriteLine(string.Join(" ", rightsum));
            Console.WriteLine(ans - 1);
        }
    }
}
