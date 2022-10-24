using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.silver
{
    class _15828
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int> que = new Queue<int>();
            int num= 1;
            while (num != -1)
            {
                num = int.Parse(Console.ReadLine());
                if(que.Count < n)
                {
                    if(num > 0)
                        que.Enqueue(num);
                    else if (num == 0)
                        que.Dequeue();
                }
                else
                {
                    if (num == 0)
                        que.Dequeue();
                }

            }

            if (que.Count > 0)
                Console.WriteLine(string.Join(" ", que.ToArray()));
            else
                Console.WriteLine("empty");
        }
    }
}
