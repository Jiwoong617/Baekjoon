using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Practice
{
    class _15988
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());

            long[] arr = new long[1000000];
            //1 = 1, 2 = 2, 3 = 4, 4 = 7
            //i-1에 1더한거,  i-2에 2더한거 i-3에 3더한거
            arr[0] = 1; arr[1] = 2; arr[2] = 4;
            for(int i = 3; i<1000000; i++)
                arr[i] = (arr[i - 1] + arr[i - 2] + arr[i-3]) % 1000000009;

            for (int i = 0; i<n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                stb.AppendLine(arr[num-1].ToString());
            }
            Console.WriteLine(stb);
        }
    }
}
