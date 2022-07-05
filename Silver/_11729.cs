using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _11729
    {
        static int count;

        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            StringBuilder stb = new StringBuilder();
            hanoi(num, 1, 2, 3, stb);
            Console.WriteLine(count);
            Console.WriteLine(stb);
        }
        public static void hanoi(int num, int a, int b, int c, StringBuilder stb)
        {
            // a부터 b를 거쳐 c까지 이동
            if(num == 1)
            {
                stb.AppendLine($"{a} {c}");
                count++;
            }
            else
            {
                hanoi(num - 1, a, c, b, stb);
                count++;
                stb.AppendLine($"{a} {c}");

                hanoi(num - 1, b, a, c, stb);
            }
                
        }
    }
}
