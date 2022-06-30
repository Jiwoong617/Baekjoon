using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _2869
    {
        static void Main(string[] args)
        {
            string[] n = Console.ReadLine().Split();
            int a = int.Parse(n[0]);
            int b = int.Parse(n[1]);
            int v = int.Parse(n[2]);

            int day = (v-b-1)/(a-b)+1;
            /*달팽이는 마지막날 안미끄러지니 v-b미터 올라감
            하루에 올라가는 거리는 a만큼 올라가고 b만큼 내려가니 a-b
            v-b가 정확히 나누어 떨어지지 않을 경우 거리가 조금 남는다는 것이니 몫에 1 더해주면됨
            하지만 정확히 나누어 떨어질 경우 하루를 더 계산 안해도 되니 몫에 v-b에 1을 빼줌
            */

            Console.WriteLine(day);
        }
    }
}
