using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Silver
{
    class _2512
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int money = int.Parse(Console.ReadLine());

            int max = arr.Max();
            int min = 1;
            while(max >= min)
            {
                int mid = (max + min) / 2;
                int sum = 0;

                //가능한 예산 더하기
                foreach (int i in arr)
                    sum += Math.Min(i, mid);

                if (sum > money)
                    max = mid - 1;
                else
                    min = mid + 1;
            }

            Console.WriteLine(max);
        }
    }
}
