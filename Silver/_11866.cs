using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _11866
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Queue<int> que = new Queue<int>();
            Queue<int> ansque = new Queue<int>();
            for (int i = 1; i <= n[0]; i++)
                que.Enqueue(i);

            int count = 0;
            while (que.Count >0)
            {
                count++;
                if (count == n[1])
                {
                    ansque.Enqueue(que.Dequeue());
                    count = 0;
                }
                else
                    que.Enqueue(que.Dequeue());
            }

            stb.Append("<");
            for (int i = 0; i < n[0] - 1; i++)
                stb.Append($"{ansque.Dequeue()}, ");
            stb.Append($"{ansque.Dequeue()}>");
            Console.WriteLine(stb);
        }
    }
}
