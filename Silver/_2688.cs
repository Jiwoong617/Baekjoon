using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon
{
    class _2688
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            int test = int.Parse(Console.ReadLine());
            int[] n = new int[test];
            long[,] arr = new long[64, 10];
            //2
            //1 2 3 4 5 6 7 8 9 10

            //3
            //1 3 6 10 15 21 28 36 45 55
            //현개 값 = 이전의 처음 ~ 이전의 현재위치 다더한 것
            for (int i = 0; i < test; i++)
                n[i] = int.Parse(Console.ReadLine());

            //자리수 1일때는 전부 1
            for (int i = 0; i < 10; i++)
                arr[0, i] = 1;

            int max = n.Max();
            for (int i = 1; i<max; i++)
            {
                arr[i, 0] = 1; //끝이 0이면 1개밖에 없음
                for (int j = 1; j < 10; j++)
                    arr[i, j] = arr[i - 1, j] + arr[i, j - 1];
            }

            long sum;
            for(int i = 0; i<test; i++)
            {
                sum = 0;
                for(int j = 0; j<10; j++)
                {
                    sum += arr[n[i] - 1, j];
                }
                stb.AppendLine(sum.ToString());
            }

            Console.WriteLine(stb);
        }
    }
}
