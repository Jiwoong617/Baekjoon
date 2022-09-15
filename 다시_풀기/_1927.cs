using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.silver
{
    class _1927
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());
            PriorityQueue<int, int> p_que = new PriorityQueue<int, int>();

            for(int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num == 0 && p_que.Count < 1)
                    stb.AppendLine("0");

                else if (num == 0)
                    stb.AppendLine(p_que.Dequeue().ToString());

                else
                    p_que.Enqueue(num, num);
            }

            Console.WriteLine(stb);
        }
    }
}
