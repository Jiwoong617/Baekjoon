using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Gold
{
    class _2470
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(arr);

            //최소 최대 인덱스
            int min = 0;
            int max = n - 1;
            int liquid = 2000000000;

            //왼쪽 오른쪽 답
            int left = 0;
            int right = n - 1;

            while(max-min > 0)
            {
                int sum = arr[max] + arr[min];
                if (liquid > Math.Abs(sum))
                {
                    liquid = Math.Abs(sum);
                    left = min;
                    right = max;
                }

                if (sum > 0)
                    max--;
                else
                    min++;
            }

            Console.WriteLine($"{arr[left]} {arr[right]}");
        }
    }
}
