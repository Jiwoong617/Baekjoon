using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _2164
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int> que = new Queue<int>();

            for (int i = 1; i <= n; i++)
                que.Enqueue(i);

            while(que.Count > 1)
            {
                que.Dequeue();

                if (que.Count == 1)
                    break;

                que.Enqueue(que.Dequeue());
            }

            Console.WriteLine(que.Peek());
        }
    }
}
