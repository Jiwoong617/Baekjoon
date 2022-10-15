using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _1158
    {
        static void Main(string[] args)
        {
            int[] n  = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Queue<int> que = new Queue<int>();
            List<int> list = new List<int>();
            for (int i = 1; i <= n[0]; i++)
                que.Enqueue(i);

            int count = 1;
            while (que.Count > 0)
            {
                if (count == n[1])
                {
                    list.Add(que.Dequeue());
                    count = 1;
                }
                else
                {
                    count++;
                    que.Enqueue(que.Dequeue());
                }
            }

            Console.Write("<");
            Console.Write(string.Join(", ", list));
            Console.WriteLine(">");
        }
    }
}
