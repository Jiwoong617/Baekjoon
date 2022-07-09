using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Baekjoon.Silver
{
    class _2108
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            for (int i = 0; i < num; i++)
                arr[i] = int.Parse(Console.ReadLine());

            int[] count = Enumerable.Repeat<int>(0,8001).ToArray<int>();
            Array.Sort(arr);

            double ave = Math.Round((double)arr.Sum()/num); // 산술평균
            int mid = arr[(num - 1) / 2]; //중앙값
            int many = 0; // 최빈값
            int range = (num == 1 ? 0 : Math.Abs(arr[0]-arr[num-1])); // 범위

            //최빈값 구하기
            for(int i = 0; i<num; i++)
            {
                if (arr[i] < 0)
                    count[Math.Abs(arr[i]) + 4000]++;
                else
                    count[arr[i]]++;
            }
            int first = Array.IndexOf(count, count.Max());
            int last = Array.LastIndexOf(count, count.Max());

            if (first == last)
            {
                if (first > 4000)
                    many = -(first - 4000);
                else
                    many = first;
            }
            else
            {
                int temp = 0;
                for(int i = -4000; i<=4000; i++)
                {
                    int j = i;
                    if (i < 0)
                        j = Math.Abs(i) + 4000;
                    if (count[j] == count.Max())
                        temp++;
                    if (temp > 1)
                    {
                        many = i;
                        break;
                    }
                }
            }

            if (ave == -0)
                ave = 0;
            Console.WriteLine(ave);
            Console.WriteLine(mid);
            Console.WriteLine(many);
            Console.WriteLine(range);
        }
    }
}
