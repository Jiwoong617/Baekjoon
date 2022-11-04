using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Baekjoon.Gold
{
    class _1644
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();

            //소수 구하기
            for(int i = 2; i<=n; i++)
            {
                bool isprime = true;
                for (int j = 2; j * j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if (isprime)
                    list.Add(i);
            }
            //Console.WriteLine(string.Join(" ", list));

            int count = 0;
            int start = 0;
            int end = 0;
            while(start <= end && end < list.Count)
            {
                int sum = 0;
                for (int i = start; i <= end; i++)
                    sum += list[i];

                if (sum > n)
                    start++;
                else if (sum < n)
                    end++;
                else
                {
                    end++;
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
