using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _1463
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n + 1];
            arr[1] = 0;
            /*
             *  1 -> 0
                2 -> 1
                3 -> 1
                4 -> 2
                5 -> 3
                6 -> 2
                7 -> 3
                8 -> 3
                9 -> 2
                10 -> 3

                11 -> 4
                12 -> 3
                13 -> 4
                14 -> 4
                15 -> 4
                16 -> 4
                17 -> 5
                18 -> 3
                19 -> 4
                20 -> 4
                
                21 -> 4
                22 -> 5
                23 -> 6
                2로 나눠지면 n/2에 1더한거, 3으로 나눠지면 n/3에 +1이랑 같음
                아니면 그냥 그 전거에 1더해주면 됨.
                그냥하면 이상하게되니 비교해줘야됨.
             */
            for (int i = 2; i<=n; i++)
            {
                arr[i] = arr[i - 1] + 1;
                if (i % 3 == 0)
                    arr[i] = Math.Min(arr[i], arr[i / 3] + 1);
                if (i % 2 == 0)
                    arr[i] = Math.Min(arr[i], arr[i / 2] + 1);
            }
            Console.WriteLine(arr[n]);
        }
    }
}
